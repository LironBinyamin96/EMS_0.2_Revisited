# EMS 0.2 Revisited – Face Recognition-Based Attendance System

**EMS 0.2 Revisited** is a smart employee attendance system based on facial recognition, designed for organizations seeking accurate, automatic, and modern tracking of working hours. The system follows a client-server architecture, where the "client" is a continuously running camera connected directly to the server. No user interface is required for employees.

---

## 🧩 System Components

- **Facial Recognition Camera (Client)**  
  A camera connected to the server that continuously scans and identifies employees. When an employee stands in front of the camera, the system automatically logs an entry or exit based on their previous status.

- **Server**  
  Handles face processing, identifies the employee, determines attendance status (entry/exit), stores the data in a database, and sends alerts or notifications as needed.

- **Management Interface**  
  A separate interface for administrators, enabling the addition/editing of employee data, correcting attendance logs, sending emails, and generating monthly attendance reports.

- **Shared Library**  
  Contains the data models and shared classes used across the server and management interface.

---

## ✨ Key Features

- ✅ Touchless face recognition for attendance logging
- 👥 Add and edit employee records
- 🛠️ Manually correct attendance logs when needed
- 📧 Automatic email notifications to employees and managers
- 📊 Generate monthly attendance reports by employee, department, or date range
- 🔄 Runs continuously with support for multiple daily check-ins

---

## ⚙️ System Requirements

- **Operating System**: Windows
- **IDE**: Visual Studio 2022 or later
- **Platform**: .NET Framework 4.7.2
- **Database**: SQL Server
- **Hardware**: Compatible facial recognition camera with real-time API support

---

## 🚀 Installation & Setup

1. **Clone the repository**:

   ```bash
   git clone https://github.com/LironBinyamin96/EMS_0.2_Revisited.git
   ```

2. **Open the solution in Visual Studio**  
   Open the `EMS_0.2.sln` file.

3. **Set up the database**  
   - Create a new SQL Server database.
   - Run any required setup scripts to initialize tables or sample data (if provided).

4. **Run the server**  
   - Launch the server project.
   - Ensure the connected camera is accessible and properly configured.

5. **Access the management interface**  
   - Log in as an administrator to add employees, view reports, and manage attendance records.

---

## 👥 Contributors

- [LironBinyamin96](https://github.com/LironBinyamin96)

---
