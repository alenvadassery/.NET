**Understanding Interface Types**

An **interface** is nothing more than a named set of abstract members. As abstract methods are pure protocol in that they do not provide a default implementation. The specific members defined by an interface depend on the exact behavior it is modeling. Said another way, an interface expresses a behavior that a given class or structure may choose to support. 

A **class or structure** can support as many interfaces as necessary, thereby supporting (in essence) multiple behaviors.

Example from .NET Frame - IDbConnection (IDbConnection interface defines a set of members that are common to all ADO.NET connection classes. Given this, you are guaranteed that every connection object supports members such as Open(), Close(), CreateCommand(), and so forth. Furthermore, given that interface members are always abstract, each connection object is free to
implement these methods in its own unique manner.)

**NOTE:** By convention, .NET interfaces are prefixed with a capital letter I. When you are creating your own custom interfaces, it is considered a best practice to do the same.

**Interface Types vs. Abstract Base Classes**

**Abstract Class**
* Can have abstract methods.
* Can have non-abstract methods which means they have implementation. So need Constructor, field data so on...

**Interface**
*  Contains only member signature.

The polymorphic interface established by an **abstract parent class** suffers from one major limitation in that only derived types support the members defined by the **abstract parent.** Given that abstract members in an abstract base class apply only to derived types, you have no way to configure types in different hierarchies to support the same polymorphic interface.
Another limitation of abstract base classes is that each derived type must contend with the set of abstract members and provide an implementation.

After an **interface** has been defined, it can be implemented by any class or structure, in any hierarchy, and within any namespace or any assembly (written in any .NET programming language).

	//Syntax of Interface
	public interface IConnection
	{
	  bool Connection();
	}
	
At a syntactic level, an interface is defined using the C# interface keyword. Unlike a class, interfaces never specify a base class (not even **System.Object** )
The members of an interface never specify an access modifier (as all interface members are **implicitly public and abstract** ).

.NET interface types are also able to define any number of **property prototypes and can also contain event and indexer.**

When a class (or structure) chooses to extend its functionality by supporting interfaces, it does so using a comma-delimited list in the type definition. Be aware that the **direct base class must be the first item listed after the colon operator.**

Implementing an interface is an all-or-nothing proposition. The supporting type is not able to selectively choose which members it will implement. 

**Invoking Interface Members at the Object Level**
One way to determine at runtime whether a type supports a specific interface is to use an explicit cast.

		// Can do in try/Catch block.
		(Required-Type)Input-type
		
Other ways to determine at runtime is using as keyword which will return reference to the interface in question or receive null. Other way around is using is Keyword which will return boolean value.

**Interfaces As Parameters**
Given that interfaces are valid .NET types, you may construct methods that take interfaces as parameters.
If you now define a method taking an ISampleInterface interface as a parameter, you can effectively send in any object implementing ISampleInterface. (If you attempt to pass in a type not supporting the necessary interface, you receive a compile-time error.) 

**Interfaces As Return Values**
Interfaces can also be used as method return values.

	 // This method returns the first object in the
	 // array that implements IPoint.
	 static IPoints FindFirstPointsShape(Shape[] shapes)
	 {
		 foreach (Shape s in shapes)
		 {
			 if (s is IPoint)
			 //as Keyword will cast to Ipoint.
				 return s as IPoint;
		 }
		 return null;
	 }
	 
**Arrays of Interface Types**
All the these members which support the same interface, you can iterate through the array and treat each item as an IPoint-compatible object, regardless of the overall diversity of the class hierarchies.

**NOTE:** When you have an array of a given interface, the array can contain any class or structure that implements that interface.

**Explicit Interface Implementation**
Class or structure can implement any number of interfaces. Given this, there is always the possibility you might implement interfaces that contain identical members and, therefore, have a name clash to contend with. To resolve it we use Explicit Interface Implementation.

When you implement several interfaces that have identical members, you can resolve this sort of name clash using explicit interface implementation syntax.
As you can see, when explicitly implementing an interface member, the general pattern breaks down to this:
	
	returnType InterfaceName.MethodName(params){}
	
**CAUTION:** Note that when using this syntax, you do not supply an access modifier; explicitly implemented members are automatically **private.** So you cannot assign any other access modifier.

Because explicitly implemented members are always **implicitly private,** these members are no longer available from the**object level.** As expected, you must use **explicit casting** to access the required functionality. 

While this syntax is quite helpful when you need to resolve name clashes, you can use **explicit interface** implementation simply to hide more **“advanced” members** from the object level. In this way, when the object user applies the dot operator, the user will see only a subset of the type’s overall functionality. However, those who require the more advanced behaviors can extract the desired interface via an **explicit cast.**

**Interface Hierarchies**
Interfaces can be arranged in an interface hierarchy. Like a class hierarchy, when an interface extends an existing interface, it inherits the abstract members defined by the parent (or parents). Of course, unlike class-based inheritance, derived interfaces never inherit true implementation. Rather, a derived interface simply extends its own definition with additional abstract members.

**NOTE:** Interface hierarchies can be useful when you want to extend the functionality of an **existing interface without breaking existing code bases.**

Unlike class types, an interface can extend multiple base interfaces, allowing you to design some powerful and flexible abstractions. 

To summarize the story thus far, remember that interfaces can be extremely useful when:
* You have a single hierarchy where only a subset of the derived types supports a common behavior.
* You need to model a common behavior that is found across multiple hierarchies with no common parent class beyond System.Object.

**IEnumerable and IEnumerator Interfaces**
Any type supporting a method named GetEnumerator() can be evaluated by the **foreach construct.**

	//Pending
  
**Iterator Methods with the yield Keyword**

**Named Iterator**

**ICloneable Interface**
MemberwiseClone()

	//Pending

**IComparable Interface**

	//Pending

**Multiple Sort Orders with IComparer**

	//Pending

**Custom Properties and Custom Sort Types**

	//Pending
		

