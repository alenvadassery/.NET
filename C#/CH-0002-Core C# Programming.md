**Type** is a general term referring to a member of the set **{class, interface, structure, enumeration, delegate}** Unlike many other languages, in C# it is **not possible to create global functions or global points of data.** Rather, all data members and all methods must be contained within a _type definition.

**Note**  C# is a case-sensitive programming language. Therefore, Main is not the same as main.
As a rule of thumb, whenever you receive a compiler error regarding “undefined symbols,” be sure to check your spelling and casing first.

Every executable C# application (console program, Windows desktop program, or Windows service) must contain a class defining a **Main() method**, which is used to signify the entry point of the application.

Formally speaking, the class that defines the Main() method is termed the **application object.**

**Variations on the Main( ) Method**
By default, Visual Studio will generate a Main() method that has a void return value and an array of string types as the single input parameter.

The signature of the **Main** method (application’s entry point) can be alterd.

         // Default Method Signature.
         static void Main(string[] args)
         {
         }
         
         // int return type, array of strings as the parameter.
         static int Main(string[] args)
         {
         // Should return a value before exiting!
         return 0;
         }
         
         // No return type no parameters.
         static void Main()
         {
         }
         
         // int return type, no parameters.
         static int Main()
         {
         // Should return a value before exiting!
         return 0;
         }

Visual Studio automatically defines a program’s **Main()** method as implicitly **private.**

By convention, returning the value 0 indicates the program has terminated successfully, while another value (such as -1) represents an error condition **(NOTE: that the value 0 is automatically returned, even if you construct a Main() method prototyped to return void).**

On the Windows operating system, an application’s return value is stored within a system environment variable named **%ERRORLEVEL%.**
We can obtain the value of **%ERRORLEVEL%** using the static **System.Diagnostics.Process.ExitCode property.**

**Processing & Specifying Command-Line Arguments**
In the real world, an end user has the option of supplying command-line arguments when starting a program.

![altText](http://admin.unboxingmind.com/PublicationDocs/CH-0002-CoreC#Programming/SpecifyingCommand-LineArgumentswithVisual.JPG)

        static void Main(string[] args)
        {
            // Way one to read arguments.
            foreach (string arg in args)
            {
                Console.WriteLine("Args: {0}", arg);
                Console.ReadLine();
            }
            
            // Way two to read arguments.
            
            // Get arguments using System.Environment.
            // Main method with parameters not required with this approch but no             harm doing so as well.
            /*The first index identifies the name of the application itself, 
              while the remaining elements in the array contain the individual              command-line arguments.*/
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Args: {0}", arg);
                Console.ReadLine();
            }
        }

**Check-out these classes:**
* System.Environment Class
* System.Console Class

**Sample program utilizing System.Console Class (Input/Output..Etc)**

\\Waitng for program 

Be aware that it is a compiler error to make use of a local variable before
assigning an initial value.

It is also permissible to declare multiple variables of the same underlying
type on a single line of code.

    // Declare 3 bools on a single line.
     bool b1 = true, b2 = false, b3 = b1;
     
**Intrinsic Data Types and the new Operator**
All intrinsic data types support what is known as a **default constructor**.
* bool variables are set to false.
* Numeric data is set to 0 (or 0.0 in the case of floating-point data types).
* char variables are set to a single empty character.
* BigInteger variables are set to 0.
* DateTime variables are set to 1/1/0001 12:00:00 AM.
* **Object references (including strings) are set to null.**










