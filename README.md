# BlazorNet10Demo

This project is a learning and demonstration solution built using **.NET 10** and **Blazor**.  
It follows a clean, layered architecture to support scalability, maintainability, and modular development.

---

## 📁 Solution Structure

The solution is organized into the following projects:

### 1. BlazorNet10Demo.Domain
- Contains core domain models and business entities.
- Represents the core logic of the application.
- No external dependencies.

### 2. BlazorNet10Demo.DataAccess
- Responsible for data persistence.
- Will contain EF Core DbContext and repository implementations.
- Communicates with the Domain layer.

### 3. BlazorNet10Demo.UI
- Blazor Web UI project.
- Contains pages, components, and UI logic.
- Depends on Domain and DataAccess layers.

---

## 🎯 Purpose of This Repository

This repository is used to:

- Practice clean architecture with .NET 10
- Build a Blazor application step-by-step
- Demonstrate proper Git workflow and branching
- Learn EF Core, DbContext, and layered design
- Prepare modular content for future e-learning material

---

## 🧱 Current Milestones

### ✔ Milestone 01 — Domain Layer
- Created the solution structure
- Added the Domain project
- Added the TaskItem entity
- Set up initial architecture

### ⏳ Milestone 02 — Infrastructure Layer (Next)
- Add EF Core
- Create DbContext
- Configure entity relationships
- Prepare for database migrations

---

## 🚀 How to Run the Project

1. Open the solution in Visual Studio 2022 or later.
2. Restore NuGet packages.
3. Build the solution.
4. Run the BlazorNet10Demo.UI project.

---

## 📌 Requirements

- .NET 10 SDK
- Visual Studio 2022 or later
- EF Core 10 (to be added in Milestone 02)

---

## 📄 License

This project is for educational and demonstration purposes.
