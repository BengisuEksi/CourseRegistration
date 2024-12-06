## Course Registration Simulation
This application consists of screens where students and teachers can view course hours, and an administrator can manage these courses, add new teachers, students, and branches. It was developed with C# and SQL Server.

Features
1. Login Screen:
This screen offers three different options; student login, teacher login, and admin login. Each login redirects the user to a specific screen.

2. Student:
- Student Login Screen: Students registered in the database log in with their student numbers and passwords.
- Student Information Screen: All information related to the student (ID, name, surname, class, mail, phone, student number, password, photograph) is displayed on this screen.
  - The Update button allows updating the photograph, name, surname, mail, phone, and password.
  - The View Courses button displays the courses assigned to the student.
  - The Log Out button allows the student to return to the Student Login screen, and from there, back to the Login Screen using the Back button.

3. Teacher:
- Teacher Login Screen: Teachers registered in the database log in with their teacher numbers and passwords.
- Teacher Information Screen: All information related to the teacher (ID, name, surname, branch, teacher number, password) is displayed on this screen.
  - The Update button allows updating the name, surname, and password.
  - The View Courses button displays the courses assigned to the teacher.
  - The Log Out button allows the teacher to return to the Teacher Login screen, and from there, back to the Login Screen using the Back button.

4. Admin:
- Admin Login Screen: The system administrator can log in with the default credentials; Name: "user" and Password: "password".
- Admin Information Screen: This screen provides options for adding new courses, new teachers, new branches, and new students, as well as viewing registered courses.
  - New Course: 
    - Add : The administrator enters the branch, teacher, student, date, time, and course status into the input fields to add a session.
    - Update Course Information : This button allows editing course information which populate the input fields by double-clicking on a row in the data grid.
    - View Course Information : This button displays all registered courses.
  - New Teacher: 
    - Add : The administrator enters the teacher's name, surname, branch, and password, then clicks the Add button. The system assigns a random teacher number, which the teacher uses with the password to log in.
  - New Branch : 
    - Add : The administrator enters a branch name and clicks the Add button. If the branch already exists in the system, an error message is displayed; otherwise, the branch is added successfully.
  - New Student : 
    - Add : The administrator enters the student's name, surname, class, phone number, mail, and password, then clicks the Add button. The system assigns a random student number, which the student uses with the password to log in.

Database Structure
* Teacher Table: Stores teacher ID, name, surname, branch ID, teacher number, and password.
* Student Table: Stores student ID, name, surname, class, mail, phone, photograph link, password, and student number.
* Branch Table: Stores branch ID and names.
* Course Table: Stores course ID, branch ID, teacher ID, student ID, date, time, and status.

Usage
1. Logging In
  * Student Login: Log in using the student number and password. Successful login redirects to the Student Information screen.
  * Teacher Login: Log in using the teacher number and password. Successful login redirects to the Teacher Information screen.
  * Admin Login: Use the default credentials ("user" and "password") to log in. Successful login redirects to the Admin Information screen.

2. Student Operations
  * View Information: Personal details are displayed and can be updated if needed.
  * View Courses: View the courses assigned to the student.
  * Logout: End the operations and return to the login screen.

3. Teacher Operations:
  * View Information: Personal details are displayed and can be updated if needed.
  * View Courses: View the courses assigned to the teacher.
  * Logout: End the operations and return to the login screen.

4. Admin Operations:
  * Add New Course: Create a new course by entering the relevant details.
  * View Existing Courses: View all courses in a table format.
  * Update Course Information: Edit and update course details.
  * Add New Teacher: Add a teacher with the relevant details. A random teacher number is automatically assigned.
  * Add New Student: Add a student with the relevant details. A random student number is automatically assigned.
  * Add New Branch: Add a new branch by entering its name.

5. Navigation
  * Each user group has a Log Out option to easily return to the login screen.

Requirements
* .NET Framework.
* SQL Server or a compatible database driver for database connection.

![1](https://github.com/user-attachments/assets/ae03c663-d990-4711-a13a-e873fa0baac9)

![2](https://github.com/user-attachments/assets/0e64d5d3-4449-4d99-812f-acc6cbb0cf96)

![3](https://github.com/user-attachments/assets/d3af31de-af06-4c94-bf0c-960a7d208b26)

![4](https://github.com/user-attachments/assets/3c9bdf5a-b945-4c28-86f7-f830d2065fd1)

![5](https://github.com/user-attachments/assets/c3753470-8693-4b4c-9e45-d5aa5baac95a)

![6](https://github.com/user-attachments/assets/96c706d3-0cc0-4f34-8e12-3f6d260c5f27)

![7](https://github.com/user-attachments/assets/bdd928df-41f2-4dc5-af9c-65ffb9420677)

![8](https://github.com/user-attachments/assets/c4132cac-8b67-4ef0-a17d-b1a70ed31c2e)

![9](https://github.com/user-attachments/assets/e02fc690-41de-47a9-b5be-f6124a00e86e)

![10](https://github.com/user-attachments/assets/77537c23-8a06-4ca4-8787-ac3611b43d36)

![11](https://github.com/user-attachments/assets/a8ad3d04-4693-4557-b2c7-628af0c5504a)

![12](https://github.com/user-attachments/assets/bbb3aa9d-e944-47a6-9487-3cd76d442656)

![13](https://github.com/user-attachments/assets/82f73aba-eb0a-4f9b-ba94-4385402c0cb7)

![14](https://github.com/user-attachments/assets/f0900354-3079-4483-9cb4-3a5c71af20e9)

![15](https://github.com/user-attachments/assets/699c2527-c938-43b3-bbbc-67b7feca3358)

![16](https://github.com/user-attachments/assets/067da04a-29ef-4087-ac5e-880288b14148)

![17](https://github.com/user-attachments/assets/ce3fa8a5-fda3-4a3d-aba9-75c6127e8e1d)

![18](https://github.com/user-attachments/assets/5890d6e0-2aa5-4be1-b900-b90f4d1ddb02)

![19](https://github.com/user-attachments/assets/69f29872-f568-4a32-b25b-336189027852)

![20](https://github.com/user-attachments/assets/d4f833ac-6307-44d6-aec2-ca571b877fdd)
