
using ClassTask11._30._2025.Models.task2;
using System;
using System.Text.RegularExpressions;


namespace MyApp
{


    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //Notebook notebook1 = new Notebook(1, "Lenovo ThinkPad", 1800, 10, 16, 512);
            //Notebook notebook2 = new Notebook(2, "HP Victus", 2200, 15, 32, 1024);
            //Phone phone1 = new Phone(3, "iPhone 14", 2500, 5, 1);
            //Phone phone2 = new Phone(4, "Samsung Galaxy S24", 2300, 7, 2);


            //Product[] products = { notebook1, notebook2, phone1, phone2 };


            //Store store = new Store(products, NotebookLimit: 3, PhoneLimit: 2);

            //Console.WriteLine("Notebook sayı: " + store.noteBookCount());
            //Console.WriteLine("Telefon sayı: " + store.phoneCount());
            //Console.WriteLine("Notebookların orta qiyməti: " + store.CalcNotebookAvg());


            //Notebook notebook3 = new Notebook(5, "Acer Nitro", 2000, 8, 16, 512);
            //store.AddProduct(notebook3);
            //store.AddProduct(notebook3);
            //store.AddProduct(notebook3);

            //try
            //{

            //    Product found = store.FindByNo(12);

            //    Console.WriteLine($"ad: {found.name} - qiymet: {found.price}");

            //}
            //catch (Exception ex)
            //{
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}




            Student st1 = new Student("Vidadi Abbasov", 301, 85);
            Student st2 = new Student("Aysel Mammadova", 302, 92);
            Student st3 = new Student("Elvin Aliyev", 303, 78);
            Student st4 = new Student("Narmin Huseynova", 304, 88);


            Student[] students = { st1, st2, st3, st4 };
            Groupp group = new Groupp("BP231", students, 6);



            bool continueProses = true;
            while (continueProses)
            {
                Console.WriteLine("0:quit proqram \n1:create student \n2:show all students info \n3:find by full name");

                int proses = int.Parse(Console.ReadLine());
                string fullName;
                int GroupNo;
                int AvgPoint;
                switch (proses)
                {
                    case 1:
                        try
                        {

                            Console.WriteLine("enter fullName");
                            fullName = Console.ReadLine();
                            Console.WriteLine("enter GroupNo");
                            GroupNo = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter AvgPoint");
                            AvgPoint = int.Parse(Console.ReadLine());
                            Student newStudent = new Student(fullName, GroupNo, AvgPoint);
                            group.AddStudent(newStudent);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;

                    case 2:
                        foreach (Student student in group.students)
                        {
                            Console.WriteLine($"{student.fullName} {student.GroupNo} {student.AvgPoint}");
                        }
                        break;

                    case 3:
                         fullName = Console.ReadLine() ?? " ";
                        foreach (Student student in group.students)
                        {
                            if (student.fullName == fullName)
                            {
                                Console.WriteLine($"{student.fullName} {student.GroupNo} {student.AvgPoint}");
                            }
                        }
                        Console.WriteLine("User not found");
                        break;
                    case 4:
                        continueProses = false;
                        break;
                    default:
                        Console.WriteLine("Enter only betwwen 0 and 4 numbers");
                        break;
                }
            }
        }
    }
}









