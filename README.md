# CategoryAPI

## Project Overview

CategoryAPI is a RESTful ASP.NET Core Web API that provides CRUD (Create, Read, Update, Delete) operations for managing categories. The application is built using ASP.NET Core, Entity Framework Core, and PostgreSQL while following a layered architecture with Repository and Service patterns.

This project demonstrates clean code practices, separation of concerns, validation, and database integration using PostgreSQL.

---

## Technology Stack

* ASP.NET Core Web API
* .NET 10
* Entity Framework Core
* PostgreSQL
* Swagger / OpenAPI
* C#

---

## Project Architecture

The application follows a layered architecture:

```text
CategoryAPI
│
├── Controllers
│   └── CategoryController.cs
│
├── Services
│   ├── ICategoryService.cs
│   └── CategoryService.cs
│
├── Repositories
│   ├── ICategoryRepository.cs
│   └── CategoryRepository.cs
│
├── Models
│   └── Category.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Program.cs
├── appsettings.json
└── CategoryTable.sql
```

### Layers

#### Controller Layer

Handles HTTP requests and responses.

#### Service Layer

Contains business logic and validation rules.

#### Repository Layer

Handles database operations using Entity Framework Core.

#### Data Layer

Manages database connectivity through Entity Framework Core DbContext.

---

## Features

* Create a new category
* Retrieve all categories
* Retrieve a category by ID
* Update an existing category
* Delete a category
* PostgreSQL database integration
* Swagger API documentation
* Input validation using Data Annotations
* Repository and Service pattern implementation

---

## Database Setup

### Create Database

Create a PostgreSQL database:

```sql
CREATE DATABASE CategoryDB;
```

### Create Categories Table

Run the following SQL script:

```sql
CREATE TABLE categories (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    description VARCHAR(255),
    is_active BOOLEAN DEFAULT TRUE,
    created_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_date TIMESTAMP
);
```

---

## Configuration

Update the PostgreSQL connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=CategoryDB;Username=postgres;Password=YOUR_PASSWORD"
  }
}
```

Replace:

* `CategoryDB` with your database name
* `postgres` with your PostgreSQL username
* `YOUR_PASSWORD` with your PostgreSQL password

---

## Installation & Setup

### Clone Repository

```bash
git clone https://github.com/<your-github-username>/CategoryAPI.git
```

### Navigate to Project

```bash
cd CategoryAPI
```

### Restore Packages

```bash
dotnet restore
```

### Build Project

```bash
dotnet build
```

### Run Application

```bash
dotnet run
```

---

## Swagger Documentation

After running the application, open Swagger UI:

```text
https://localhost:<port>/swagger
```

Swagger provides an interactive interface to test all API endpoints.

---

## API Endpoints

### Get All Categories

```http
GET /api/Category
```

### Get Category By Id

```http
GET /api/Category/{id}
```

### Create Category

```http
POST /api/Category
```

Sample Request:

```json
{
  "name": "Electronics",
  "description": "Electronic products",
  "isActive": true
}
```

### Update Category

```http
PUT /api/Category/{id}
```

Sample Request:

```json
{
  "name": "Updated Electronics",
  "description": "Updated category description",
  "isActive": true
}
```

### Delete Category

```http
DELETE /api/Category/{id}
```

---

## Validation

The application includes validation rules:

* Category Name is required
* Category Name maximum length is 100 characters
* Proper HTTP status codes are returned for invalid requests

---

## Error Handling

The application handles common scenarios:

* Invalid requests (400 Bad Request)
* Resource not found (404 Not Found)
* Server-side exceptions (500 Internal Server Error)

---

## Testing

All endpoints were tested using:

* Swagger UI
* HTTP response validation
* CRUD operation verification

---

## Design Principles

This project follows:

* Object-Oriented Programming (OOP)
* SOLID Principles
* Separation of Concerns
* Repository Pattern
* Service Layer Pattern

---

