# Minimal_API - Customer List CRUD Application

Minimal_API is a simple CRUD (Create, Read, Update, Delete) application for managing a list of customers.
This application is built using .NET 8.0 with a minimal API approach, providing a lightweight and efficient way to perform basic operations on a customer list.
Additionally, Swagger is integrated into the application, allowing you to interact with the API more conveniently.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Features
Minimal_API provides the following features for managing a customer list:

- **Add Customer**: Add a new customer to the list.
- **Get Customers**: Retrieve a list of all customers.
- **Get Customer by ID**: Retrieve a specific customer by their unique ID.
- **Update Customer**: Update the details of an existing customer.
- **Delete Customer**: Remove a customer from the list.

## Technologies Used
This application is built using the following technologies:

- .NET 8.0
- Minimal API Approach
- Swagger (for API documentation and interaction)

## Getting Started

### Prerequisites
Before you can run the Minimal_API application, make sure you have the following prerequisites installed on your system:

- [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation
1. Clone this repository to your local machine:

   ```shell
   git clone https://github.com/PilarczykM/Minimal_API.git
   ```

2. Navigate to the project directory:

   ```shell
   cd Minimal_API
   ```

3. Build and run the application:

   ```shell
   dotnet build
   dotnet run
   ```

The application will start, and you can access it using your web browser, API client or Swagger.

## Usage
You can use your favorite API client (e.g., Postman or cURL) or a web browser to interact with the Minimal_API application. Below, you'll find information on the available API endpoints and their usage.

## API Endpoints

### Get All Customers
- **URL**: `/customers`
- **HTTP Method**: GET
- **Description**: Retrieve a list of all customers.

### Get Customer by ID
- **URL**: `/customers/{id}`
- **HTTP Method**: GET
- **Description**: Retrieve a specific customer by their unique ID.

### Add Customer
- **URL**: `/customers`
- **HTTP Method**: POST
- **Description**: Add a new customer to the list.

### Update Customer
- **URL**: `/customers/{id}`
- **HTTP Method**: PUT
- **Description**: Update the details of an existing customer.

### Delete Customer
- **URL**: `/customers/{id}`
- **HTTP Method**: DELETE
- **Description**: Remove a customer from the list.

## Swagger Integration
Minimal_API includes Swagger for API documentation and interaction. To access the Swagger interface, open your web browser and navigate to the following URL:

```
http://localhost:5093/swagger/index.html
```
Swagger provides a user-friendly interface that allows you to explore and interact with the API endpoints, making it easier to test and understand how the application works.

## Contributing
If you'd like to contribute to this project, please follow these steps:
1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Create a pull request with a clear description of your changes.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
