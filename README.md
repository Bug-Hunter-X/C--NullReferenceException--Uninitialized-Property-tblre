# C# NullReferenceException: Uninitialized Property

This repository demonstrates a common C# error: a `NullReferenceException` that occurs when accessing a class property that hasn't been explicitly initialized. The `bug.cs` file contains the problematic code, while `bugSolution.cs` provides a corrected version. 

**Problem:**
The `MyProperty` property in the `MyClass` class is not initialized before being used in the `MyMethod` function. This leads to a `NullReferenceException` when `MyMethod` is called.

**Solution:**
The solution involves initializing `MyProperty` either in the constructor or before it's accessed in `MyMethod`.