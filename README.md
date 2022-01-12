# Library

#### Web application that demonstrate Authentication with Identity  in C#

#### Created By: Kate Kiatsiri , Zach wilson, Hannah young

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* Bootstrap , CSS

## Description

This application is an 11th independent project at Epicodus to show understanding in ASP.Net Core MVC many-to-may relationships using mySql, Entity, and Razor. This app allows the user to manage their engineers and the machines they are licensed to repair.

![Alt text](Factory/wwwroot/img/sql.jpg?raw=true "Title")

## TODO

1. Implement copies and checkouts
2. Add roles for patron and librarian, with separate authorization
  -> patrons can see all books/authors/copies, can't edit, delete, or create books
  -> librarians can CRUD books/authors/copies
  -> patrons can see their checkouts, can create new checkout, can't update or delete checkout
  -> librarians can CRUD checkouts for all patrons
