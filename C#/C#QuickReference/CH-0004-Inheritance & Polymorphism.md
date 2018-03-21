**Working of Inheritance**

Code reuse comes in two flavors: inheritance (the "is-a" relationship) and the containment/delegation model (the "has-a" relationship).
	//A simple base class.
	class Organization
	{
		private string Name;
		public readonly string OrganizationType;
	}


The "is-a" relationship (formally termed classical inheritance) allows you to build new class definitions that extend the functionality of an existing class.

The existing class that will serve as the basis for the new class is termed a **base class, superclass, or parent class.** The role of a base class is to define all the common data and members for the classes that extend it. The extending classes are formally termed **derived** or **child** classes.

	//School is-a Organization
	class School : Organization
	{
		// class members to do with the school.
	}

**NOTE:** Although constructors are typically defined as public, a derived class **never inherits** the constructors of a parent class. Constructors are used to construct only theclass that they are defined within.

Always remember that inheritance preserves encapsulation; therefore private members can never be accessed from an object reference. Private members can be accessed only by the class that defines it.

**Talking about Multiple Base Classes**
Keep in mind that C# demands that a given class have **exactly one** direct base class. Multiple class inheritance is **illegal** in C#.

	// Illegal! C# does not allow
	// multiple inheritance for classes!
	class InheritanceVoilation : BaseClassOne, BaseClassTwo
	{
	// Class Member
	}
	
**The sealed Keyword**
When you mark a class as **sealed**, the compiler will not allow you to derive from this type.

	//The School cannot be extended or be inherited by any other class.
    sealed class School : Organization
    {
	// Class Member
    }
	
	//Compile time error cannot inherit from School as it is sealed.
	class SubSchool : School
	{
	// Class Member
	}
	
**NOTE:** C# structures are always **implicitly sealed** Therefore, you can never derive one structure from another structure, a class from a structure, or a structure from a class. Structures can be used to model only stand-alone, atomic, user-defined data types. If you want to leverage the is-a relationship, you must use classes.

**Controlling Base Class Creation with the base Keyword**

Default flow of inheritance: Called Child class -> Default Base Class Constructor -> invoked child class constructor -> field initialization

Work flow in this : 
* Total calls done : base + child constructors + inherited properties.
* Overhead (Waste calls): Base class default constructor is called and initialization of base field members.
* Read-only fields of base class cannot be initialized in child class or child class constructor.

To fix above issue: To help optimize the creation of a derived class, you will do well to implement your subclass constructors to explicitly call an appropriate custom
base class constructor, rather than the default. In this way, you are able to reduce the number of calls to inherited initialization members (which saves processing time).

**NOTE:** You may use the base keyword whenever a subclass wants to access a public or protected member defined by a parent class. Use of this keyword is not limited to constructor logic.

**The protected Keyword :** When a base class defines protected data or protected members, it establishes a set of items that can be accessed directly by any descendant. 

**Sealed Class:** sealed class cannot be extended by other classes. As mentioned, this technique is most often used when you are designing a utility class.

“has-a” relationship (also known as the containment/delegation model or aggregation).

For has-a relationship you have successfully contained another object. However, exposing the functionality of the contained object to the outside world requires delegation. Delegation is simply the act of adding public members to the containing class that use the contained object’s functionality.

**Understanding Nested Type Definitions**

In C# (as well as other .NET languages), it is possible to define a type (enum, class, interface, struct, or delegate) directly within the scope of a class or structure. When you have done so, the nested (or “inner”) type is considered a member of the nesting (or “outer”) class and in the eyes of the runtime can be manipulated like any other member (fields, properties, methods, and events). 

	//Sample Nested Type
	public class OuterClass
	{
	// A public nested type can be used by anybody.
	public class PublicInnerClass {}
	// A private nested type can only be used by members of the containing class.
	private class PrivateInnerClass {}
	}
	
**Traits of nesting a type:**
* Nested types allow you to gain complete control over the access level of the inner type because they may be declared privately (recall that non-nested classes cannot be declared
  using the private keyword).
* Because a nested type is a member of the containing class, it can access private members of the containing class.
* Often, a nested type is useful only as a helper for the outer class and is not intended for use by the outside world.

	 //Take a glance at this code.	
	 //Parent Class
	 public class Organization
	 {
		 protected string Name;
		 public readonly string OrganizationType;
		 public readonly string Sector; // ReadOnly value can be initialized here as well in constructor. No where else.
		 private DateTime ObjectCreationDateTime;
	 
		 public Organization(string name, string organizationType, string sector)
		 {
			 this.Name = name;
			 this.OrganizationType = organizationType;
			 this.Sector = sector;
			 this.ObjectCreationDateTime = DateTime.Now;
		 }
	 
		 public Organization()
		 { }
	 }
	 
	 // This is-a relationship. School is a Organization.
	 public sealed class School : Organization
	 {
		 private int NumberOfTeachers;
		 private int NumberOfStudents;
		 public string EducationMedium;
	 
		 // Calling immediate Base class custom constructor to initialize base class field members. 
		 public School(string name, string organizationType, string sector,
					 int numberOfTeachers, int numberOfStudents, string educationMedium) : base(name, organizationType, sector)
		 {
			 this.NumberOfTeachers = numberOfTeachers;
			 this.NumberOfStudents = numberOfStudents;
			 this.EducationMedium = educationMedium;
		 }
		 public School()
		 { }
	 }
	 
	 //if you uncomment the code will give compile error. Because the inherited class is sealed.
	 
	 //public class SubSchool : School
	 //{
	 //    // Class Members
	 //}
	
	
**Polymorphism (Polymorphic Support) of C#**


