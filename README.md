# 🛍️ InitShopBlazor

**InitShopBlazor** is a simple e-commerce application built with **Blazor Server** using **Entity Framework Core** and **Bootstrap 5**. This project was created for educational purposes to practice building CRUD interfaces, handling data relationships, and working with Razor Pages.

---

## 🚀 Technologies Used

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- [Blazor Server](https://learn.microsoft.com/aspnet/core/blazor/)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [Bootstrap 5](https://getbootstrap.com/)
- [SQLite](https://www.sqlite.org/index.html)
- Visual Studio 2022
- [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity) for individual authentication

---

## ✅ Features

- **Product CRUD**: Add, edit, delete, and list products.
- **Category CRUD**: Manage product categories.
- **Validation**: Input validations using Data Annotations in Blazor.
- **Category Selection**: Dropdown for selecting a category when creating or editing a product.
- **Individual Authentication**: Login and registration system using ASP.NET Core Identity, allowing authenticated access to product and category management pages.
- **Page Navigation**: Razor Pages for navigation, including route protection for pages requiring authentication.
- **Responsive Layout**: Uses Bootstrap 5 to ensure accessibility on both mobile devices and desktops.

---

## 🧱 Project Structure
```
InitShopBlazor/
├── Components/ # Reusable UI components
├── Data/ # DbContext and configuration
├── Models/ # Entity models (Product, Category)
├── Pages/ # Razor Pages (Index, Create, Edit, etc.)
├── wwwroot/ # Static files (CSS, JS)
├── Program.cs # App startup configuration
└── InitShopBlazor.csproj # Project file
```

---

## ⚙️ Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/kevin-andrade/InitShopBlazor.git
   cd InitShopBlazor

2. **Open the project in Visual Studio 2022**
   ```bash
   dotnet restore

3. **Apply migrations and create the database**:
   ```bash
   dotnet ef database update

4. **Run the application:**
  ```bash
    dotnet run
  ```

🙋‍♂️ Author
Kevin Andrade
