// See https://aka.ms/new-console-template for more information
using UserRegistration;

Console.WriteLine("Hello, World!");
ValidUserRegistraton validUserRegistraton = new ValidUserRegistraton();
Console.WriteLine("Enter valid first name");
string frstname = Console.ReadLine();
validUserRegistraton.ValidateFName(frstname);
Console.WriteLine("Enter valid last name");
string lstname = Console.ReadLine();
validUserRegistraton.ValidateLName(lstname);
