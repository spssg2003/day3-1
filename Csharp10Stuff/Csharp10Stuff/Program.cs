// See https://aka.ms/new-console-template for more information


using Csharp10Stuff;
using System.Reflection.Metadata;

var bob = new Employee(99, "Bob", "Smith", "bob@aol.com");

Console.WriteLine(bob.ToString());

Console.WriteLine(bob.ToString());



//var employee = _employeeLookup.GetById(99);
//bob.FirstName = "Robert";
//bob.LastName = "Smith";

Console.WriteLine(bob.FirstName);
Console.WriteLine(bob.LastName.ToUpper());
