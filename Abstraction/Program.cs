using Abstraction;

 class program
{
    public static void Main(string[] args)
    {
      UndergraduateStudent ObjUndergraduateStudent = new UndergraduateStudent();
        ObjUndergraduateStudent.Name = "Nayan";
        ObjUndergraduateStudent.Age = 26;
        ObjUndergraduateStudent.Major = "Deep Learning";
        ObjUndergraduateStudent.DisplayInfo();

        Console.WriteLine("Select The Payment Method : ");
        Console.WriteLine("Enter Your Choice");

        int choice = int.Parse(Console.ReadLine());

        Payment payment  = null;
        Console.WriteLine("Enter the Payment Amount : ");
        double amount = double. Parse(Console.ReadLine());




    }
}