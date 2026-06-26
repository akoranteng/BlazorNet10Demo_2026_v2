
BlazorNet10Demo
A modular, learning‑focused Blazor application built on .NET 10, demonstrating clean architecture, layered design, and incremental feature development.
This repository is structured to support scalability, maintainability, and real‑world engineering workflows.

Solution Structure
The solution is organized into three cleanly separated projects:

1. BlazorNet10Demo.Domain
Contains core domain models and business entities

Represents the core logic of the application

No external dependencies

2. BlazorNet10Demo.DataAccess
Responsible for data persistence

Currently uses an in‑memory service

Will host EF Core DbContext and repositories in the next milestone

Communicates with the Domain layer

3. BlazorNet10Demo.UI
Blazor Web UI project

Contains pages, components, and UI logic

Depends on Domain and DataAccess layers

🎯 Purpose of This Repository
This repository is used to:

Practice clean architecture with .NET 10

Build a Blazor application step‑by‑step

Demonstrate proper Git workflow and branching

Learn EF Core, DbContext, and layered design

Prepare modular content for future e‑learning material

🧱 Current Milestones
✔ Milestone 01 — Domain Layer
Created the solution structure

Added the Domain project

Added the TaskItem entity

Set up initial architecture

✔ Milestone 02 — In‑Memory Product CRUD (UI + DataAccess)
This milestone delivers a fully functional in‑memory CRUD implementation for the Product module within the solution. It establishes the foundational architecture for the UI, DataAccess, and Domain layers before introducing EF Core in the next milestone.

Completed Features
UI Layer (Blazor Components)
ProductList.razor — displays all products

ProductDetails.razor — shows individual product details

ProductCreate.razor — form for adding new products

ProductEdit.razor — form for editing existing products

Integrated navigation and routing

Form validation using:

EditForm


DataAnnotationsValidator

Model binding with validation attributes

DataAccess Layer
DataAccess Layer
IProductService interface created

In‑memory implementation of ProductService

CRUD operations implemented:

GetAllAsync()

GetByIdAsync()

CreateAsync()

UpdateAsync()

DeleteAsync()

Domain Layer
Strongly typed Product model with validation attributes

Shared across UI and DataAccess layers

Architecture Summary
UI Project
Razor components for listing, creating, editing, and viewing products

Uses dependency injection to access IProductService

NavigationManager handles routing after CRUD operations

Architecture Summary
UI Project
Razor components for listing, creating, editing, and viewing products

Uses dependency injection to access IProductService

NavigationManager handles routing after CRUD operations

Why This Milestone Matters
This milestone ensures:

The UI is fully functional and validated

Routing and navigation work correctly

CRUD operations behave consistently

The service interface is stable

The solution structure is clean, modular, and ready for real persistence

This creates a solid foundation for the next major milestone:
introducing EF Core for database‑backed persistence.

⏳ Milestone 03 — Infrastructure Layer (EF Core)
(Next)

Add EF Core

Create AppDbContext

Configure entity relationships

Add database migrations

Seed initial data

Replace in‑memory ProductService with EF Core implementation
🚀 How to Run the Project
Follow these steps to run the BlazorNet10Demo application locally:

1. Clone the repository
Code
git clone https://github.com/<your-username>/BlazorNet10Demo.git
2. Open the solution
Open the .sln file in Visual Studio 2022 or later.

3. Restore NuGet packages
3. Restore NuGet packages
Visual Studio will restore automatically, but you can also run:

Code
dotnet restore

4. Set the startup project
In Solution Explorer:

Right‑click BlazorNet10Demo.UI

Select Set as Startup Project

5. Run the application
Press: F5  → Run with Debugging
Ctrl + F5 → Run without Debugging
The app will launch in your browser at:

Code
https://localhost:<port>/
