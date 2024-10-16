# Edukator 

Edukator is an online course platform project developed using **.NET Core 5.0 MVC**. The application allows users to register, login, leave comments, and rate courses. It also includes admin and manager roles for system management and course organization.

## Features

- **User Management**: 
  - Users can register and log in to the system.
  - Admins can assign different roles to users (e.g., Admin, Manager).
  - Users can leave comments on courses and rate them.
  
- **Role-Based Access Control**:
  - Role assignments are managed through the `RoleAssignController` and integrated with ASP.NET Identity.
  
- **Areas**: 
  - The project is organized into separate areas for **admin** and **manager** roles, enhancing maintainability and clarity of access levels.

- **Responsive Design**: 
  - The front-end is built with **Bootstrap**, ensuring that the site is mobile-friendly and works well on different devices.

## Technology Stack

- **.NET Core 5.0 MVC**: Used for structuring the web application.
- **Entity Framework Core**: Used for database operations, following the code-first approach.
- **ASP.NET Identity**: For handling authentication, authorization, and user roles.
- **HTML, CSS, Bootstrap**: For the front-end design and responsiveness.

## Project Structure

The solution is divided into different layers:
- **Business Layer**: Contains the business logic and services.
- **Data Access Layer**: Handles data interaction through repositories and Entity Framework.
- **DTO Layer**: Defines Data Transfer Objects for communication between layers.
- **Entity Layer**: Contains the models representing the database structure.
- **Presentation Layer**: Manages the user interface and controllers for handling HTTP requests.

## Installation

To run the project locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/erhangndz/Edukator.PresentationLayer.git
