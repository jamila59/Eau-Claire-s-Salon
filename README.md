# Eau Claire's Salon

#### _A C# web application which uses ASP.Net Core MVC Web Application and Entity to create databases.  - 01/17/20_

#### _By **Jamila Aliyeva**_

## Description

A C# program where the user is given the option to view  hair stylists and and thier clients. When the user selects the "Add a new Stylist" option he or she is directed to a form where they are asked to enter a stylist name. After, they are directed to another page which allows the user to select the entered any stylist from the displyed list. Duing so will direct the user to a page that displays a many to one relationship between the stylist and thier clients.

## Setup/Installation Requirements

1. Open command line and clone this repository to Desktop:
    ```
    $ git clone https://github.com/Jamila59/Hair-Salon.git
    ```
2. Create stylist and client tables using SQL comment
    ```
3. In command line:
    ```
    $ dotnet restore 
    ```
    $ dotnet build
    ```
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET / ASP.Net Core MVC Web Application /  Entity / My SQL Workbench / Razor 

## Support and contact details

_Please contact Jamila Aliyeva with questions and comments at Aliyeva852@gmail.com ._

## SQL Statments (Database)

**Statement 1**

CREATE TABLE stylists ( StylistId int(11) NOT NULL AUTO_INCREMENT, Name varchar(255) DEFAULT NULL, PRIMARY KEY (StylistId) ) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

**Statement 2**

CREATE TABLE clients ( ClientId int(11) NOT NULL AUTO_INCREMENT, Description varchar(255) DEFAULT NULL, StylistId int(11) DEFAULT '0', PRIMARY KEY (ClientId) ) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



### MIT License
Copyright (c) 2019 Jamila Aliyeva

*Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*


Copyright (c) 2016 **_Jamila Aliyeva_**


