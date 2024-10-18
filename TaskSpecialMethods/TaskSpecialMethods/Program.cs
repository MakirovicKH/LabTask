namespace TaskSpecialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Group obyektinin yaradılması 
            Group group1 = new Group("AB205", "axşam");

            // Student obyektinin yaradılması
            Student student1 = new Student
            {
                Name = "Hüseyn",
                SurName = "Hüseynov",
                Gender = "Kişi",
                Age = 20,
                PhoneNumber = "0501234567",
                Limit = 3,
                Group = "AB205"
            };

            // Tələbəni qrupa əlavə etmək
            group1.AddStudent(student1);

            // FindStudent metodu ilə tələbənin olub-olmamasını yoxlamaq
            Student foundStudent = group1.FindStudent("");
            if (foundStudent != null)
            {
                Console.WriteLine($"{foundStudent.Name} is found to group.");
            }
            else
            {
                Console.WriteLine("is not found to group");
            }

            //K'silməyi absentlə tapmaq
            student1.Absent();  // Limit 1
            student1.Absent();  // Limit 2
            student1.Absent();  // Limit 3 və son
            student1.Absent();  // "to fail an exam" mesajı verəcək
        }
    }

}
