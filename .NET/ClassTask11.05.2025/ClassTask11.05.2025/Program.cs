using ClassTask11._05._2025.task_4;
using System.Text.Json;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            string filePath = "C:\\Users\\II novbe\\Desktop\\CodeAcdemyTasks\\ClassTask11.05.2025\\ClassTask11.05.2025\\task 1\\index.txt";
            string copyFilePath = "C:\\Users\\II novbe\\Desktop\\CodeAcdemyTasks\\ClassTask11.05.2025\\ClassTask11.05.2025\\task 2\\copy.txt";
            string textFilePath = "C:\\Users\\II novbe\\Desktop\\CodeAcdemyTasks\\ClassTask11.05.2025\\ClassTask11.05.2025\\task 3\\text.txt";
            string errorFilePath = "C:\\Users\\II novbe\\Desktop\\CodeAcdemyTasks\\ClassTask11.05.2025\\ClassTask11.05.2025\\task 3\\error.txt";

            using (StreamReader file = new StreamReader(filePath))
            {
                file.ReadLine();
            }

            using (StreamReader file = new StreamReader(filePath))
            {

                using (StreamWriter copyFile = new StreamWriter(copyFilePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        copyFile.WriteLine(line, true);
                    }
                }
            }


            using (StreamReader file = new StreamReader(textFilePath))
            {

                using (StreamWriter errorFile = new StreamWriter(errorFilePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        if (line.ToLower().Contains("error"))
                        {
                            errorFile.WriteLine(line, true);
                        }

                    }

                }
            }


            Person person = new Person(
                "Person",
                15
                );

            string jsonPath = "C:\\Users\\II novbe\\Desktop\\CodeAcdemyTasks\\ClassTask11.05.2025\\ClassTask11.05.2025\\task 4\\person.json";
            string jsonString = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });

            using (StreamWriter file=new StreamWriter(jsonPath))
            {
                Console.WriteLine(jsonString);
                file.Write(jsonString);
            }

        }
    }
}