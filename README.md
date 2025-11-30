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
<img width="1353" height="681" alt="CategoryCreate" src="https://github.com/user-attachments/assets/89608ea2-4ee9-4ea1-8922-65443dc4b3bb" />
<img width="1349" height="682" alt="CategoryListing" src="https://github.com/user-attachments/assets/c4788faa-7068-445d-a653-1b9fa2c98374" />
<img width="1352" height="680" alt="CategoryEdit" src="https://github.com/user-attachments/assets/1508b3fe-be28-4de4-9d7c-1e8056fb671e" />
<img width="1364" height="680" alt="ProductDeletePopUp" src="https://github.com/user-attachments/assets/a0067b93-b195-461f-b5cf-8f3f82034f08" />

## Note
- The Kachuwa framework is not included in this repository. Please Clone it separately and reference it as explained above.
- This project demonstrates basic CRUD functionality and project structure using the Kachuwa Framework.
- Project has also used javascript and jquery for deletion feature for making it more smooth and user friendly
- This small project is made smooth as possible
