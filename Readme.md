# Smart Package Locker System

A Smart Package Locker Management System built using:

- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- React + Vite
- Axios
- Swagger

The application allows administrators to manage lockers and packages while enabling customers to retrieve packages using a pickup code.
---

# Features

## Authentication

- User Registration
- User Login
- JWT Token Authentication
- Role-Based Authorization

## Locker Management

- Create Lockers
- View Lockers
- Update Locker Status
- Available / Occupied Status Tracking

## Package Management

- Assign Package to Locker
- Generate Pickup Code
- Package Collection Workflow
- Package Status Tracking

## Dashboard

- View Total Lockers
- Available Lockers
- Occupied Lockers
- Total Packages

---

# Project Structure

```text
SmartPackageLocker
│
├── SmartPackageLocker.Server
│   ├── Controllers
│   ├── Models
│   ├── DTOs
│   ├── Data
│   ├── Services
│   ├── Program.cs
│   └── appsettings.json
│
├── SmartPackageLocker.Client
│   ├── src
│   │   ├── pages
│   │   ├── components
│   │   ├── services
│   │   ├── context
│   │   └── App.jsx
│   │
│   ├── package.json
│   └── vite.config.js
│
└── README.md
```
---

 The application follows clean architecture principle and coding best practices using solid pinciple and design patterns.
 
# SOLID PRINCIPLE
- S single responsibility implemented to all class level.
- O open/Close principle impleneted to classes must allow only for extension instead of modification.
- L not used
- I Interface has only relevant prop.
- D Dependecy Injection implemented. 

---

# DESIGN PATTERN
- Repository pattern
- Singleton pattern
- Factory pattern
- Strategy pattern
- Dependency Injection (DI)


