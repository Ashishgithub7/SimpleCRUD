# SimpleCRUD Project (using Kachuwa Framework)

## Project Overview
**SimpleCRUD** is a .NET MVC project demonstrating CRUD operations (Create, Read, Update, Delete) using the **Kachuwa Framework**.  
It shows how to structure a small MVC app with models, views, and controllers in 4 layer architechture(Common, Data, Business and Presentation) while leveraging Kachuwa features. This project serves as a simple, functional example of a web application built with .NET MVC.

---

## Features
- CRUD operations for a related sample entities (Category/Product)  
- MVC architecture with Models, Views, Controllers  
- Form validation using standard ASP.NET MVC validation techniques and Fluent Validation
- Integration with **Kachuwa Framework** for simplifying database operations  
- Clean folder structure and organized project layout

---

## Prerequisites
- **.NET 8 SDK** 
- **Visual Studio 2022** or **VS Code**  
- **SQL Server** (or another supported database; update connection string accordingly)  
- **Kachuwa Framework**: [https://github.com/SilentTurtle/Kachuwa](https://github.com/SilentTurtle/Kachuwa)

---

## Setup Instructions

1. **Clone the repository**

```bash
git clone https://github.com/Ashishgithub7/SimpleCRUD.git
cd SimpleCRUD/src/SampleProjectMVC 
```
2. **Add Kachuwa Framework**

- Clone Kachuwa to your local machine:

```bash
git clone https://github.com/SilentTurtle/Kachuwa.git
```
- Reference the class library project Kachuwa.Web from SampleProject.MVC and Kachuwa.Core from DAL Project
3. **Restore the nuget Packages**
4. **Configure Database**
  - Create a new Database
  - Change the connection string in appsettings.json accordingly
5. **Build and Run The Project**

## Screenshots
<img width="1353" height="681" alt="CategoryCreate" src="https://github.com/user-attachments/assets/169da922-faf0-4aa1-8981-d221e8b0fbd7" />
<img width="1349" height="682" alt="CategoryListing" src="https://github.com/user-attachments/assets/f4980db1-6a70-417e-a6d9-7cab4793790c" />
<img width="1352" height="680" alt="CategoryEdit" src="https://github.com/user-attachments/assets/8223de18-67e2-4bed-8347-8cb7205abb28" />
<img width="1352" height="682" alt="CategoryListingAfterEdit" src="https://github.com/user-attachments/assets/ced701cc-8022-4ede-8782-2218a123da9d" />
<img width="1352" height="682" alt="ProductListing" src="https://github.com/user-attachments/assets/4ac3b413-c537-4d70-85b7-2df00fb4a82c" />
<img width="1352" height="681" alt="ProductCreate" src="https://github.com/user-attachments/assets/e0b7f130-9cd6-4ed4-8dc3-17125883ac32" />
<img width="1352" height="681" alt="ProductListingAfterCreate" src="https://github.com/user-attachments/assets/399646db-fd1e-4562-a82e-fdab85c4eb7d" />
<img width="1353" height="681" alt="ProductUpdate" src="https://github.com/user-attachments/assets/44e06331-1c52-4c51-a26b-ea9278b788aa" />
<img width="1354" height="683" alt="ProductListingAfterUpdate" src="https://github.com/user-attachments/assets/45a6f21f-e687-4ee6-8be1-8195b7d838d7" />
<img width="1364" height="680" alt="ProductDeletePopUp" src="https://github.com/user-attachments/assets/afebc967-a00e-4385-bb9c-8dd6d965c999" />

## Note
- The Kachuwa framework is not included in this repository. Please Clone it separately and reference it as explained above.
- This project demonstrates basic CRUD functionality and project structure using the Kachuwa Framework.
- Project has also used javascript and jquery for deletion feature for making it more smooth and user friendly
- This small project is made smooth as possible
