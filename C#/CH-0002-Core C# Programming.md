**Type** is a general term referring to a member of the set **{class, interface, structure, enumeration, delegate}** Unlike many other languages, in C# it is **not possible to create global functions or global points of data.** Rather, all data members and all methods must be contained within a _type definition.

**Note**  C# is a case-sensitive programming language. Therefore, Main is not the same as main.
As a rule of thumb, whenever you receive a compiler error regarding “undefined symbols,” be sure to check your spelling and casing first.

Every executable C# application (console program, Windows desktop program, or Windows service) must contain a class defining a **Main() method**, which is used to signify the entry point of the application.

Formally speaking, the class that defines the Main() method is termed the **application object.**