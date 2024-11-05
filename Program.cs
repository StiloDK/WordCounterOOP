﻿using System;

namespace WordCount
{
    internal class Program
    {
        static void Main()
        {
            string text = "It's important to understand two fundamental points about the type system in .NET: It supports the principle of inheritance. Types can derive from other types, called base types. The derived type inherits (with some restrictions) the methods, properties, and other members of the base type. The base type can in turn derive from some other type, in which case the derived type inherits the members of both base types in its inheritance hierarchy. All types, including built-in numeric types such as System.Int32 (C# keyword: int), derive ultimately from a single base type, which is System.Object (C# keyword: object). This unified type hierarchy is called the Common Type System (CTS). For more information about inheritance in C#, see Inheritance.\r\nEach type in the CTS is defined as either a value type or a reference type. These types include all custom types in the .NET class library and also your own user-defined types. Types that you define by using the struct keyword are value types; all the built-in numeric types are structs. Types that you define by using the class or record keyword are reference types. Reference types and value types have different compile-time rules, and different run-time behavior.";
            string word = "type";

            WordCounter wordCounter = new WordCounter();
            int count = wordCounter.Count(text, word);
            Console.WriteLine(count);
        }
    }
}
