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
A. First of all you need to open the [GroupC.Uni.bak](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/GroupC.Uni.bak) file in your sql developer databases.
B. open the solution of the project In Visual Studio
And in the following 3 Projects: GroupC.Uni.ConsumingApi / GroupC.Uni.Web / GroupC.Uni.Student
you need to update the `appsettings.json` file : each `server` attribute with your computer name, and the `DataBase` attribute with the name you've chosen when restoring GroupC.Uni.bak file in previous step.

---
## Project Architecture
The project consists of two major Apps:

1. The first one is made for the Admins and testCenter to manage Courses/Questions/Exams each according to their role.
To run this project you need to set the `GroupC.Uni.Web` as Startup project and then run the solution.

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
choose the radiobuttom 'multiple startup projects' and change the actions of the two projects `GroupC.Uni.ConsumingApi` / `GroupC.Uni.Student` to "Start".

---
## About the project

**Exam Platform** is an ASP.Net Core Web project, which provide a platform that allow admins and test centers’ mangers to create exams and allow students to solve them.
The project consists of two major Apps:
1.The first one is made for the Admins and testCenters to manage Courses/ Topics/ Questions/ Exams each according to his role.
Each Course has several topics. For each topic, a certain number of questions can be added. Then when an Admin/testCenter decide to create an exam, it will be created by selecting a group of questions randomly from the questions exesting in the database.
2.The second one is made to let the students choose an exam, solve it and submit it. The student can show her/his courses, Exams and Submissions.
Here, will be provided some of the processes that can be accomplished through the first project of the website:

•	Logging in as Admin/TestCenter within an email and password:

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/1.LogIn.png "Logging In")

•	Admin/TestCenter home page: From the home page as shown in the following picture, the user can access view/add student/course/topic/question/exam according to their rule.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/2.HomePage.png "Homepage")

•	In the home page when pressing on one of the four upper boxes, a table of its content will be shown, as the following figure when pressing on “See content” from the “Exam” box.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/3.Exams.png "Exams")

•	In the home page when hovering over the user name, a popup containing their information will be shown.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/4.PopUp.png "Pop Up")

•	From the popup, when pressing on “profile”, a profile page with the user information will be shown.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/5.ProfilePage.png "Profile page")

•	Adding a new course will require filling the following form: 

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/6.AddingCourse.png "ِAdding Course")

•	After adding a new course (or any another element) successfully, a message in the top will appear informing the user that the course was added successfully and the course details will be listed.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/7.SuccessMessage.png "Success Message")

•	A table of the added questions will be as follow, please note that questions can be added as HTML text which allow formatting the question text.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/8.AddQuestions.png "Add Questions")

•	Creating a new exam will require selecting a desired number of questions in order to create the exam randomly of the existed questions for the selected course.

![alt text](https://github.com/Nemat-Allah-Aloush/Exam-Platform-ASP.NET-Core/blob/main/Images/9.CreateExam.png "Create Exam")


Other services are provided with this project, only some of the services were shown above.

---

Note: The project with developed within a team of three.
