### [Styleguide for C# ](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

## Basic of C#

| File | Topic                                                                                                                                                                                                    |
| ---: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|   1. | [Expressions & Control flow                 ](https://github.com/jafarimahdi/C_Sharp/tree/main/Expressions%20and%20Control%20Flow) |
|   2. | [Arrays, Multidimensional, Jagged ](https://github.com/jafarimahdi/C_Sharp/tree/main/Arrays)                                                                                                             |
|   3. | [Functions](https://github.com/jafarimahdi/C_Sharp/tree/main/Functions)                                                                                                                                  |
|   4. | [.Net Collection ](https://github.com/jafarimahdi/C_Sharp/tree/main/NET%20Collections)                                                                                                                   |
|   5. | [Classes & Objects ](https://github.com/jafarimahdi/C_Sharp/tree/main/Classes%20%26%20Objects)                                                                                                           |

| File | Topic                                                                               |
| ---: | :---------------------------------------------------------------------------------- |
|   1. | [Console Project](https://github.com/jafarimahdi/C_Sharp/tree/main/Project)         |
|   2. | [Weekend Review ](https://github.com/jafarimahdi/C_Sharp/tree/main/WeekendPractice) |

## C# Language Syntax

-   Data Types in C#
-   Data Types Categorized into Value Type and Reference Type
-   Implicit Casting and Explicit casting and How to handle Overflow checks
-   Difference between string and string Builder
-   What is Boxing
-   What is Unboxing
-   What is Type Inference
-   What are constants and Enums
-   Operators in C#
-   if, while, do while, switch condition
-   difference between for and foreach and where to use
-   single dimension Array, multi dimension Array
-   What is method overloading
-   What are optional parameters and What will happen When we not provide any value for the
    parameter
-   What are Named Arguments
-   What is params Parameter
-   How to Pass argument by value, ref and out

## OOPs – Concepts

-   OOPS and its priciples
-   class and object
-   What is a component
-   Encapsulation and Data Abstraction
-   inheritance and advantages of inheritance
-   ploymorphism

## OOPs - Encapsulation

-   How to create a WindowsForms application
-   class and How to declare field members
-   Design GUI using Controls in the ToolBox
-   How button click event works
-   How Garbage collector will destroy the objects and What are the generations in Garbage Collector
-   What is an instance Method and What is the use of this keyword inside a method
-   Properties and What does a get and set block do
-   Difference between constructor and Destructor
-   Where the static members allocate memory
-   When the memory is allocated for static members
-   How to access a static member
-   Role of Static constructor and How it executes
-   When to declare a class as static

## OOPs – Inheritance

-   Protected keyword and How to bypass it through child class
-   Casting the reference types
-   What does a "is" operator do
-   What does "as" operator do
-   What does "??" operator do
-   Static Binding and Dynamic Binding
-   Override a method
-   Abstract class , abstract method
-   When to declare a class as abstract
-   Difference between abstract class and concrete class
-   When to declare a method using new keyword
-   What is a system.object class
-   Methods in the object class

## OOPs - Interface and Polymorphism

-   What is an interface
-   How does multiple inheritance is working with interfaces
-   How to solve if two interfaces having same method name
-   What is publicly implemented and Explicitly implemented
-   Why does the .net doesn't support multiple inheritance using classes
-   Implement an interface by inheriting it

## Collections and Generics

-   Types of collections and What is IEnumerable, ICollection, IList, IDictionary
-   ArrayList, HashTable, SortedList, Queue, Stack
-   iterate using IEnumerable
-   How sort using IComparer and IComparable
-   Advantages of Generics and How they work at Runtime
-   Generic methods and Generic collection classes
-   List and Dictionary

## Assemblies and GAC

-   Difference between DLL and EXE
-   Build a class library
-   Use a Class Library in another Application
-   What is Namespace
-   Internal Access Specifier
-   Types of Assemblies
-   Global Assembly Cache

## Exception Handling

-   Exception and types of Exceptions
-   Handle Exception using try and catch blocks
-   throw an Exception using throw ex and throw
-   What is finally Block
-   Define custom Exception class

## IO Streams

-   Stream and Types of Streams
-   What are standard IO streams
-   How Files can be Handled using FileMode, FileAccess, FileShare
-   Binary Reader and Binary Writer
-   work with File System
-   Serialization and Deserialization

## Reflection and Attributes

-   Read type information Using Reflection
-   work with Attributes
-   Pre-defined Attributes
-   Custom Attributes
-   Read custom attributes Using Reflection

## Extended C# Language Features

-   Operator Overloading
-   Partial class, partial methods
-   Extension Methods
-   Anonymous Types
-   Tuples
-   Caller Information
-   Configuration File

## New Features of C# 6.0

-   String Interpolation
-   Null Conditional Operator
-   Auto Property Initializer
-   Dictionary / Index Initializer
-   Expression-bodied function members
-   Static Using
-   Name of Expression
-   Exception Filters
-   Declaration Expressions
-   How does await keyword works in catch and finally block

## Developing GUI Application Using WinForms

-   Controls in the WindowsForms
-   Important properties of the controls
-   Important Events that each control have
-   Container controls
-   Graphical Objects
-   GDI objects
-   MenuStrip, ContextMenuStrip, ToolStrip And StatusStrip
-   Model Dialog
-   Modeless dialog Box
-   Multiple Document Interface
-   Form Inheritance
-   Add Login Facility to the Application
-   Resource files
-   NotifyIcon Control
-   Timer control
-   Drag and Drop the Files
-   Treeview
-   ListView

## ADO.NET Part1 - Managed Provider Objects

-   What is a Manage Provider and important objects in it?
-   How to Install SQL server and Management Studio
-   How to establish a connection to Database
-   What is Connection Pooling
-   How to insert, Update, Delete the data in the Database from the Application
-   How to Fetch Data from the Database using Select command
-   How to implement Login to the Application using Database
-   What is MultipleActiveResultSets
-   What is Parameterized Prepared Statement
-   How to write stored procedures in Backend
-   How to Execute storedprocedures from front end Application
-   What are the Transactions
-   How to Manage the Transactions using Transaction Scope
-   What is Asynchronous Execution of SQL Commands
-   How to write Provider independent code
-   What is utility class

## ADO.NET Part2 - DataSet Object Model

-   What are DataAdapter events
-   How to handle Concurrency issues if multiple users performing operations on same Data
-   How to sort and filter the data using DataView
-   What are the constrains in the DataTable and How to Add the constrain to the DataTable
-   What is a DataRelation object
-   How to create DataSet/ DataTable Dynamically without using DataAdapter
-   What is Typed Dataset

## N-Tier Layered Architecture Applications

-   Introduction to N-Tier
-   What is a Tier and What is a Layer
-   What is the Role of Presentation layer, Data layer, Business object Layer, DAO layer
-   How to design a GUI for the Application
-   How to use Helper class and Enum
-   How to pass the data from one Layer to another Layer

## XML

-   What is a XML and XML parser
-   What is DOM parser
-   How to perform CRUD operations on XML DOM
-   How to get the reference to nodes in XMLDocument using XPath
-   How XML works with DataSet
-   What is XML Textwriter and XML TextReader
-   What is XPath Document and XPath Navigator

## Windows Services

-   What is a Windows service
-   How to create a new windows service Template
-   How to Install/Deploy windows service in the OS
-   How to Launch a Windows Service
-   How to develop an Application for controlling the Service

## Delegates & Events

-   What is a Delegate
-   How to create a chat application using Delegates
-   How to raise an event using Delegates
-   What are Anonymous Methods

## User Control and Custom Control

-   What is User Control
-   What is composite control
-   How to inherit the User Control
-   What is a custom control

## MultiThreading

-   What is process and Thread
-   What is difference between MultiThreading and Multitasking
-   What is scheduling and types of scheduling
-   How to set the Thread priority
-   How to suspend, Resume, Interrupt, Abort and get the status of Thread
-   What is cross Thread operation
-   What is Thread pool
-   What is Thread Synchronization
-   What is critical section
-   What is Mutex
-   What is Semaphore
-   What is Task parallel programming
-   What is Async Programming

## Debugging and Diagnostics

-   What is Debugging
-   What is Build Configuration (Debug and Release)
-   What are List of Debugging Windows
-   What is Break Point Hit Count and Condition
-   What are Debugging Exceptions
-   What is Diagnostics
-   What is Debug and Trace Classes
-   What are Types of Listeners
-   What is Boolean and Trace Switch

##
