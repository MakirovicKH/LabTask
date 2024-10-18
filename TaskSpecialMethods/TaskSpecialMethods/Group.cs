using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSpecialMethods
{
    public class Group
    {
        public string Name { get; set; }
        public string Shift { get; set; }
        public Student[] Students { get; set; }
        private int currentStudentCount; // tələbə sayı

        // Constructor
        public Group(string name, string shift)
        {
            Name = name;
            Shift = shift;
            Students = new Student[18]; // Maksimum 18 tələbə üçün array yaradılır
            currentStudentCount = 0; // Tələbəl'ri yoxlamaq sıfırdan başlayır
        }

        // AddStudentlə tələbə əlavə etmək
        public void AddStudent(Student student)
        {
            if (currentStudentCount < Students.Length)
            {
                if (FindStudent(student.Name) == null)
                {
                    Students[currentStudentCount] = student; // Yeni tələbəni array-a əlavə edirik
                    currentStudentCount++; 
                    Console.WriteLine($"{student.Name}add to group");
                }
                else
                {
                    Console.WriteLine($"{student.Name} is group.");
                }
            }
            else
            {
                Console.WriteLine("no more students can be added to the group");
            }
        }

        // FindStudent tələbəni tapmaq
        public Student FindStudent(string name)
        {
            for (int i = 0; i < currentStudentCount; i++)
            {
                if (Students[i].Name == name)
                {
                    return Students[i];
                }
            }
            return null; // Tələbə tapılmadıqda null qaytarır
        }
    }

}
