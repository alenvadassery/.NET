**Introducing - C# Class Type**
The most fundamental programming construct is the **class type.** Formally, a class is a user-defined type that is composed of **field data** (often called **member variables**) and members that operate on this data (such as constructors, properties, methods, events, and so forth). Collectively, the set of field data represents the “state” of a class instance (otherwise known as an object).
**class** is defined in C# using the class keyword.

    class Car
    {
    }

**Member variables** will be used to represent its state.
 Members that model its behavior. (Talking about **methods** defined in class.)

_Field data_ of a class should seldom (if ever) be defined as public. To preserve the integrity of your state data, it is a far better design to define data as private (or possibly protected) and allow controlled access to the data via **properties**.

    public class Car
       {
           // Field Data aka member variable
		   
           public string carName;
           public int carTopSpeed;
           public bool engineSwitchStatus;
           
		   // Members that model its behavior.
		   
           public bool StartEngine(bool engineSwitch)
           {
               engineSwitchStatus = engineSwitch;
               if (engineSwitchStatus)
               {
                   Console.WriteLine("Car engine has started.. :-)");
               }
               else
               {
                   Console.WriteLine("Car engine is off.");
                   
               }
               Console.Read();
               return engineSwitchStatus;
           }
       }
	   
	   
**Objects** must be allocated into memory using the new keyword.

    static void Main(string[] args)
    {
	*/
	  Here, the first code statement simply declares a ** reference to a yet-to-be determined
      Car object.** It is not until you assign a reference to an object that this
      reference points to a valid object in memory
	*/
	//Car myCar;
	//myCar = new Car();
	
	*/
	create an object using the new keyword, you may define and
	allocate a Car object on a single line of code
	*/
	Car myCar = new Car();
    }
	
**Understanding Constructors**
* Default Constructor
* Custom Constructor

C# supports the use of constructors, which allow the state of an
object to be established at the time of creation. A constructor is a special method
of a class that is called indirectly when creating an object using the new
keyword.

**NOTE**: Constructors never have a return value (not even **void**) and are always named identically to the **class** they are constructing.

**Default Constructor**
* Provided by default by C# to a class if no other custom construct is declared.
* Default constructor never takes arguments.
* Default constructor ensures that all field data of the class is set to an appropriate default value.
* It can be redefined as well.

**Custom Constructor**
* Object User can provide custom values to initialize the state of an object directly at the time of creation.
* When Custom Constructor is declared default constructor is no more available by default and has to be explicitly declared by user.

**TIP:** Visual Studio IDE provides the **ctor** code snippet.

**Role of the this Keyword**
C# supplies a this keyword that provides access to the **current class** instance. **this** keyword is to resolve scope ambiguity which can
arise when an incoming parameter is named identically to a data field of the class.

**Chaining Constructor Calls Using this**

Another use of the this keyword is to design a class using a technique termed
**constructor chaining**. This design pattern is helpful when you have a class that
defines multiple constructors.

**NOTE** Once a constructor passes arguments to the designated master constructor (and that constructor has processed the data), the
constructor invoked originally by the caller will finish executing any remaining code statements.

Supports all versions of .NET, for .NET4.0 and above we can use optional parameters.

    public class ConstructorChaining
       {
           // Members should ideally not be exposed to outside world.
           public int intergerValue1;
           public string stringValue2;
    
           // No return type for Constructor
           public ConstructorChaining()
           {
               Console.WriteLine("I am a default constructor.");
               Console.Read();
           }
           
		   // Constructor with int value as parameter.
           public ConstructorChaining(int val1) : **this(val1, "")**
           {
               Console.WriteLine("I am a constructor taking int value.");
               Console.Read();
           }
		   
		   // Constructor with int value as parameter.
           public ConstructorChaining(string val2) : this(0, val2)
           {
               Console.WriteLine("I am a constructor taking string value.");
               Console.Read();
           }
    
           //Master Constructor
           public ConstructorChaining(int val1, string val2)
           {
               Console.WriteLine("Hey guys i am MASTER constructor.");
               if (val1 > 100)
               {
                   Console.WriteLine("Your are rich .... :-)");
               }
               else
               {
                   Console.WriteLine("Your are poor..... :-(");
               }
           }
       }
	   
Same functionality achieved using **optional** and **named** parameters for .NET 4.0 and above.

	public class ConstructorChaining
       {
           // Members should ideally not be exposed to outside world.
           public int intergerValue1;
           public string stringValue2;
    
           // No return type for Constructor
           public ConstructorChaining()
           {
               Console.WriteLine("I am a default constructor.");
               Console.Read();
           }
           
		   // No return type for Constructor
		    public ConstructorChaining(int val1 = 0, string val2 = "")
           {
               Console.WriteLine("Hey guys i am a custom constructor.");
			   Console.WriteLine("your thought's about life is:" + val2);
               if (val1 > 100)
               {
                   Console.WriteLine("Your are rich .... :-)");
               }
               else
               {
                   Console.WriteLine("Your are poor..... :-(");
               }
           }
       }
	   
What is **static keyword.**

When the member is declared with static keyword it must be invoked directly from the **class level**, rather than from an object reference variable.

_Exapmle_

    // Compiler Error!
	Console display = new Console();
	display.WriteLine("This can't be printed");
	
	// Correct implementation.
	Console.WriteLine("I got printed... Wow");
	
**NOTE**: By definition, a utility class is a class that does not maintain any object-level state and is not created with the new
keyword. Rather, a utility class exposes all functionality as class-level (aka static) members.

Just remember that static members promote a given item to the class level rather than the object level.

**static** keyword can be applied to the following:
* Data of a class
* Methods of a class
* Properties of a class
* A constructor (**There can be only one static constructor  in a class.**)
* The entire class definition
* In conjunction with the C# using keyword

**Static Field Data**
When you define instance-level data, you know that every time you create a new object, the object maintains its own independent copy of the data. In contrast, when you define **static** data of a class, the memory is shared by all objects of that category.

**Static Methods**
CLR will allocate the static data into memory exactly one time. 

**NOTE**:  It is a compiler error for a static member to reference nonstatic members in its implementation. On a related note, it is an error to use the this keyword on a static member because this implies an object.

**Static Constructor**
When member variables has to be resolved or value has to be obtained at runtime we use static constructor.
Simply put, a static constructor is a special constructor that is an ideal place to initialize the values of static data when the value is not known at compile time.

**Points about static constructor**
* A given class may define only a single static constructor. In other words, the static constructor cannot be overloaded.
* A static constructor does not take an access modifier and cannot take any parameters.
* A static constructor executes exactly one time, regardless of how many objects of the type are created.
* The runtime invokes the static constructor when it creates an instance of the class or before accessing the first static member invoked by the caller.
* The static constructor executes before any instance-level constructors.

**static Classes**
It is also possible to apply the static keyword directly on the class level. When a class has been defined as static, it is not creatable using the new
keyword, and it can contain only members or data fields marked with the static keyword. (It can contain only static members).

**NOTE** Recall that a class (or structure) that exposes only static functionality is often termed a utility class. When designing a utility class, it is good practice to apply the static keyword to the class definition.

**Importing Static Members via the C# using Keyword**
The latest version of the C# compiler supports a new way to use the using keyword. It is now possible to define a C# using directive, which will import
all static members into the declaring code file.
With these “static imports,” the remainder of your code file is able to directly use the static members.

	// Sample Code
	// Import the static members of Console and DateTime.
    using static System.Console;
	
	 static class xyz
        {
            public static void PrintName()
            {
			    // Directly using static member of console class.
                WriteLine("Name is Hi,Program User" );
            }
        }
		
**CAUTION**:  Overuse of static import statements could result in potential confusion for complier as well as for new developer.









