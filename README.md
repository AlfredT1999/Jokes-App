# Jokes-App
App Created With ASP.NET 


ASP.NET BUILD A WEB AND DATABASE APPLICATION IN C#.

The web app makes and response to jokes. 

This application is a basic CRUD application:

- Create 
- Read 
- Update
- Delete.

ASP.NET is a platform with end to end solution, backend and frontend options:

- ASP.NET Core is a full stack (Database, Business Logic, HTML).
- Can be combined with popular frontend services such as, React, Angular, Vue or mobile apps.

The sections of how I create the web app are the following:

1. Models Views and Controllers (MVC).
2. Database Setup.
3. Registration, login and security.
4. Search the database.


1. Models Views and Controllers (MVC):

- Model = classes (objects).
- View = web page (Razor HTML).
- Controller = connects models, business logic and web pages.

Introduction to the MVC Design Pattern.

The MVC design pattern helps to enforce separation of concerns to help you to avoid mixing 
presentation logic, business logic, and data access logic together.

"Model view controller design pattern"

- Model = manages the behaviour and data.
- View = manages the display of data.
- Controller = handles page events and navigation between pages.

''View"

- HTML CSS code (similar).
- Usually gets a list of data from the controller.
- Dynamically combines data with HTML in a template.
- Razor (ASP.NET).

"Model"

- Data related.
- Consists of classes / objects with properties.
- Uses SQL statements.
- Supplies the controller with lists of objects.
- Model interacts with the database, this is called Database Migrations.

In this project for the Database Setup, I use ORM Object Relational Mapper instead of DAO Data Access Object.

Let's see the difference between them:

"DATA ACCESS OBJECT (DAO)"

- Manually create tables.
- Traditional method of database access.
- Write your own SQL statements.
- Database managers (DBA's) usually prefer DAOs.
- Provides more visibility on finding problems.

"OBJECT RELATIONAL MAPPER (ORM)"

- Allow the computer to generate database tables based on classes definded in the application.
- Database is updated using migrations.
- Entity Framework is Microsoft's ORM.
- Simple for basic applications.




