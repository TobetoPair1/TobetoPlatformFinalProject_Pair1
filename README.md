# Tobeto Backend Project

This project serves as the backend for the [Tobeto](https://tobeto.com/) website, an online software education platform. Built with .NET Core, the project adopts a multi-layered architecture to ensure scalability, maintainability, and a clean separation of concerns.

## Overview

Tobeto is a comprehensive platform dedicated to delivering high-quality software education. The backend project is structured across multiple layers, each playing a specific and crucial role in the system's functionality:

### Entities

The **Entities** layer defines the fundamental data structures used throughout the application. 
Entity relationships are meticulously designed to reflect the intricacies of the educational domain, ensuring a robust foundation for the application.

### DataAccess

The **DataAccess** layer manages the interaction with the underlying data storage, typically a relational database. Key components include:

- **DbContext**: Defines the database context, specifying how entities map to tables and managing the database connection.
- **Repositories**: Implements the repository pattern for each entity, providing a standardized interface for data access operations.
- **Entity Configurations**: Configures the Entity Framework relationships, ensuring accurate mapping between entities and database tables.

This layer is crucial for maintaining data integrity, optimizing database operations, and facilitating seamless communication between the application and the database.

### Core

The **Core** layer focuses on providing essential services and utilities that are vital for the application's overall functionality. Key components include:

- **Caching Service**: Implements caching mechanisms to optimize data retrieval and improve application performance.
- **Exception Handling Middleware**: Centralized handling of exceptions to ensure a consistent and user-friendly experience.
- **Logging Service**: Facilitates comprehensive logging of application events for monitoring and debugging purposes.
- **Security Utilities**: Manages security-related operations such as JWT generation, encryption, and hashing.
- **Validation Service**: Provides a robust validation mechanism to enforce data integrity and adhere to business rules.

This layer abstracts cross-cutting concerns, promoting code reusability and maintainability.

### Business

The **Business** layer encapsulates the application's business logic, orchestrating the interaction between the DataAccess layer and the WebApi. Key components include:

- **Services**: Business logic for specific functionalities, such as course management, user authentication, and enrollment processing.
- **DTOs (Data Transfer Objects)**: Defines data structures for communication between layers, encapsulating the data exchanged.
- **Business Rules and Workflows**: Implements the rules governing the application's core logic and orchestrates complex workflows.

This layer ensures the integrity and consistency of data operations, enforcing business rules and handling complex business logic.

### WebApi

The **WebApi** layer provides the external interface for client applications, allowing them to interact with the backend services. Key components include:

- **Controllers**: Define API endpoints, handle incoming HTTP requests, and orchestrate the flow of data.
- **Request and Response Models**: Define the structure of data exchanged between clients and the backend.
- **Middleware**: Includes authentication middleware to secure API endpoints.

This layer serves as the entry point for client applications, offering a standardized interface for accessing the platform's functionalities.

## Getting Started

To set up the Tobeto Backend project locally, follow these steps:

1. Clone the repository to your local machine:
   ```sh
   git clone https://github.com/TobetoPair1/TobetoPlatformFinalProject_Pair1.git

2. Open terminal & Navigate to the project directory:

cd TobetoPlatformFinalProject_Pair1

3. Install the project dependencies:

dotnet restore

4. Run the application:

dotnet run

The application will be accessible at the specified API endpoints, allowing you to explore and interact with the backend services.

## API Documentation
For detailed documentation on how to interact with the Tobeto Backend API, refer to https://swagger.io/blog/api-documentation-guide/





