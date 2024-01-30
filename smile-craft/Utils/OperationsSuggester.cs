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
        public static (List<Perform>, decimal) Suggest(List<State> teethStates, int patientId, decimal amount, int priority)
        {
            // Your logic to generate operations goes here
            // Let's assume you have a method GenerateOperations that returns a list of operations
            List<Perform> operations = GetAllPossibleOperations(teethStates, patientId);
            /*switch(priority)
            {
                case 1:
                    operations = OrderByAesthetic(patientId);
                    break;

                case 2:
                    operations = OrderByHealth(patientId);
                    break;
            }

            // Calculate the remaining amount
            decimal remainingAmount = amount;
            foreach (var operation in operations)
            {
                remainingAmount -= operation.Cost;
            }

            return (operations, remainingAmount);*/

            return (operations, (decimal)1000.0);
        }

        private static List<Perform> GetAllPossibleOperations(List<State> teethStates, int idPatient)
        {
            List<Perform> performs = [];
            foreach (State state in teethStates)
            {
                int mark = state.IdMarkNavigation.Mark1;
                if (mark == 0)
                {
                    performs.Add
                    (
                        new Perform()
                        {
                            IdPatient = idPatient,
                            IdTooth = state.IdTooth,
                            IdOperation = 4
                        }
                    );
                }
                else if(mark <= 3)
                {
                    performs.Add
                    (
                        new Perform()
                        {
                            IdPatient = idPatient,
                            IdTooth = state.IdTooth,
                            IdOperation = 3
                        }
                    );
                    performs.Add
                    (
                        new Perform()
                        {
                            IdPatient = idPatient,
                            IdTooth = state.IdTooth,
                            IdOperation = 4
                        }
                    );
                }
                else if(mark <= 6)
                {
                    performs.Add
                    (
                        new Perform()
                        {
                            IdPatient = idPatient,
                            IdTooth = state.IdTooth,
                            IdOperation = 2
                        }
                    );
                }
                else if (mark <= 9)
                {
                    performs.Add
                    (
                        new Perform()
                        {
                            IdPatient = idPatient,
                            IdTooth = state.IdTooth,
                            IdOperation = 1
                        }
                    );
                }
            }

            return performs;
        }

    }
}
