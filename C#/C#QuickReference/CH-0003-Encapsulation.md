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
           public ConstructorChaining(int val1) : this(val1, "")
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

**NOTE**:  It is a compiler error for a static member to reference non-static members in its implementation. On a related note, it is an error to use the this keyword on a static member because this implies an object.

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

###Pillars of OOP
* Encapsulation: How does this language hide an object’s internal implementation details and preserve data integrity?
* Inheritance: How does this language promote code reuse?
* Polymorphism: How does this language let you treat related objects in a similar way?

**Briefing of all three pillars**
**Encapsulation:** 
Language’s ability to hide unnecessary implementation details from the object user. 
Closely related to the notion of encapsulating programming logic is the idea of **data protection.** Ideally, an object’s state data should be specified using the private (or possibly protected) keyword. In this way, the outside world must ask politely in order to change or obtain the underlying value.

**Inheritance**
It boils down to the language’s ability to allow you to build new class definitions based on existing class definitions.
There are two types of relationship:
* is-a
* has-a

**Polymorphism**
 This trait captures a language’s ability to treat related objects in a similar manner. 
 
**C# Access Modifiers**
When working with encapsulation, you must always take into account which aspects of a type are visible to various parts of your application. Specifically,
types (classes, interfaces, structures, enumerations, and delegates) as well as their members (properties, methods, constructors, and fields) are defined using a
specific keyword to control how “visible” the item is to other parts of your application. 
 
**C# Access Modifiers**

|Access Modifier|Use Eligibility|Description|
|---------------|---------------|-----------|
|public         | Types or type members | Public items have no access restrictions. Can be accesses anywhere|
|private        | Type members or nested types| Private items can be accessed only by the class(or structure) that defines the item. |
|protected      | Type members or nested types| Protected items can be used by the class that defines it and any child class. However, protected items cannot be accessed from the outside world using the C# dot operator.|
|internal       |Types or type members| Internal items are accessible only within the current assembly. Therefore, if you define a set of internal types within a .NET class library, other assemblies are not able to use them. |
|protected internal | Type members or nested types| When the protected and internal keywords are combined on an item, the item is accessible within the defining assembly, within the defining class, and by derived classes.|

**NOTE:** By default, type members are implicitly private while types are implicitly internal. 
**CAUTION:** It is permissible to apply the private access modifier on the nested type. However, non-nested types can be defined only with the public or internal modifiers.

**Encapsulation - In Detail**
The concept of encapsulation revolves around the notion that an object’s data should not be directly accessible from an object instance. 
Encapsulation provides a way to preserve the integrity of an object’s state data. Rather than defining public fields (which can easily attract data corruption),
you should get in the habit of defining private data, which is indirectly manipulated using one of two main techniques.
* You can define a pair of public accessor (get) and mutator (set) methods.
* You can define a public .NET property.

Whichever technique you choose, the point is that a well-encapsulated class
should protect its data and hide the details of how it operates from outside world. This is often termed **black-box programming.**


**Encapsulation Using Traditional Accessors and Mutators**

	public class Car
		   {
			   // Field Data aka member variable - Updated to private fields
		   
			   private string carName;
			   public bool engineSwitchStatus;

			   // Accessor (get Method)
			   public string GetCarName()
			   {
		   		   return carName;
			   }

			   //Mutator (Set Method)
				public void SetEngineState(bool engineState)
			   {
			   // Can do all your validations here before making the assignment.
			   engineSwitchStatus = engineState;
			   }
		   }

Issue with the above approach is for every member variable there needs to be two methods for reading and writing which can be a pain point. So here comes .NET Properties

**Encapsulation Using .NET Properties**

	public class Car
		   {
			   // Field Data aka member variable - Updated to private fields
		   
			   private string carName;
			   public bool engineSwitchStatus;

			   // Properties
			   public string Name
			   {
			   	   get {return carName;}
				   set
				   {
				      // Can do all your validations here before making the assignment.
					  // Note lack of parentheses.
					  // Check the value assignment here!!!!
			          engineSwitchStatus = value;
				   }
			   }
		   }

Within a set **scope** of a property, you use a token named **value**, which is used to represent the incoming **value** used to assign the property by the caller.
This token is not a **true C# keyword** but is what is known as a **contextualkeyword**. When the token value is within the set scope of the property, it always
represents the value being assigned by the caller, and it will always be the same underlying data type as the property itself. 

Properties (as opposed to accessor and mutator methods) also make your types easier to manipulate, in that properties are able to respond to the intrinsic operators of C#.

**Read-Only and Write-Only Properties**

When encapsulating data, you might want to configure a read-only property. To do so, simply omit the set block. Likewise, if you want to have a write-only property, omit the get block.

    public class Car
		   {
			   // Field Data aka member variable - Updated to private fields
		   
			   private string carName;
			   public bool engineSwitchStatus;

			   // Properties
			   // Here you can only set Name not get name.
			   public string Name
			   {
			   	   get {return carName;}
			   }
		   }

**Defining Static Properties**

	public class Car
		   {
			  // Field Data aka member variable - Updated to private fields
		   
			  private string carName;
			  static bool engineSwitchStatus;

			  // Instance level Properties
			  // Here you can only set Name not get name.
			  public string Name
			  {
			  	   get {return carName;}
			  }

			  //Static Property
			  public static bool engineSwitchStatus
			  {
			  	  get{return engineSwitchStatus}
				  set
				  {
				    // Checkout value being assigned.
				    engineSwitchStatus = value;
				  }
			  }
		   }

**Automatic Properties**
 In some cases you may not need any implementation logic beyond simply getting and setting the value we use automatic properties.

	public class Car
		   {
		     // Automatic Properties backed by private variable. No need to define backing fields.
			 public string CarName { get; set; }
			 public bool engineSwitchStatus {get; set;}
		   }

**TIP**  Visual Studio provides the prop code snippet. If you type prop inside a class definition.

**NOTE** Note The name of the auto generated private backing field is not visible within your C# code base. The only way to see it is to make use of a tool such as ildasm.exe.

With the current version of C#, it is now possible to define a “read-only automatic property” by omitting the set scope. However, it is not possible to define a write-only property. 

	// Read-only property? This is OK!
	 public string CarName { get; }

	// Write only property? Error! - Will not work.
	 public bool engineSwitchStatus { set;}

The class defining automatic properties will always need to use property syntax to get and set the underlying value.

**Properties - Default Values**
When you use automatic properties to encapsulate numerical or Boolean data, you are able to use the autogenerated type properties straightaway within your code base, as the hidden
backing fields will be assigned a safe default value. However, be aware that if you use automatic property syntax to wrap another class variable, the hidden private reference 
type will also be set to a default value of null.

	public class Car
		   {
		    //Default will be 0
			 public int CarModel { get; set; }

			 //Default will be NULL
			 public Car carDetails {get; set;}
		   }

if you directly invoke Car, you will receive a “null reference exception” at runtime, as the carDetails member variable used in the background has not been assigned to a new object.

To solve above problem, you could update the class constructors to ensure the object comes to life in a safe manner. 

**Initialization of Automatic Properties**
 With the release of the latest version of the C# language, you are provided with a new language feature that can simplify how an automatic property receives its initial value assignment.

	public class Car
		   {
		    //The hidden backing field is set to 1.
			 public int CarModel { get; set; } = 2018;

			 // The hidden backing field is set to a new Car object.
			 public Car carDetails {get; set;} = new Car();
		   }

**CAUTION** Be aware of course that if you are building a property that requires additional code beyond getting and setting the underlying private field(such as data validation
logic, writing to an event log, communicating with a database, etc.), you will be required to define a “normal” .NET property type by hand. C# automatic properties never do more 
than provide simple encapsulation for an underlying piece of (compiler-generated) private data.

**Object Initialization Syntax**
Object initializer consists of a comma-delimited list of specified values, enclosed by the { and } tokens. Each member in the initialization list maps to the name of a public
field or public property of the object being initialized.

	// Make a Car by setting each property manually.
	Car myCar = new Car();
	myCar.CarModel = 2018;
	myCar.Gear = 4;

	// Via constructor.
	Car myCar = new Car(2018, 4);

	//using object Initialization syntax.
	Car myCar = new Car{CarModel = 2018, Gear = 4};

Behind the scenes, the type’s default constructor is invoked, followed by setting the values to the specified properties. To this end, object initialization syntax is just
shorthand notation for the syntax used to create a class variable using a default constructor and to set the state data property by property.

	// Here, the default constructor is called explicitly.
	Car myCar = new Car () { CarModel = 2018, Gear = 4 };

Do be aware that when you are constructing a type using initialization syntax, you are able to invoke any constructor defined by the class.

	// Calling a custom constructor.
	Car myCar = new Car (1990, 2) { CarModel = 2018, Gear = 4 };

**Constant Field Data**
**const** keyword to define constant data, which can never change after the initial assignment. 


	public void Maths
	{
		// You cannot change it anymore.
		public const double PI = 3014;
	}

**constant fields** of a **class** are implicitly static. However, it is permissible to define and access a local constant variable within the scope of a method or property.
Regardless of where you define a constant piece of data, the one point to always remember is that the initial value assigned to the constant must be specified at the time you
define the constant. The reason for this restriction has to do with the fact the value of constant data must be known at compile time.

**Read-Only Fields**
read-only fields are not implicitly static.
Like a constant, a read-only field cannot be changed after the initial assignment. However, unlike a constant, the value assigned to a read-only field can be determined at runtime
and, therefore, can legally be assigned within the scope of a **constructor but nowhere else.**


**Static Read-Only Fields**
 If you want to expose Field from the class level, you must explicitly use the static keyword. 
 You must use a static constructor if you want to initialize it in constructor.

 **Partial Classes**
 We implement partial by C# partial keyword.
 Used for working Parallel in classes.

 **NOTE** Remember that every aspect of a partial class definition must be marked with the partial keyword!

 After you compile the modified project, you should see no difference whatsoever. The whole idea of a partial class is realized only during design time.
After the application has been compiled, there is just a single, unified class within the assembly.





**************************************************************************THANKS**************************************************************************


