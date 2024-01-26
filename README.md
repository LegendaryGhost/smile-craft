# SmileCraft
A desktop app to manage the patients of a dentistry

## I - Functional Specification

1. **Introduction**

The objective of this application is to enable a dental clinic to manage the dental status of its clients, record operations performed on their teeth, add new patients, modify the state of their teeth, add operations on teeth, and generate operation suggestions based on the available budget, with options for prioritizing aesthetics or health.

2. **Technologies Used**

   - Programming Language: C# with .NET
   - Database: PostgreSQL with Entity Framework

3. **Features**

   a. **Patient Management**

      - [ ] Addition of a new patient with the following information:
        - Last Name
        - First Name
        - Date of Birth
        - Phone Number
        - Address

      - [ ] Modification of information for an existing patient.

   b. **Dental State Management**

      - [ ] Recording the dental state for each patient, rated from 0 to 10 according to specified criteria:
        - 0: Tooth removed
        - 1 to 3: Tooth almost completely destroyed
        - 4 to 6: Cavity
        - 7 to 9: Dirty
        - 10: Perfect

      - [ ] Modification of the dental state for a patient.

   c. **Operation Management**

      - [ ] Addition of a new operation with the following information:
        - Operation type (cleaning, repair, removal, replacement)
        - Operation date
        - Operation cost
        - Tooth involved
        - Associated patient

      - [ ] List of operations performed on each patient.

   d. **Operation Suggestions**

      - [ ] Suggestion of a list of operations based on a specified budget.
      - [ ] Option to choose between two priorities:
        - [ ] Aesthetics priority: Front teeth (canines and incisors) will be prioritized.
        - [ ] Health priority: Molars and premolars will be prioritized.

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
