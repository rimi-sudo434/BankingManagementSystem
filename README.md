# 🏦 Banking Management System

A **Banking Management System** developed using **C#** and the **.NET Console Application** framework.

This project demonstrates **Object-Oriented Programming (OOP)** concepts, modular programming, and console-based application development. The system allows users to perform basic banking operations such as creating accounts, depositing money, withdrawing money, viewing account details, and checking transaction history through an interactive Command-Line Interface (CLI).

This project was created for learning purposes to understand C# programming, .NET development, class-based architecture, and GitHub project management.

---

## Project Overview

The Banking Management System is a console-based application that simulates basic banking operations.

The project is divided into multiple classes to maintain clean code organization and better understanding of object-oriented design.

The application provides:

- Account creation
- Money deposit
- Money withdrawal
- Account information display
- Transaction history tracking
- Interactive terminal-based navigation

---

## Features

- Create a new bank account
- Deposit money
- Withdraw money
- View account details
- View transaction history
- Colored console interface
- Menu-driven system
- object-Oriented Programming implementation
- Simple and user-friendly interface

---

##  Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Programming Language |
| .NET | Application Framework |
| Console Application | User Interface |
| Git | Version Control |
| GitHub | Repository Hosting |
| Ubuntu Linux | Development Environment |

---

## Project Structure

```text
BankingManagementSystem
│
├── Account.cs
├── Bank.cs
├── Transaction.cs
├── Program.cs
├── BankingManagementSystem.csproj
├── README.md
├── LICENSE
├── .gitignore
├── bin/
└── obj/

## Prerequisites

Before running this project, install:

- .NET SDK 8.0 or later
- Git
- Visual Studio Code (Optional)

---

##  Installation

Clone the repository:

```bash
git clone git@github.com:rimi-sudo434/BankingManagementSystem.git
```

Navigate to the project directory:

```bash
cd BankingManagementSystem
```

---

##  Build the Project

Run:

```bash
dotnet build
```

---

## Run the Project

Execute:

```bash
dotnet run
```

---

#  Application Menu

```
=================================
   BANKING MANAGEMENT SYSTEM
=================================

1. Create Account
2. Deposit Money
3. Withdraw Money
4. View Account
5. Transaction History
6. Exit
```

---

# Sample Output

## 1. Create Account

```
Enter your choice: 1

Enter Account Number: 1001
Enter Name: John Doe
Enter Initial Balance: 5000

Account created successfully!
```

---

## 2. Deposit Money

```
Enter your choice: 2

Enter amount to deposit: 2000

Money deposited successfully!
```

---

## 3. Withdraw Money

```
Enter your choice: 3

Enter amount to withdraw: 1000

Money withdrawn successfully!
```

---

## 4. View Account

```
Enter your choice: 4

========== ACCOUNT DETAILS ==========

Account Number : 1001
Name           : John Doe
Balance        : 6000

=====================================
```

---

## 5. Transaction History

```
Enter your choice: 5

------ Transaction History ------

Deposit  : 2000
Withdraw : 1000
```

---

## 6. Exit

```
Enter your choice: 6

Thank you for using the Banking Management System!
```

---

# Invalid Input Examples

## Invalid Menu Choice

```
Enter your choice: 7

Invalid choice!
```

```
Enter your choice: 8

Invalid choice!
```

---

## Invalid Amount

```
Enter amount: -500

Invalid amount!
```

---

## Insufficient Balance

```
Enter amount to withdraw: 50000

Insufficient balance!
```

---

# C# Concepts Used

This project demonstrates:

- Classes and Objects
- Constructors
- Properties
- Methods
- Encapsulation
- Lists
- Conditional Statements
- Loops
- Switch Statements
- Exception Handling
- User Input Handling
- Console Colors
- Modular Programming
- Object-Oriented Programming

---

# Learning Outcomes

Through this project, you can learn:

- How to create a C# console application
- How to organize a .NET project
- How to use multiple classes
- How to implement OOP principles
- How to build menu-driven programs
- How to use Git and GitHub
- How to manage a software project

---

# Future Improvements

Possible future enhancements:

- Multiple user accounts
- PIN authentication
- Money transfer between accounts
- Account search functionality
- Delete account option
- File-based data storage
- Database integration
- Admin dashboard
- Interest calculation
- Monthly statements
- GUI version using WinForms/WPF
- Web version using ASP.NET Core

---

# Development Environment

- Operating System: Ubuntu Linux
- Programming Language: C#
- Framework: .NET
- Editor: Visual Studio Code
- Version Control: Git
- Hosting Platform: GitHub

---

#  Repository

GitHub:

https://github.com/rimi-sudo434/BankingManagementSystem

---

#  License

This project is licensed under the **MIT License**.

See the [LICENSE](LICENSE) file for more information.

---



