# LibraryManagementSystem

 📌 Project Overview

-This project is an **Advanced Library Management System** built as a **C# Console Application**, following **Object-Oriented Programming (OOP)** principles and academic requirements.

-The system allows users to manage a library with **Books, Magazines, and DVDs**, supporting borrowing, returning, pagination, late fee logic, and persistent data storage using **JSON files**.

-This project is designed to demonstrate:

* Clean architecture
* Professional coding practices
* Full CRUD functionality
* Strong OOP concepts

---

## 🎯 Core Features

* 📖 Manage **Books, Magazines, DVDs**
* ➕ 100 preloaded books with realistic data
* 🔄 Borrow & return items
* 📄 Pagination (10 items per page)
* 💾 JSON file persistence (no data loss)
* ⚠ Input validation & exception handling
* 🧱 Professional folder & class structure

---
## 🧠 OOP Concepts Implemented

### ✅ Encapsulation

* Private fields with public properties
* Controlled access to object state

### ✅ Inheritance

* `Item` → `Book`, `Magazine`, `DVD`
* `Person` → `Member` → `StudentMember`, `AdultMember`

### ✅ Polymorphism

* Virtual methods (`Borrow`, `Return`)
* Runtime behavior via base class `Item`

### ✅ Abstraction

* Abstract base classes (`Item`, `Person`, `Member`)
* Interfaces where applicable

---

## 🗂 Project Structure

```
LibraryApp/
│
├── Data/
│   └── DataStore.cs
│
├── Interfaces/
│   └── ILoanable.cs
│
├── Models/
│   ├── Item.cs
│   ├── Book.cs
│   ├── Magazine.cs
│   ├── DVD.cs
│   ├── Loan.cs
│   └── Fine.cs
│
├── People/
│   ├── Person.cs
│   ├── Member.cs
│   ├── StudentMember.cs
│   └── AdultMember.cs
│
├── Services/
│   └── LibraryService.cs
│
├── Utils/
│   └── Pagination.cs
│
├── Program.cs
└── README.md
```

---

## 💾 Data Persistence

* All library items are stored in:

  ```
  Data/library.json
  ```
* Data is:

  * Loaded automatically on startup
  * Saved after every borrow/return action
* The `Data` folder is created automatically if missing

---

## 🧾 CRUD Operations

| Operation | Description                |
| --------- | -------------------------- |
| Create    | Add books, magazines, DVDs |
| Read      | View items with pagination |
| Update    | Borrow / Return items      |
| Delete    | (Expandable for admin use) |
---

## 📋 Console Menu Example

```
1. View Items
2. Borrow Item
3. Return Item
4. Next Page
5. Previous Page
6. Exit
```

---

## 🧪 Error Handling & Validation

* Uses `try-catch` blocks throughout
* Uses `int.TryParse` to prevent crashes
* Displays user-friendly error messages


## 🚀 Future Improvements
* Reservation system
* Late fee payment
* Search by author/year
* Librarian admin panel

## 👤 Author
**Student Name:** Altina Islami
**Course:** Object-Oriented Programming
**Project Type:** Console Application (C#)


Interfaces used where appropriate
