# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# that can occur when accessing a property before it has been assigned a value.  The `ExampleClass` in `bug.cs` shows this error. The solution shows how to avoid the problem. 

The bug can manifest in different ways, from unexpected default values to exceptions, depending on the context and the type of property.