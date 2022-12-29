// See https://aka.ms/new-console-template for more information
using System;
    namespace Stringconcat
{
    class Program {
        static void Main(String[] args) {
Console.WriteLine("Enter First name");
string firstname= Console.ReadLine();

Console.WriteLine("Enter Middle name");
string middlename=Console.ReadLine();
Console.WriteLine("Enter Last name");
string lastname=Console.ReadLine();

string fullname=firstname+" "+middlename+" "+lastname;

Console.WriteLine("Fullname is "+fullname);
Console.WriteLine("Length is "+fullname.Length);
} } } 