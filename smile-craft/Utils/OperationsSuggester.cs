using Microsoft.EntityFrameworkCore;
using smile_craft.Data;
using smile_craft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Utils
{
    public static class OperationsSuggester
    {
        public static (List<Perform>, int) Suggest(SmilecraftContext context, int patientId, int amount, int priority)
        {
            List<Perform> operations = GetAllPossibleOperations(context, patientId);
            switch(priority)
            {
                case 1:
                    operations = OrderByAesthetic(operations);
                    break;

                case 2:
                    operations = OrderByHealth(operations);
                    break;
            }

            // Calculate the remaining amount
            /*int remainingAmount = amount;
            foreach (var operation in operations)
            {
                remainingAmount -= operation.Cost;
            }

            return (operations, remainingAmount);*/

            return (operations, (int)1000.0);
        }

        private static List<Perform> OrderByAesthetic(List<Perform> operations)
        {
            var categoriesOrder = new Dictionary<string, int>
            {
                {"Incisor", 1},
                {"Canine", 2},
                {"Premolar", 3},
                {"Molar", 4}
            };

            var operationsOrder = new Dictionary<int, int>
            {
                {3, 1},
                {4, 2},
                {2, 3},
                {1, 4}
            };

            return operations
                .OrderBy(op => categoriesOrder[op.CategoryName ?? "Molar"])
                .ThenBy(op => operationsOrder[op.IdOperation ?? 1])
                .ThenBy(op => op.CurrentMark ?? 0)
                .ThenBy(op => op.IdTooth)
                .ToList();
        }
        private static List<Perform> OrderByHealth(List<Perform> operations)
        {
            var categoriesOrder = new Dictionary<string, int>
            {
                {"Molar", 1},
                {"Premolar", 2},
                {"Canine", 3},
                {"Incisor", 4}
            };

            var operationsOrder = new Dictionary<int, int>
            {
                {3, 1},
                {4, 2},
                {2, 3},
                {1, 4}
            };

            return operations
                .OrderBy(op => categoriesOrder[op.CategoryName ?? "Molar"])
                .ThenBy(op => operationsOrder[op.IdOperation ?? 1])
                .ThenBy(op => op.CurrentMark ?? 0)
                .ThenBy(op => op.IdTooth)
                .ToList();
        }

        private static List<Perform> GetAllPossibleOperations(SmilecraftContext context, int patientId)
        {
            List<State> teethStates =
                [.. 
                    context.States.Include(s => s.IdMarkNavigation)
                        .Include(s => s.IdToothNavigation)
                        .Where(s => s.IdPatient == patientId)
                ];
            List<Operation> operations = [.. context.Operations];
            List<Price> prices = [.. context.Prices];
            List<Category> categories = [.. context.Categories];
            List<Perform> performs = [];
            int idOperation = 0;
            int mark;
            foreach (State state in teethStates)
            {
                mark = state.IdMarkNavigation.Mark1;
                if (mark == 0)
                {
                    idOperation = 4;
                }
                else if(mark <= 3)
                {
                    idOperation = 3;
                }
                else if(mark <= 6)
                {
                    idOperation = 2;
                }
                else if (mark <= 9)
                {
                    idOperation = 1;
                }

                if (mark < 10)
                {
                    performs.Add
                    (
                        new Perform()
                        {
                            IdPatient = patientId,
                            IdTooth = state.IdTooth,
                            IdOperation = idOperation,
                            CurrentMark = mark,
                            Price = prices.Find
                                (
                                    p => p.IdCategory == state.IdToothNavigation.IdCategory && p.IdOperation == idOperation
                                )?.Price1,
                            OperationName = operations.Find(op => op.IdOperation == idOperation)?.Name,
                            CategoryName = categories.Find(ca => ca.IdCategory == state.IdToothNavigation.IdCategory)?.Designation
                        }
                    );

                    // Adds the extra operation for replacement after removing it
                    if (idOperation == 3)
                    {
                        idOperation = 4;
                        performs.Add
                        (
                            new Perform()
                            {
                                IdPatient = patientId,
                                IdTooth = state.IdTooth,
                                IdOperation = idOperation,
                                CurrentMark = mark,
                                Price = prices.Find
                                    (
                                        p => p.IdCategory == state.IdToothNavigation.IdCategory && p.IdOperation == idOperation
                                    )?.Price1,
                                OperationName = operations.Find(op => op.IdOperation == idOperation)?.Name,
                                CategoryName = categories.Find(ca => ca.IdCategory == state.IdToothNavigation.IdCategory)?.Designation
                            }
                        );
                    }
                }
            }

            return performs;
        }

    }
}
