// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Students;
Console.WriteLine("Students information system");
Student Stu1=new Student("ROHIT","XII",85);
Student Stu2=new Student("Anil","XII",65);
Student Stu3=new Student("Sidd","XII",99);



List<Student> students=new List<Student>();
students.Add(Stu1);
students.Add(Stu2);
students.Add(Stu3);






foreach (Student theStudent in students)

{  
  Console.WriteLine("name={0} std={1} marks{2}",theStudent.getname(),theStudent.getstd(),theStudent.getmarks());
}
