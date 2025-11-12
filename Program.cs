namespace ConsoleApp2;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int[] Grades { get; set; } = new int[0];
    public void ShowInfo()
    { 
       Console.WriteLine($"Ad :{Name},Soyadi :{Surname},Ortalamasi :{GetAverage():0.00}");
    }
    public double GetAverage()
    {
        double average = 0;
        int sum = 0;
        for (int i = 0; i < Grades.Length; i++)
        {
            sum += Grades[i];
        }
        average = sum / Grades.Length;
        return average;
    }

}
public class Program
{
       static Student[] students = new Student[0];
    static void Main(string[] args)
    {

        int n = 1;

        while (n == 1)
        {
        Evvel:
            Console.WriteLine("Emeliyat secimi edin:");
            Console.WriteLine("1-Yeni Telebe elave et:");
            Console.WriteLine("2-Verilmis Id Telebeni sil:");
            Console.WriteLine("3-Telebeye qiymet elave et:");
            Console.WriteLine("4-Butun Telebeleri Ekrana Cixart:");
            Console.WriteLine("5-Cixis et:");
            Console.Write("Secim:");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    AddStudent();
                        break;
                case 2:
                        break;
                case 3:
                    AddGrade();
                        break;
                case 4:
                    GetAll();
                        break;
                case 5:
                    Environment.Exit(0);
                        break;
                default:
                    break;
            }
         Console.Write("Emeleiyati davam etmek isteyirsen?(1/0)");
         n = Convert.ToInt32(Console.ReadLine());
          if (n == 1)
           goto Evvel;
           else if (n == 0)
           {
             break;
           }
        }
        static void AddStudent()
        {
            Console.Write("Telebenin Id daxil et: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Telebenin adini daxil et: ");
            string name = Console.ReadLine();
            Console.Write("Telebenin soyadini daxil et: ");
            string surname = Console.ReadLine();
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = new Student
            {
                Id = id,
                Name = name,
                Surname = surname
            };
        }
        static void AddGrade()
        {
            Console.Write("Telebenin Id daxil et: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = Array.Find(students, s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("Bu ID-li tələbə tapılmadı!");
                return;
            }
            Console.Write("Yeni qiyməti daxil et: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            int[] newGrades= new int[students.Length];
            Array.Resize(ref newGrades, newGrades.Length + 1);
            newGrades[newGrades.Length - 1] = grade;
        }

       static void GetAll()
       {
            if (students.Length == 0)
            {
                Console.WriteLine("Telebe yoxdur!");
                return;
            }

            Console.WriteLine("Telebeler");
            Console.WriteLine("----------------------------------");
           
            foreach (var a in students)
            {
                a.ShowInfo();
                
            }
       }
    }
}
