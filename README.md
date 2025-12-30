# Inheritance-Csharp

## Introduction

Object-Oriented Programming (OOP) is a programming paradigm that is based on the concept of **objects** and **classes**. It helps programmers design software in a structured, reusable, and efficient way.  

The four main pillars of OOP are:
- **Encapsulation**
- **Abstraction**
- **Inheritance**
- **Polymorphism**

Inheritance is one of the most important concepts of OOP. It allows one class to acquire the properties and behaviors of another class. This feature promotes code reusability, reduces duplication, and makes programs easier to maintain and extend.

---

## Definition of Inheritance

Inheritance is an OOP mechanism in which a new class (**child** or **derived class**) inherits the attributes and methods of an existing class (**parent** or **base class**).

In simple words, inheritance allows a class to reuse the code of another class.

### Example (Real Life)
- A **Teacher** is a type of **Person**
- A **Car** is a type of **Vehicle**
- A **Dog** is a type of **Animal**

---

## Basic Terminology

| Term | Description |
|------|------------|
| **Parent Class (Base Class)** | The class whose properties are inherited |
| **Child Class (Derived Class)** | The class that inherits properties |
| **Superclass** | Another name for parent class |
| **Subclass** | Another name for child class |
| **extends** | Keyword used to inherit a class (language-dependent) |

---

## Syntax of Inheritance

<img width="862" height="622" alt="Screenshot 2025-12-30 165830" src="https://github.com/user-attachments/assets/73a313e9-7928-4e42-b38e-7cc335fd6aaf" />

## Types of Inheritance

1. **Single Inheritance**

<img width="1358" height="800" alt="Screenshot 2025-12-29 232056" src="https://github.com/user-attachments/assets/acd59ce4-9bf5-416f-bef6-6d56e975962e" />

2. **Multilevel Inheritance**

 <img width="947" height="832" alt="Screenshot 2025-12-29 233958" src="https://github.com/user-attachments/assets/6d99b1ed-a5c9-4765-813e-fbbf732694bb" />

3. **Hierarchical Inheritance**

 <img width="1063" height="788" alt="Screenshot 2025-12-30 000348" src="https://github.com/user-attachments/assets/a08de457-df66-44f5-af52-83169bf39b12" />

4. **Multiple Inheritance (Using Interfaces)**

  <img width="1005" height="823" alt="Screenshot 2025-12-30 002728" src="https://github.com/user-attachments/assets/d1b993a0-af88-4402-afc4-d9a7d70b2a47" />


---

## Advantages of Inheritance

- **Code Reusability** – Reduces code duplication  
- **Easy Maintenance** – Changes made in the parent class reflect in child classes  
- **Extensibility** – New features can be added easily  
- **Improved Readability** – Clear class hierarchy  
- **Time Saving** – Faster development  

---

## Disadvantages of Inheritance

- Tight coupling between parent and child classes  
- Increases complexity in large projects  
- Improper use can lead to confusion  
- Changes in parent class may affect child classes  

---

## Real-Life Example of Inheritance

- **Parent Class:** Employee  
- **Child Classes:** Teacher, Manager  

All employees have:
- Name  
- ID  
- Salary  

Teachers and managers inherit these properties and add their own features.

---

## Conclusion

Inheritance is a powerful feature of Object-Oriented Programming that allows programmers to build new classes using existing ones. It improves code reusability, reduces redundancy, and makes programs more organized and efficient. However, inheritance should be used carefully to avoid complexity and tight coupling. When used properly, inheritance makes software development faster, cleaner, and more maintainable.

