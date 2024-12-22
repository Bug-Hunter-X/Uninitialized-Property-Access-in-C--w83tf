# Uninitialized Property Access in C#

This repository demonstrates a common error in C# involving the access of a class property before it has been explicitly assigned a value.  Uninitialized properties default to their type's default value (0 for integers, null for reference types, etc.), which can lead to unexpected behavior and difficult-to-debug issues, especially in complex calculations or conditional logic.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file provides a corrected version.

## Reproducing the Bug
1. Clone this repository.
2. Compile and run `bug.cs`. Observe the unexpected output.

## Solution
The solution involves ensuring the property is assigned a value before it's used. This can be done through constructor initialization, or assigning a value within the method where the property is used, depending on the application logic.