# Inheritance

<b>Rule 1:</b><br>
In C#, the parent classes constructor must be accessible to the child class; otherwise, the inheritance would not be possible because when we create the child class object, first it goes and <b>calls the parent class constructor</b> so that the parent class variable will be initialized and we can consume them under the child class.

<b>Rule 2:</b><br>
In inheritance, the child class can access the parent class members, but the parent classes can never access any members that are purely defined in the child class.

<b>Rule 3:</b><br>
We can Initialize a Parent class variable by using the child class instance to make it a reference variable so that the reference will be consuming the memory of the child class instance. But in this case, also, we cannot call any pure child class members using the reference.

<b>Rule 4:</b><br>
Every class that is defined by us or predefined in the libraries of the language has a default parent class, i.e., the Object class of the System namespace, so the members (Equals, GetHashCode, GetType, and ToString) of the Object class are accessible from anywhere.

<b>Rule 5:</b><br>
In C#, we don’t have support for multiple inheritances through classes. What we are provided is only a Single Inheritance through classes. That means with classes, only one immediate parent class is allowed (i.e., Single, Multilevel, and Hierarchical supported), and more than one immediate parent class is not allowed in C# with classes (i.e., Multiple and Hybrid are not supported).

<b>Rule 6:</b><br>
In Rule1, we learned whenever the child class instance is created, the child class constructor will implicitly call its parent classes constructor, but if the parent classes constructor is parameterless. If the constructor of the Parent class is parameterized, then the Child class constructor cannot implicitly call its Parent’s constructor. So, to overcome this problem, it is the responsibility of the programmer to explicitly call the Parent classes constructor from the child class constructor and pass values to those parameters. To call the Parent’s constructor from the child class, we need to use the base keyword.
