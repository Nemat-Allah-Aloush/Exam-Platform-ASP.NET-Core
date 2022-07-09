# Exam-Platform-ASP.NET-Core
An academic project at HIAST university. The project was developed using C# programing language and ASP.NET Core platform.

---

## Index
1. [Used software and Requirments](#used-software-and-requirments)
2. [Instructions](#instructions)
3. [Project Architecture](#project-architecture)
4. [About the project](#about-the-project)
---

## Used software and Requirments 
SQL Server Management & Visual Studio.

---
## Instructions
To Run the project:
A. First of all you need to open the GroupC.Uni.bak file in your sql developer databases.
B. open the solution of the project In Visual Studio
And in the following 3 Projects: GroupC.Uni.ConsumingApi / GroupC.Uni.Web / GroupC.Uni.Student
you need to update the ''appsettings.json'' file : each ''server'' attribute with your computer name, and the 'DataBase' attribute with the name you've chosen when restoring GroupC.Uni.bak file in previous step.

---
## Project Architecture
The project consists of two major Apps:

1. The first one is made for the Admins and testCenter to manage Courses/Questions/Exams each according to their role.
To run this project you need to set the 'GroupC.Uni.Web' as Startup project and then run the solution.

In the log-in page, you can use one of the following username and password to log in :
- As a Testcenter :
	TestCenter@gmail.com     pass: Test.12345
	AppTest@gmail.com	 pass: Test.12345
	TestCenter_1@gmail.com   pass: Test.12345
	TofelTest@gmail.com      pass: Test.12345

- As an Admin : 
	adminWithRoles_2@gmail.com    pass: Test.12345
	Nour@gmail.com		      pass: Test.12345
- As a Student:
	Amal@gmail.com		pass: Test.12345
	Sara@gmail.com		pass: Test.12345
	Jad@gmail.com		pass: Test.12345
After logging in you can check the site.

2. The second one is made to let the students choose an exam, solve it and submit it. The student Can show their courses/Exams/Submissions. 
To run this project you need to open the solution properties -> common proporties -> startup project and then 
choose the radiobuttom 'multiple startup projects' and change the actions of the two projects 'GroupC.Uni.ConsumingApi' / 'GroupC.Uni.Student' to "Start".

---
## About the project

---

Note: The project with developed within a team of three.
