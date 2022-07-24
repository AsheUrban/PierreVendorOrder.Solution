# Week 9 Independent Project: Pierre's Vendor Order Solution!

#### A website that allows Pierre to manage their vendors and their orders!

#### By Ashe Urban

## Technologies Used

* _C#_
* _dotnet_
* _Markdown_

## Description

_Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors._

_For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships._

_Here's the challenge:_ build a C# web application to help Pierre manage his vendor orders.

_Link to assignment:_ https://epicenter.epicodus.com/courses/968/code_reviews/5859

### Pierre's Vendor Orders

Use Razor to display information on each page.

Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".

## Setup/Installation Requirements

* _clone or download responsitory to your local_
* _cd into Bakery.Tests and run dotnet restore and dotnet test to run/add to tests_
* _cd into Bakery and run dotnet restore, dotnet build, and dotnet run to run web application_

## Known Bugs

* _None_


## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) July 2022 Ashe Urban
