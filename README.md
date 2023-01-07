This is my all taskes that I have done during my intership, including:
1. Building reports for actual sales comparing to sales plan of sale room 1 and sale room 2 of Rang Dong company
2. Building Research and Development (R&D) report of Rang Dong company

I spent two months for the first task and one month for the second one completing my code project. In this three months, my work involves in a work flow below:
1.	Creating tables with previously unified fields, data types, and constraints in the database on **SQL Server Management Studio** (SSMS)
2.	Generating `Models` in project
3.	Creating a service folder in `Services` that is used to write a function that creates a table and fills the data into a table, and a folder `Controller` that is used to write an API to run the above function. In each controller file, there should be 2 files Controller.cs and Route.cs to make API calls according to the corresponding path.
4.	After I have finished writing the code, I conduct to run the project, then undertaken to call the API to init (get data to the Raw table) or import (for external template data like Excel files) and transform (from the Raw table will transform to other formats). corresponding dim/fact table). If there is an error or time out, we will debug to find the error until Response returns 200 (OK)
5.	Going to SSMS and check the tables to see if there is data, and meet and discuss with the **Data analyst** team to check if the data types and constraints are correct or not. If you need to add more tables or edit any fields, go back to Step 1 and repeat the process until everything is completed.

In this project, I attach a text file `Incremental load algorightm` that I illustrate my algorithm for solving Incremental Load procedure. In addition to, I create a folder `HashModels` which contain `Models` files adding two attributes **Key** and **Value**. Both of them are used for above incremental load algorithm.
