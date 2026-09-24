# C# OOP Project

This repository contains the solutions for **Assignment 04** covering advanced Object-Oriented Programming (OOP) concepts in C# and .NET.

---

## 📌 Projects Overview

### Project 1: 3D Point Class (`Point3D`)
- **Constructor Chaining:** Implemented constructors that chain to avoid redundant code.
- **String Formatting:** Overrode `ToString()` to display coordinates in the format `Point Coordinates: (X, Y, Z)`.
- **Input Validation:** Safely reads point coordinates from user inputs using `int.TryParse`.
- **Equality Comparison:** Overrode `Equals`, `GetHashCode`, and overloaded `==` / `!=` operators so equality is based on coordinate values rather than memory references.
- **Interfaces Implementation:**
  - `IComparable`: Enables sorting arrays of points by `X`, then by `Y`.
  - `ICloneable`: Provides deep/shallow copying of the point instance.

---

### Project 2: Static Math Utility (`Maths`)
- **Static Class & Methods:** Created a static utility class containing `Add`, `Subtract`, `Multiply`, and `Divide`.
- **Direct Invocation:** Allows calling mathematical operations without needing to instantiate the class (`Maths.Add(...)`).
- **Error Handling:** Protects against division by zero exceptions.

---

### Project 3: Duration Structuring & Operator Overloading (`Duration`)
- **Attributes:** Encapsulates `Hours`, `Minutes`, and `Seconds`.
- **Normalization:** Automatically converts raw seconds into properly balanced hours, minutes, and seconds.
- **Object Overrides:** Full implementation of `ToString()`, `Equals()`, and `GetHashCode()`.
- **Operator Overloading:**
  - Addition (`+`): Supporting `D1 + D2`, `D1 + seconds`, and `seconds + D1`.
  - Subtraction (`-`): Subtraction between durations.
  - Increment/Decrement (`++`, `--`): Increases or decreases duration by 1 minute (60 seconds).
  - Relational Operators: Overloaded `>`, `<`, `>=`, and `<=`.
- **User-Defined Conversions:**
  - `implicit operator bool`: Evaluates `if (D1)` to true if the total duration is non-zero.
  - `explicit operator DateTime`: Explicitly casts a duration into a `DateTime` instance.

---
## 🛠 Tech Stack

* **Language:** C#
* **Platform:** .NET Core / .NET 10
* **Paradigm:** Object-Oriented Programming (OOP)
