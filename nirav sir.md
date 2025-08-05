29/07/2025 /-



### C# is called an object-oriented programming (OOP) language because it follows the four main principles of OOP:





It supports classes and objects :-



class : blueprint of an object

&nbsp;	logical entity

EX.:

class (tree):

&nbsp;	leaf

&nbsp;	roots

&nbsp;	trunk

&nbsp;	branches

&nbsp;	fruits



class (table):

&nbsp;	no. of lag

&nbsp;	material

&nbsp;	length

&nbsp;	width



class (computer):

&nbsp;	hardware

&nbsp;	OS

&nbsp;	software

&nbsp;	

class (pen):

&nbsp;	company

&nbsp;	colour

&nbsp;	type



class (electronic devices):

&nbsp;	uses AC current





==========================================================================================================================================



object: instance of a class

&nbsp;	physical entity





==========================================================================================================================================

**1. Encapsulation :** binding data and logic into methods, data hiding 

&nbsp;	members => not accessible from outside 

&nbsp;	(default) => private

==========================================================================================================================================

**2. Abstraction :** hiding complexity and showing only needed

&nbsp;	abstract keyword, interface 

==========================================================================================================================================

**3. Inheritance :** inherits one class to acquire the members and methods of that class

&nbsp;	-single

&nbsp;	-multilevel

&nbsp;	-multiple (\*)

&nbsp;	-hierarchical

&nbsp;	-hybrid

==========================================================================================================================================



**4. Polymorphism :** same method can behave different according to objects



&nbsp;	i.  static binding == compile time == method overriding

&nbsp;	ii. dynamic binding == run time == method overloading



==========================================================================================================================================

getter method do not contain any argument it must contain return

setter method always contain arguments





\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_



### constructors in C#:



Same name as the class

No return type (not even void)

Automatically invoked when you use new keyword

2 types:	 (1)default constructor with no parameter 

&nbsp;		 (2)parameterized constructor 



------------------------------------------------------------------------------------------------------------------------------------------



\- one kind of special method of a class

\- its name is same as class name

\- never return any value-out even void

\- are called automatically when object of a class is created

\- used to initialized private members within a class



Types:

=> default constructor 

&nbsp;	-> does not take any arguments



=> parameterized constructor 

&nbsp;	-> arguments are constructor

&nbsp;	-> take care to pass the same number of arguments at the time of object creation

&nbsp;

=> copy constructor 

&nbsp;	-> when we want to create a new object from existing object 

&nbsp;		-provide same set of values to all members of a class 

&nbsp;	-> object as an argument is passed 



=> static constructor

&nbsp;	-> static keyword with constructor 

&nbsp;	-> it will not take any arguments



=> private constructor

&nbsp;	-> it is private and parameter-less

&nbsp;	-> when all members of a class are static





