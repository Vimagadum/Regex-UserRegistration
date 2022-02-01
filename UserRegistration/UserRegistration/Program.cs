// See https://aka.ms/new-console-template for more information
using UserRegistration;

Console.WriteLine("Hello, World!");
ValidUserRegistraton validUserRegistraton = new ValidUserRegistraton();
//Console.WriteLine("Enter valid first name");
//string frstname = Console.ReadLine();
//validUserRegistraton.ValidateFName(frstname);
//Console.WriteLine("Enter valid last name");
//string lstname = Console.ReadLine();
//validUserRegistraton.ValidateLName(lstname);
//Console.WriteLine("Enter valid EmailId");
//string mail = Console.ReadLine();
//validUserRegistraton.ValidateEmail(mail);
//Console.WriteLine("Enter mobile number");
//string mnum = Console.ReadLine();
//validUserRegistraton.ValidateMobile(mnum);
//Console.WriteLine("Enter password");
//string psswrd = Console.ReadLine();
//validUserRegistraton.ValidatePassword(psswrd);
//Console.WriteLine("Enter password with at least one upper case");
//string psswrd2 = Console.ReadLine();
//validUserRegistraton.ValidatePassword2(psswrd2);
Console.WriteLine("Enter password with at least one upper case and at least one number");
string psswrd3 = Console.ReadLine();
validUserRegistraton.ValidatePassword2(psswrd3);

