
**Brief History:**
Before Microsoft released the C# language and .NET platform, software
developers who created applications for the Windows family of operating system
frequently made use of the COM programming model. COM (which stands for the
Component Object Model) allowed individuals to build libraries of code that
could be shared across diverse programming languages. 

**.Net came to world in 2002.**

**Some Key Benefits of the .NET Platform:**
* Interoperability with existing code: dynamic keyword.
* Support for numerous programming languages.
* A common runtime engine shared by all .NET-aware languages.
* Language integration.
* A comprehensive base class library.
* A simplified deployment model: Unlike COM, .NETlibraries are not registered into the system registry. Furthermore, the .NET platform allows multiple versions of the same *.dll to exist in harmony on a single machine.

**CLR( Common Language Runtime):**
The primary role of the CLR is to locate, load, and manage .NET objects on your behalf. The CLR also takes care of a number of low-level details such as memory management, application hosting, coordinating threads, and performing basic security checks (among other low-level details).

The crux of the CLR is physically represented by a library named **mscoree.dll (Common Object Runtime Execution Engine).** When an assembly is referenced for use, mscoree.dll is loaded automatically, which in turn loads the required assembly into memory. The runtime engine is responsible for a number of tasks. First, it is the agent in charge of resolving the location of an assembly and finding the requested type within the binary by reading the contained metadata. The CLR then lays out the type in memory, compiles the associated CIL into platform-specific instructions, performs any necessary security checks, and then executes the code in question. In addition to loading your custom assemblies and creating your custom types, the CLR will also interact with the types contained within the .NET base class libraries when required. Although the entire base class library has been broken into a number of discrete assemblies, the **key assembly is mscorlib.dll**, which contains a large number of core types that encapsulate a wide variety of common programming tasks, as well as the core data types used by all .NET languages. **When you build .NET solutions, you automatically have access to this particular assembly.**

**CTS(Common Type System):**  CTS specification fully describes all possible data types and all programming constructs supported by the runtime, specifies how these entities
can interact with each other, and details how they are represented in the .NET
metadata format.

**CLS(Common Language Specification):**  Defines a subset of common types and programming constructs that all .NET programming languages can agree on. Thus, if you build .NET types that expose only CLS-compliant features, you can rest assured that all .NETaware languages can consume them.

Def: The CLS is a set of rules that describe in vivid detail the minimal and complete set of features a given .NET-aware compiler must support to produce code that can be hosted by the CLR, while at the same time be accessed in a uniform manner by all languages that target the .NET platform.

Ensuring CLS Compliance : [CLSCompliant] attribute

**NOTE :** CLS is subset of CTS.

**IL**(Intermediate Language)  =  **MSIL**( Microsoft Intermediate Language) = **CIL**(Common Intermediate Language)

**Managed vs. Unmanaged Code:**  Officially speaking, the term used to describe the code targeting the .NET runtime is managed code. The binary unit that contains the managed code is termed an assembly. Conversely, code that cannot be directly hosted by the .NET runtime is termed unmanaged code. 

**Additional .NET-Aware Programming Languages:** Visual Studio provides you with five managed languages, specifically, C#, Visual Basic, C++/CLI, JavaScript, and F#. 
In addition to the managed languages provided by Microsoft, there are .NET compilers for Smalltalk, Ruby, Python, COBOL, and Pascal (to name a few). 

![altText](http://admin.unboxingmind.com/PublicationDocs/CH-001-The%20Philosophy%20of%20.NET/CLR_CTS_CLS_BaseClass_Library_RelationShip.JPG)

**An Overview of .NET Assemblies:**
.NET binaries do not contain platform-specific instructions but rather platform-agnostic Intermediate Language (IL) and type metadata.

![altText](http://admin.unboxingmind.com/PublicationDocs/CH-001-The%20Philosophy%20of%20.NET/ILInstructionDigram.JPG)

An Overview of .NET Assemblies:

When a **\*.dll or \*.exe** has been created using a .NET-aware compiler, the binary blob is termed an **assembly.** 

**Assembly:**
* **Metadata:**  describes in vivid detail the characteristics of every “type” within the binary.
* **Manifest :** Assemblies themselves are also described using metadata, which is officially termed a manifest. The     manifest contains information about the current version of the assembly, culture information (used for localizing string and image resources), and a list of all externally referenced assemblies that are required for proper execution. 
* **IL:** Compiler generated Intermediate Language. (Can be used by anywhere in .NET environment).

* **C# compiler (csc.exe)**, you end up with a single-file \*.exe assembly that contains a manifest, CIL instructions, and metadata.

To open assembly (peek inside) use **ildasm.exe** (Intermediate Language Disassembler utility).

**Compiling CIL to Platform-Specific Instructions:**  
Because assemblies contain CIL instructions rather than platform-specific instructions, CIL code must be compiled on the fly before use. The entity that compiles CIL code into meaningful CPU instructions is a **JIT compiler**, which sometimes goes by the friendly name of **Jitter**. The .NET runtime environment leverages a JIT compiler for each CPU targeting the runtime, each optimized for the underlying platform.

**NOTE:** It is also possible to perform a **“pre-JIT”** of an assembly when installing your application using the **ngen.exe** command-line tool that ships with the .NET Framework SDK. Doing so can improve startup time for graphically intensive applications.

**Common Type System:**  In the world of .NET, type is simply a general term used to refer to a member from the set {class, interface, structure, enumeration, delegate}. 
* CTS Class Types
* CTS Interface Types
* CTS Structure Types
* CTS Enumeration Types (By default, the storage used to hold each item is a 32-bit integer)
* CTS Delegate Types

**CTS Type Members:** Most types take any number of members. Formally speaking, a type member is constrained by the set **{constructor, finalizer, static constructor, nested type, operator, method, property, indexer, field, read-only field, constant, event}.** The CTS defines various adornments that may be associated with a given member. For example, each member has a given visibility trait (e.g., public, private, protected).

**Intrinsic CTS Data Types:**  CTS to be aware of for the time being is that it establishes a well-defined set of fundamental data types. Although a given language typically has a unique keyword used to declare a fundamental data type, all .NET language keywords ultimately resolve to the same CTS type defined in an assembly named **mscorlib.dll.**

Unique keywords of a managed language are simply shorthand notations for a real type in the **System namespace.**

**Top-most root namespace:**
* System
* Microsoft

In C#, the **using** keyword simplifies the process of referencing types defined in a particular namespace.

A vast majority of the .NET Framework assemblies are located under a specific directory termed the **global assembly cache (GAC).** On a Windows machine, this can be located by default under **C:\Windows\Assembly\GAC.**

**Platform-Independent Nature of .NET:**
**CLI (Common Language Infrastructure):**
* ECMA-334: The C# Language Specification
* ECMA-335: The Common Language Infrastructure (CLI) : Standards or guidlines for non- windows platform.

 **Open Source .NET Distributions:**
* The Mono project
* .NET Core 5

![altText](http://admin.unboxingmind.com/PublicationDocs/CH-001-The%20Philosophy%20of%20.NET/DOTNET_WORKFLOW.JPG)

**Things to Checkout in Code Editors :**
* Solution Explorer (Do check-out)
* Object Explorer
* Project Properties

.NET Framework SDK url:  [.NET Framework SDK ](https://msdn.microsoft.com/library)

Xamarin Studio: Mono Platform - Doesn't support WPF(Windows Presentation Foundation)
