SimpleCRUD Project (using Kachuwa Framework)
1. Project Overview

A simple .NET MVC project demonstrating CRUD operations (Create, Read, Update, Delete) using the Kachuwa Framework.
This project shows how to structure a small MVC app with models, controllers, and views while leveraging Kachuwa features.

2. Features

CRUD operations for a sample entity (e.g., Category/Product)

MVC architecture

Basic validation on forms

Kachuwa framework integration for database operations

3. Prerequisites

.NET 7 SDK (or your project’s version)

Visual Studio 2022 or VS Code

SQL Server (or modify connection string for another database)

Kachuwa Framework: https://github.com/SilentTurtle/Kachuwa

4. Setup Instructions

Clone the repo:

git clone https://github.com/Ashishgithub7/SimpleCRUD.git
cd SimpleCRUD/src/SampleProjectMVC


Add Kachuwa Framework

Clone Kachuwa somewhere on your machine:

git clone https://github.com/SilentTurtle/Kachuwa.git


Reference it in your project as you did before.

Restore NuGet packages (if any):

dotnet restore


Update database connection string in appsettings.json:

"ConnectionStrings": {
  "Default": "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;"
}


Run the project:

dotnet run


Open in browser: https://localhost:5001 (or the port shown in console)

5. Screenshots
<img width="1353" height="681" alt="CategoryCreate" src="https://github.com/user-attachments/assets/9c730055-7d7b-401f-9c85-3a38021a215c" />
<img width="1349" height="682" alt="CategoryListing" src="https://github.com/user-attachments/assets/72fbca99-fc34-42b3-94de-75f612ff00f7" />
<img width="1352" height="680" alt="CategoryEdit" src="https://github.com/user-attachments/assets/fcf627a8-3deb-45ab-a83b-db00a6cc3f2d" />
<img width="1354" height="683" alt="ProductListingAfterUpdate" src="https://github.com/user-attachments/assets/434c1b56-ef14-48fd-a3d8-2ea5c98afe26" />
<img width="1364" height="680" alt="ProductDeletePopUp" src="https://github.com/user-attachments/assets/2f436bd5-2816-4aad-bfe6-67310190da92" />

6. Notes

This project is a demo to showcase usage of Kachuwa Framework.

The Kachuwa folder is not included in this repo. Clone it separately and reference as explained.
