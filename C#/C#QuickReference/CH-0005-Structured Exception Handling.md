**Understanding Structured Exception Handling**
Three types of issues: 
* **Bugs** - These are, simply put, errors made by the programmer.
* **User Errors** -  User errors, on the other hand, are typically caused by the individual running your application, rather than by those who created it.
* **Exceptions** -  Exceptions are typically regarded as runtime anomalies that are difficult, if not impossible, to account for while programming your application.

Within the .NET nomenclature, an exception accounts for bugs, bogus user input, and runtime errors, even though programmers may view each of these as a distinct issue.

.NET platform provides a standard technique to send and trap runtime errors: structured exception handling. The beauty of this approach is that developers now have a unified approach to 
error handling, which is common to all languages targeting the .NET platform. Therefore, the way in which a C# programmer handles errors is syntactically similar to that of a VB programmer, or a C++ programmer using C++/CLI.
As an added bonus, the syntax used to throw and catch exceptions across assemblies and machine boundaries is identical. For example, if you use C# to build a Windows Communication Foundation (WCF) service, you can throw a SOAP fault to a remote caller, using the same keywords that allow you to throw an exception between methods in the same application.

**Building Blocks of .NET Exception Handling**
Programming with structured exception handling involves the use of four interrelated entities.
* A class type that represents the details of the exception.
* A member that throws an instance of the exception class to the caller under the correct circumstances.
* A block of code on the caller’s side that invokes the exception-prone member.
* A block of code on the caller’s side that will process (or catch) the exception, should it occur.

The C# programming language offers five keywords (try, catch, throw, finally, and when) that allow you to throw and handle exceptions. The object that represents the problem at hand is a class extending System.Exception.

**Base Class:**  System.Exception - All exceptions ultimately derive from the System.Exception base class, which in turn derives from **System.Object.**

**NOTE:** The Exception class implements two .NET interfaces. **_Exception** interface allows a .NET exception to be processed by an unmanaged code base (such as a COM application), while the **ISerializable** interface allows an exception object to be persisted across boundaries (such as a machine boundary).

**Core Members of the System.Exception Type:**

|Core Members of the System.Exception Type|Description|
|-----------------------------------------|-----------|
|Data|This read-only property retrieves a collection of key/value pairs (represented by an object implementing IDictionary) that provide additional, programmer defined information about the exception. By default, this collection is empty.|
|HelpLink|This property gets or sets a URL to a help file or web site describing the error in full detail.
|InnerException|This read-only property can be used to obtain information about the previous exception(s) that caused the current exception to occur. The previous exception(s) are recorded by passing them into the constructor of the most current exception.|
|Message|This read-only property returns the textual description of a given error. The error message itself is set as a constructor parameter.|
|Source|This property gets or sets the name of the assembly, or the object, that threw the current exception.|
|StackTrace|This read-only property contains a string that identifies the sequence of calls that triggered the exception. As you might guess, this property is useful during debugging or if you want to dump the error to an external error log.|
|TargetSite|This read-only property returns a MethodBase object, which describes numerous details about the method that threw the exception (invoking ToString() will identify the method by name).|

When you want to send the exception object back to the caller, use the C# throw keyword.

When you are invoking a method that may throw an exception, you make use of a try/catch block. After you have caught the exception object, you are able to invoke the members of the
exception object to extract the details of the problem.

A try block is a section of statements that may throw an exception during execution. If an exception is detected, the flow of program execution is sent to the appropriate catch block. 

**Configuring the State of an Exception**
**System.Exception.TargetSite**  property allows you to determine various details about the method that threw a given exception.

**System.Exception.StackTrace property** allows you to identify the series of calls that resulted in the exception. Be aware that you never set the value of StackTrace, as it is established automatically at the time the exception is created. 
The string returned from StackTrace documents the sequence of calls that resulted in the throwing of this exception. 

**HelpLink Property** can be set to point the user to a specific URL or standard Windows help file that contains more detailed information. By default, the value managed by the HelpLink property is an empty string.

**Data property** of System.Exception allows you to fill an exception object with relevant auxiliary information (such as a timestamp). 
The Data property is useful in that it allows you to pack in custom information regarding the error at hand, without requiring the building of a new class type to extend the Exception base class.

**System-Level Exceptions (System.SystemException)**
Exceptions that are thrown by the .NET platform are (appropriately) called **system exceptions.** These exceptions are generally regarded as nonrecoverable, fatal errors. System exceptions derive directly from a base class named **System.SystemException,** which in turn derives from **System.Exception** (which derives from System.Object).

	public class SystemException : Exception
    {
      // Various constructors.
    }
	
When an exception type derives from **System.SystemException,** you are able to determine that the .NET runtime is the entity that has thrown the exception, rather than the code base of the executing application. You can verify this quite simply using the **is** keyword.

**Application-Level Exceptions (System.ApplicationException)**
Like SystemException, ApplicationException does not define any additional members beyond a set of constructors. Functionally, the only purpose of System.ApplicationException is to identify the source of the error. When you handle an exception deriving from **System.ApplicationException,** you can assume the exception was raised by the code base of the executing application, rather than by the .NET base class libraries or .NET runtime engine.

**Building Custom Exceptions**

**NOTE:** As a rule, all custom exception classes should be defined as **public classes** (recall, the default access modifier of a non-nested type is internal). The reason is that exceptions are often passed outside of **assembly boundaries** and should therefore be accessible to the calling code base.

If you want to build a truly prim-and-proper custom exception class, you would want to make sure your type adheres to .NET best practices. Specifically, this requires that your custom exception does the following:
* Derives from Exception/ApplicationException.
* Is marked with the [System.Serializable] attribute.
* Defines a default constructor.
* Defines a constructor that sets the inherited Message property.
* Defines a constructor to handle “inner exceptions”.
* Defines a constructor to handle the serialization of your type.

**Processing Multiple Exceptions**
When you are authoring multiple catch blocks, you must be aware that when an exception is thrown, it will be processed by the first appropriate catch.

The rule of thumb to keep in mind is to make sure your catch blocks are structured such that the first catch is the most specific exception (i.e., the most derived type in an exception-type inheritance chain), leaving the final catch for the most general (i.e., the base class of a given exception inheritance chain, in this case System.Exception).

**General catch Statements**
C# also supports a “general” catch scope that does not explicitly receive the **exception object** thrown by a given member.

**Rethrowing Exceptions**
When you catch an exception, it is permissible for the logic in a try block to rethrow the exception up the call stack to the previous caller. To do so, simply use the **throw** keyword within a catch block. This passes the exception up the chain of calling logic, which can be helpful if your catch block is only able to partially handle the error at hand.

**Inner Exceptions**
As you might suspect, it is entirely possible to trigger an exception at the time you are handling another exception.
When you encounter an exception while processing another exception, best practice states that you should record the new exception object as an “inner exception” within a new object of the same type as the initial exception.

**finally Block**
A try/catch scope may also define an optional finally block. The purpose of a finally block is to ensure that a set of code statements will always execute, exception (of any type) or not. 

**Exception Filters**
The current release of C# introduces a new (and completely optional) clause that can be placed on a catch scope, via the **when** keyword. When you add this clause, you have the ability to ensure that the statements within a catch block are executed only if some condition in your code holds true. 









