# 🎓 Student Management System - ASP.NET MVC

A web-based application built using **ASP.NET MVC** to manage Students, Teachers, Attendance records, and Payroll, featuring a responsive Admin Panel and Dashboard built with **AdminLTE**.

---

## 📌 Features

- ✅ Student CRUD (Create, Read, Update, Delete)
- ✅ Teacher CRUD
- ✅ Attendance Module with Student Dropdown (Foreign Key)
- ✅ Payroll Module with Teacher Dropdown (Foreign Key)
- ✅ Admin Dashboard with stats (Student, Teacher, Attendance, Payroll)
- ✅ Admin Panel Navigation using Bootstrap & AdminLTE
- ✅ Entity Framework Integration (Code First)
- ✅ Data Validation using Data Annotations
- ✅ Responsive UI with Bootstrap 5

---

## 📁 Modules Implemented

### 1. 🧑‍🎓 Student
- Fields: FullName, ContactNumber, Email, Class
- Features: CRUD operations

### 2. 👨‍🏫 Teacher
- Fields: FullName, Address, ContactNumber, Email, Subject, JoiningDate
- Features: CRUD operations

### 3. 🕒 Attendance
- Fields: Date, Status, StudentId (FK)
- Relation: One-to-Many with `Student`
- Features: Dropdown list for selecting student

### 4. 💰 Payroll
- Fields: PayDate, BasicSalary, Bonus, Deductions, NetSalary, TeacherId (FK)
- Relation: One-to-Many with `Teacher`
- Features: Dropdown list for selecting teacher

---

## 🧠 Technologies Used

| Technology        | Description                              |
|-------------------|------------------------------------------|
| ASP.NET MVC       | MVC Web Application Framework            |
| Entity Framework  | ORM for Code First DB access             |
| SQL Server        | Backend database                         |
| Bootstrap 5       | Frontend UI framework                    |
| AdminLTE          | Dashboard and admin layout styling       |
| Razor View Engine | Templating for dynamic HTML rendering    |

---

## 🧭 Navigation Structure

- `/Home/Dashboard` → Admin Dashboard
- `/Student/Index` → Student List
- `/Teacher/Index` → Teacher List
- `/Attendance/Index` → Attendance Records
- `/Payroll/Index` → Payroll Records

All pages are accessible via the sidebar in the layout.

---

## 🛠️ Setup Instructions

1. Clone the repo
2. Open the solution in **Visual Studio**
3. Configure DB connection in `Web.config` under `<connectionStrings>`
4. Run EF Migrations or use `Update-Database`
5. Press **F5** to launch the app

---

## 📷 Screenshots

> You can include screenshots here for:
- Dashboard
- Student/Teacher form
- Attendance form with dropdown
- Payroll form with dropdown

---

## 👤 Author

**Adarsh Vishwakarma**  
.NET Developer | MERN Stack Developer  
📧 Email: adarshvishwakarma2004@example.com*

---

## 📜 License

This project is open-source and free to use for educational or non-commercial purposes.
