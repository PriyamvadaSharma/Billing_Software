# Billing_Software
A Window application of Billing.

<h3>Overview</h3>
This is a window application of a Billing Software where a user or the owner of the firm having the credentials logs in, and can make entries of bank' branches, employees, products and customers. Later it can keep records of the products purchased and billing done date wise.Also it keeps records of the advance payments done by the customers and accordingly shows the balance. When the payment is done,it makes the bill and also prepares the ledger report of the client.
In windows application, we are going to log in with same credentials which we have registered in web application and while we are logging for the first time in windows application we need an Internet connection to that you can also login into the application while the application is offline.
After Successful login, a new form is shown in which User is going to add new product and while doing this process we do not require an internet connection.
When an internet connection is available it will sync all data from windows application to web application [web server] and this process will run in background.
Meanwhile it is transferring all data to the web server it will also delete that data from windows application database which is transferred.

Software Requirements
-------------------
SQL server 2008 express,Visual Basics .NET server

USAGE
------
`Login.cs` is the login form through which the user enter the MDI Page (Multiple Document Interface). `Register.cs` sile is the signup file. After login, the MDI page enables users to add Branch (`Branch Master.cs`),Customers(`Customer Master`),Employee(`Employee Master`) and Product(`Product Master`). File `Purchase Order` enables user to add record of the the purchase according to the available orders and displays the price.
File `Cash Book.cs` has options to add half payments and add commission rates or discount percentage and so tells the remaining amount to be deposited before the payment date. Remaining files like `Billing.cs` creates the bill and `Report Form` prints the report for the records.

Applications & Future Scope
----------------------------

Through this Window application,Billing records of a firm or a retail store anything can be done.It enables user to keep records and print bills according to the payments made untill the whole payment is made

<br><br>

Hope you will enjoy running the application.
