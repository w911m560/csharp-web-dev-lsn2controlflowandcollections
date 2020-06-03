using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int studentID;
            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student ID numbers and names
            do
            {
                Console.WriteLine("ID number: ");
                string input = Console.ReadLine();
                
                studentID = int.Parse(input);

                if (!Equals(studentID, "")) {
                    Console.WriteLine("Name: ");
                    input = Console.ReadLine();
                    string name = input;
                    students.Add(studentID, name);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while(!Equals(studentID, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students) {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }


        }
    }
}
