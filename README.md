
---

## 👤 User Roles and Permissions

| Username    | Password      | Role       | Permissions              |
|-------------|---------------|------------|---------------------------|
| `manager`   | `manager2025` | Manager    | Insert, Update, Delete    |
| `admin`     | `admin2025`   | Admin      | Insert, Update            |
| `supervisor`| `supervisor2025`| Supervisor | Insert                    |
| `user`      | `user2025`    | User       | Select (default only)     |

Each user is associated with a `Human` object that holds its permissions using a `permission` enum with `[Flags]`.

---

## 🚀 How It Works

1. On startup, the program initializes four `Human` users with different credentials and permission sets.
2. It then prompts the user to enter a **username** and **password**.
3. Based on the login, the appropriate `Human` object is selected.
4. A menu is displayed allowing the user to:
   - Select
   - Delete
   - Update
   - Insert
   - Choose another user
   - Exit the system
5. Each action checks if the logged-in user has the required permission before executing.

---

## 🎮 Example Usage

Welcome to the system
Please enter your username:
admin
Please enter your password:
admin2025

1:select
2:delete
3:update
4:insert
5:choose another role
6: exit


- Choosing `3` (Update) will succeed for `admin`.
- Choosing `2` (Delete) will fail for `admin` since they lack `delete` permission.

---

## 💡 Key Features

- Uses `[Flags]` enum to allow bitwise combinations of permissions.
- Object-oriented design using a `Human` class with methods to check and perform tasks.
- Clear console interface and user role-switching support.
- Demonstrates clean separation of concerns (data vs logic).

---

## 🛠️ Technologies Used

- C#
- .NET Console Application
- Enums with `[Flags]`
- Arrays and basic collections
- Console I/O

---

## 📦 How to Run

1. Open the solution in **Visual Studio** or your preferred C# IDE.
2. Make sure both `Program.cs` and `Human.cs` are in the correct namespace or adjust the namespaces if needed.
3. Build and run the project.
4. Follow on-screen prompts to log in and perform operations.

---

## 🔒 Future Improvements

- Secure password input (hide characters)
- Dynamic user and permission management (add/remove users)
- Save and load user data from a file or database
- Role-based UI customization

---

## 📄 License

This project is provided for educational purposes and is open for modification and distribution.

---

## 🙋‍♂️ Author

Created by [kirrolos nabil]  
Feel free to reach out on [www.linkedin.com/in/kirrolos-nabil-933747279] 
or via [kokonabil1862004@gmail.com].

