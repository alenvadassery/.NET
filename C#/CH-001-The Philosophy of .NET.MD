---


---

<p><strong>Brief History:</strong><br>
Before Microsoft released the C# language and .NET platform, software<br>
developers who created applications for the Windows family of operating system<br>
frequently made use of the COM programming model. COM (which stands for the<br>
Component Object Model) allowed individuals to build libraries of code that<br>
could be shared across diverse programming languages.</p>
<p><strong>.Net came to world in 2002.</strong></p>
<p><strong>Some Key Benefits of the .NET Platform:</strong></p>
<ul>
<li>Interoperability with existing code: dynamic keyword.</li>
<li>Support for numerous programming languages.</li>
<li>A common runtime engine shared by all .NET-aware languages.</li>
<li>Language integration.</li>
<li>A comprehensive base class library.</li>
<li>A simplified deployment model: Unlike COM, .NETlibraries are not registered into the system registry. Furthermore, the .NET platform allows multiple versions of the same *.dll to exist in harmony on a single machine.</li>
</ul>
<p><strong>CLR( Common Language Runtime):</strong><br>
The primary role of the CLR is to locate, load, and manage .NET objects on your behalf. The CLR also takes care of a number of low-level details such as memory management, application hosting, coordinating threads, and performing basic security checks (among other low-level details).</p>
<p>The crux of the CLR is physically represented by a library named <strong>mscoree.dll (Common Object Runtime Execution Engine).</strong> When an assembly is referenced for use, mscoree.dll is loaded automatically, which in turn loads the required assembly into memory. The runtime engine is responsible for a number of tasks. First, it is the agent in charge of resolving the location of an assembly and finding the requested type within the binary by reading the contained metadata. The CLR then lays out the type in memory, compiles the associated CIL into platform-specific instructions, performs any necessary security checks, and then executes the code in question. In addition to loading your custom assemblies and creating your custom types, the CLR will also interact with the types contained within the .NET base class libraries when required. Although the entire base class library has been broken into a number of discrete assemblies, the <strong>key assembly is mscorlib.dll</strong>, which contains a large number of core types that encapsulate a wide variety of common programming tasks, as well as the core data types used by all .NET languages. <strong>When you build .NET solutions, you automatically have access to this particular assembly.</strong></p>
<p><strong>CTS(Common Type System):</strong>  CTS specification fully describes all possible data types and all programming constructs supported by the runtime, specifies how these entities<br>
can interact with each other, and details how they are represented in the .NET<br>
metadata format.</p>
<p><strong>CLS(Common Language Specification):</strong>  Defines a subset of common types and programming constructs that all .NET programming languages can agree on. Thus, if you build .NET types that expose only CLS-compliant features, you can rest assured that all .NETaware languages can consume them.</p>
<p>Def: The CLS is a set of rules that describe in vivid detail the minimal and complete set of features a given .NET-aware compiler must support to produce code that can be hosted by the CLR, while at the same time be accessed in a uniform manner by all languages that target the .NET platform.</p>
<p>Ensuring CLS Compliance : [CLSCompliant] attribute</p>
<p><strong>NOTE :</strong> CLS is subset of CTS.</p>
<p><strong>IL</strong>(Intermediate Language)  =  <strong>MSIL</strong>( Microsoft Intermediate Language) = <strong>CIL</strong>(Common Intermediate Language)</p>
<p><strong>Managed vs. Unmanaged Code:</strong>  Officially speaking, the term used to describe the code targeting the .NET runtime is managed code. The binary unit that contains the managed code is termed an assembly. Conversely, code that cannot be directly hosted by the .NET runtime is termed unmanaged code.</p>
<p><strong>Additional .NET-Aware Programming Languages:</strong> Visual Studio provides you with five managed languages, specifically, C#, Visual Basic, C++/CLI, JavaScript, and F#.<br>
In addition to the managed languages provided by Microsoft, there are .NET compilers for Smalltalk, Ruby, Python, COBOL, and Pascal (to name a few).</p>
<p><img src="http://admin.unboxingmind.com/PublicationDocs/CH-001-The%20Philosophy%20of%20.NET/CLR_CTS_CLS_BaseClass_Library_RelationShip.JPG" alt="altText"></p>
<p><strong>An Overview of .NET Assemblies:</strong><br>
.NET binaries do not contain platform-specific instructions but rather platform-agnostic Intermediate Language (IL) and type metadata.</p>
<p><img src="http://admin.unboxingmind.com/PublicationDocs/CH-001-The%20Philosophy%20of%20.NET/ILInstructionDigram.JPG" alt="altText"></p>
<p>An Overview of .NET Assemblies:</p>
<p>When a <strong>*.dll or *.exe</strong> has been created using a .NET-aware compiler, the binary blob is termed an <strong>assembly.</strong></p>
<p><strong>Assembly:</strong></p>
<ul>
<li>
<p><strong>Metadata:</strong>  describes in vivid detail the characteristics of every “type” within the binary.</p>
</li>
<li>
<p><strong>Manifest :</strong> Assemblies themselves are also described using metadata, which is officially termed a manifest. The     manifest contains information about the current version of the assembly, culture information (used for localizing string and image resources), and a list of all externally referenced assemblies that are required for proper execution.</p>
</li>
<li>
<p><strong>IL:</strong> Compiler generated Intermediate Language. (Can be used by anywhere in .NET environment).</p>
</li>
<li>
<p><strong>C# compiler (csc.exe)</strong>, you end up with a single-file *.exe assembly that contains a manifest, CIL instructions, and metadata.</p>
</li>
</ul>
<p>To open assembly (peek inside) use <strong>ildasm.exe</strong> (Intermediate Language Disassembler utility).</p>
<p><strong>Compiling CIL to Platform-Specific Instructions:</strong><br>
Because assemblies contain CIL instructions rather than platform-specific instructions, CIL code must be compiled on the fly before use. The entity that compiles CIL code into meaningful CPU instructions is a <strong>JIT compiler</strong>, which sometimes goes by the friendly name of <strong>Jitter</strong>. The .NET runtime environment leverages a JIT compiler for each CPU targeting the runtime, each optimized for the underlying platform.</p>
<p><strong>NOTE:</strong> It is also possible to perform a <strong>“pre-JIT”</strong> of an assembly when installing your application using the <strong>ngen.exe</strong> command-line tool that ships with the .NET Framework SDK. Doing so can improve startup time for graphically intensive applications.</p>
<p><strong>Common Type System:</strong>  In the world of .NET, type is simply a general term used to refer to a member from the set {class, interface, structure, enumeration, delegate}.</p>
<ul>
<li>CTS Class Types</li>
<li>CTS Interface Types</li>
<li>CTS Structure Types</li>
<li>CTS Enumeration Types (By default, the storage used to hold each item is a 32-bit integer)</li>
<li>CTS Delegate Types</li>
</ul>
<p><strong>CTS Type Members:</strong> Most types take any number of members. Formally speaking, a type member is constrained by the set <strong>{constructor, finalizer, static constructor, nested type, operator, method, property, indexer, field, read-only field, constant, event}.</strong> The CTS defines various adornments that may be associated with a given member. For example, each member has a given visibility trait (e.g., public, private, protected).</p>
<p><strong>Intrinsic CTS Data Types:</strong>  CTS to be aware of for the time being is that it establishes a well-defined set of fundamental data types. Although a given language typically has a unique keyword used to declare a fundamental data type, all .NET language keywords ultimately resolve to the same CTS type defined in an assembly named <strong>mscorlib.dll.</strong></p>
<p>Unique keywords of a managed language are simply shorthand notations for a real type in the <strong>System namespace.</strong></p>
<p><strong>Top-most root namespace:</strong></p>
<ul>
<li>System</li>
<li>Microsoft</li>
</ul>
<p>In C#, the <strong>using</strong> keyword simplifies the process of referencing types defined in a particular namespace.</p>
<p>A vast majority of the .NET Framework assemblies are located under a specific directory termed the <strong>global assembly cache (GAC).</strong> On a Windows machine, this can be located by default under <strong>C:\Windows\Assembly\GAC.</strong></p>
<p><strong>Platform-Independent Nature of .NET:</strong><br>
<strong>CLI (Common Language Infrastructure):</strong></p>
<ul>
<li>ECMA-334: The C# Language Specification</li>
<li>ECMA-335: The Common Language Infrastructure (CLI) : Standards or guidlines for non- windows platform.</li>
</ul>
<p><strong>Open Source .NET Distributions:</strong></p>
<ul>
<li>The Mono project</li>
<li>.NET Core 5</li>
</ul>
<p><img src="http://admin.unboxingmind.com/PublicationDocs/CH-001-The%20Philosophy%20of%20.NET/DOTNET_WORKFLOW.JPG" alt="altText"></p>
<p><strong>Things to Checkout in Code Editors :</strong></p>
<ul>
<li>Solution Explorer (Do check-out)</li>
<li>Object Explorer</li>
<li>Project Properties</li>
</ul>
<p>.NET Framework SDK url:  <a href="https://msdn.microsoft.com/library">.NET Framework SDK </a></p>
<p>Xamarin Studio: Mono Platform - Doesn’t support WPF(Windows Presentation Foundation)</p>

