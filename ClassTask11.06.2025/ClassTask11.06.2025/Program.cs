using ClassTask11._06._2025.Exceptions;
using ClassTask11._06._2025.models;
using StudentModel;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void optionsPrint()
            {
                Console.WriteLine(

                           "1. Telebe elave et\n" +
                           "2. Telebeye imtahan elave et\n" +
                           "3. Telebenin bir imtahan balina bax\n" +
                           "4. Telebenin butun imtahanlarini goster\n" +
                           "5. Telebenin imtahan ortalamasini goster\n" +
                           "6. Telebeden imtahan sil\n" +
                           "7. Butun telebelerin melumatlarini yaz\n" +
                           "8. Telebe axtar ve sec\n" +
                           "0. Programi bitir\n");

            

            }

            try
            {
                optionsPrint();
                StudentManager<Student> studentManager = new StudentManager<Student>();
                studentManager.addStudent(new Student("Ali", new Dictionary<string, int> { { "Math", 90 }, { "Physics", 85 } }));
                studentManager.addStudent(new Student("Ayşe", new Dictionary<string, int> { { "Math", 95 }, { "Chemistry", 88 }, { "English", 92 } }));
                studentManager.addStudent(new Student("Mehmet", new Dictionary<string, int> { { "Biology", 75 }, { "Geography", 80 } }));
                studentManager.addStudent(new Student("Elif", new Dictionary<string, int> { { "Math", 100 }, { "Physics", 90 }, { "Chemistry", 85 } }));
                studentManager.addStudent(new Student("Can", new Dictionary<string, int> { { "English", 78 } }));
                void addStudent()
                {
                    string FullName;
                    Dictionary<string, int> exam;
                    Console.WriteLine("ad daxil edin");
                    FullName = Console.ReadLine() ?? " ";
                    Console.WriteLine("imtahan adi ve balin daxil edin");
                    exam = new Dictionary<string, int> { { Console.ReadLine() ?? " ", int.Parse(Console.ReadLine() ?? "0") } };
                    studentManager.addStudent(new Student(FullName, exam));
                }
                bool condition = true;
                int selectedStudentNo = Student.no - 1;
                while (condition)
                {

                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            addStudent();
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();
                            break;
                        case 2:
                            Console.WriteLine("Imtahan adi ve balin daxil edin");
                            studentManager.students[selectedStudentNo].AddExam(Console.ReadLine() ?? " ", int.Parse(Console.ReadLine() ?? "0"));
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 3:
                            Console.WriteLine("Imtahan adin daxil edin");
                            Console.WriteLine(studentManager.students[selectedStudentNo].getExamResult(Console.ReadLine() ?? " "));
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 4:
                            foreach (var item in studentManager.students[selectedStudentNo].Exams)
                            {
                                Console.WriteLine($"{item.Key}:{item.Value}");
                            }
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 5:
                            Console.WriteLine(studentManager.students[selectedStudentNo].GetExamAvg());
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 6:
                            Console.WriteLine("imtahan adin daxil edin");
                            string examName = Console.ReadLine() ?? " ";
                            studentManager.students[selectedStudentNo].Exams.Remove(examName);
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 7:
                            foreach (Student student in studentManager.students)
                            {
                                Console.WriteLine($"ad:{student.FullName}");
                                Console.WriteLine("imtahanlar");
                                foreach (var item in student.Exams)
                                {
                                    Console.WriteLine($"{item.Key}:{item.Value}");
                                }
                                Console.WriteLine(" \n");

                            }

                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 8:
                            Console.WriteLine("Telebenin adin daxil edin");
                            string fullName = Console.ReadLine();
                            for (int i=0;i<  studentManager.students.Count;i++)
                            {
                                if (studentManager.students[i].FullName== fullName)
                                {
                                    selectedStudentNo = i;
                                    break;
                                }
                            }
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();

                            break;
                        case 0:
                            condition = false;
                            break;

                        default:
                            Console.WriteLine("Duzgun eded daxil edin");
                            Console.ReadLine();
                            Console.Clear();
                            optionsPrint();
                            break;
                    }
                }
            }
            catch (intParseException e)
            {
                throw new intParseException("add valid number");
            }
        }




    }
}
