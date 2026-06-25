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
SmartLockerSystem
│
├── SmartLocker.Api
│   ├── Controllers
│   ├── Models
│   ├── DTOs
│   ├── Data
│   ├── Services
│   ├── Migrations
│   ├── Program.cs
│   └── appsettings.json
│
├── smart-locker-ui
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