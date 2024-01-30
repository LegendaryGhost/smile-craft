# SmileCraft
A desktop app to manage the patients of a dentistry

## I - Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### 1 - Prerequisites

Before you can run this project, you need to install the following NuGet packages:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Tools`
- `Npgsql.EntityFrameworkCore.PostgreSQL`

You can install these packages using the NuGet Package Manager in Visual Studio or by running the following command in the .NET Core CLI:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

### 2 - Setting Up Environment Variables

This project requires an environment variable named `POSTGRES_CONNECTION_STRING` to be set. This variable should hold the connection string to your PostgreSQL database.

#### a - Windows

You can set this environment variable in the System Properties dialog. Go to the Advanced tab, click on Environment Variables, and create a new system variable with the name `POSTGRES_CONNECTION_STRING` and the value of your connection string.

#### b - Linux/Mac

You can set this environment variable in your shell profile file (like `~/.bashrc` or `~/.zshrc`). Add the following line to the file:

```bash
export POSTGRES_CONNECTION_STRING="Host=127.0.0.1:5432;Database=smilecraft;Username=myusername;Password=mypassword"
```

Replace `"Host=127.0.0.1:5432;Database=mydatabase;Username=myusername;Password=mypassword"` with your actual connection string.

After setting the environment variable, save the file and reload your shell profile:

```bash
source ~/.bashrc
```

Or, if you're using zsh:

```bash
source ~/.zshrc
```

## II - Running the Project

Now you should be able to run the project. Please refer to the project documentation for specific instructions.

## III - Built With

- [.NET Core](https://dotnet.microsoft.com/) - The web framework used
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - The ORM used
- [Npgsql](https://www.npgsql.org/) - The PostgreSQL provider for Entity Framework Core

## IV - Authors

- **Rihantiana MBOLATSIORY** - *Primary Developper* - [LegendaryGhost](https://github.com/LegendaryGhost)

## V - License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## VI - Acknowledgments

- Hat tip to anyone whose code was used

## VII - Functional Specification

1. **Introduction**

The objective of this application is to enable a dental clinic to manage the dental status of its clients, record operations performed on their teeth, add new patients, modify the state of their teeth, add operations on teeth, and generate operation suggestions based on the available budget, with options for prioritizing aesthetics or health.

2. **Technologies Used**

   - Programming Language: C# with .NET
   - Database: PostgreSQL with Entity Framework

3. **Features**

   a. **Patient Management**

      - [x] Addition of a new patient with the following information:
        - Last Name
        - First Name
        - Date of Birth
        - Phone Number
        - Address

      - [ ] Modification of information for an existing patient.

   b. **Dental State Management**

      - [x] Recording the dental state for each patient, rated from 0 to 10 according to specified criteria:
        - 0: Tooth removed
        - 1 to 3: Tooth almost completely destroyed
        - 4 to 6: Cavity
        - 7 to 9: Dirty
        - 10: Perfect

      - [x] Modification of the dental state for a patient.

   c. **Operation Management**

      - [ ] Addition of a new operation with the following information:
        - Operation type (cleaning, repair, removal, replacement)
        - Operation date
        - Operation cost
        - Tooth involved
        - Associated patient

      - [x] List of operations performed on each patient.

   d. **Operation Suggestions**

      - [x] Suggestion of a list of operations based on a specified budget.
      - [x] Option to choose between two priorities:
        - [x] Aesthetics priority: Front teeth (canines and incisors) will be prioritized.
        - [x] Health priority: Molars and premolars will be prioritized.

   e. **Calculation of Operation Costs**

      - [ ] Operation costs depend on the type of tooth (incisor, canine, premolar, molar).
      - [ ] Tariffs will be configurable.

4. **Security**

   - [ ] Authentication: Only authorized users will have access to the application.
   - [ ] Access rights management: Different levels of access (administrator, dentist, administrative staff).

5. **User Interface**

   - [ ] User-friendly interface allowing easy and intuitive use of the application.

6. **Performance**

   - [ ] The application should be capable of handling a large amount of data without compromising performance.

7. **Documentation**

   - [ ] Comprehensive documentation of the source code and application functionalities.
   - [ ] User guide for end-users.

8. **Testing**

   - [ ] Conduct unit tests and integration tests to ensure stability and reliability of the application.

9. **Maintenance and Support**

   - [ ] Establish a maintenance strategy and technical support plan as needed.
