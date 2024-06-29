# My Minimal API Project

![Excited GIF](https://i.giphy.com/media/v1.Y2lkPTc5MGI3NjExMmVyd2t6bHlwc29nZTIwaThuMHd5ZHc1bThiYzhlZTlxbXgyOHJnbyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/13HgwGsXF0aiGY/giphy.gif)

## Overview

This repository contains my implementation and exercises as I follow along with the book "Mastering Minimal APIs in ASP.NET Core" by Andrea Tosato, Marco Minerva, and Emanuele Bartolesi. The project demonstrates the principles and practices for building, testing, and deploying minimal APIs using .NET 6.

## Table of Contents

1. [Project Setup](#project-setup)
2. [Implemented Features](#implemented-features)
3. [How to Run](#how-to-run)
4. [Learning Resources](#learning-resources)
5. [Contributing](#contributing)
6. [License](#license)

## Project Setup

### Prerequisites

- Basic knowledge of C#, .NET, and REST APIs
- Visual Studio 2022 or Visual Studio Code
- .NET 6 SDK

### Restoring Dependencies

Restore the project dependencies:

```bash
dotnet restore
```

## Implemented Features

### Chapter 1: Introduction to Minimal APIs

- Set up a new minimal API project
- Basic structure and routing

### Chapter 2: Exploring Minimal APIs and Their Advantages

- Implemented routing, route handlers, and route parameters
- Parameter binding and custom bindings
- Response handling and serialization

### Chapter 3: Working with Minimal APIs

- Integrated Swagger for API documentation
- Enabled and configured CORS
- Implemented global API settings and error handling

### Chapter 4: What’s New in .NET 6?

- Explored new features and improvements in .NET 6

### Chapter 5: Dependency Injection in a Minimal API Project

- Implemented dependency injection (DI) with various lifetimes

### Chapter 6: Using Logging to Identify Errors

- Configured and customized logging with various providers

### Chapter 7: Exploring Validation and Mapping

- Handled validation using data annotations and FluentValidation
- Mapped data using manual mapping and AutoMapper

### Chapter 8: Integration with the Data Access Layer

- Set up and used Entity Framework Core and Dapper for data access
- Implemented the repository pattern and added endpoints

### Chapter 9: Adding Authentication and Authorization

- Implemented JWT bearer token authentication and authorization
- Configured role-based and policy-based authorization

### Chapter 10: Leveraging Globalization and Localization

- Added globalization and localization support
- Used resource files for localization
- Integrated localization with validation frameworks

### Chapter 11: Evaluating and Benchmarking the Performance of Minimal APIs

- Performed load tests and benchmarked APIs using tools like k6 and BenchmarkDotNet

## How to Run

### Running the API

To run the minimal API project, use the following command:

```bash
dotnet run
```

## Learning Resources

- [Mastering Minimal APIs in ASP.NET Core](https://www.packtpub.com/en-us/product/mastering-minimal-apis-in-aspnet-core-9781803237824)
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)

## Contributing

Feel free to fork this repository and make contributions. Please submit pull requests for any enhancements or bug fixes.
