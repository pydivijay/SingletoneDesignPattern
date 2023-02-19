// See https://aka.ms/new-console-template for more information

//Singleton singleton = Singleton.GetInstance;
//singleton.PrintDetails("vijay");
//Singleton singleton1 = Singleton.GetInstance;
//singleton1.PrintDetails("kumar");

Parallel.Invoke(
               () => PrintTeacherDetails(),
               () => PrintStudentdetails()
               );
Console.ReadLine();

static void PrintTeacherDetails()
{
    Singleton fromTeacher = Singleton.GetInstance;
    fromTeacher.PrintDetails("From Teacher");
}
static void PrintStudentdetails()
{
    Singleton fromStudent = Singleton.GetInstance;
    fromStudent.PrintDetails("From Student");
}

sealed class Singleton
{
    private static int counter = 0;
    private static Singleton? Instance = null;
    private static readonly object Instancelock = new object();

    public static Singleton GetInstance
    {
        get
        {
            lock (Instancelock)
            {
                if (Instance == null)
                    Instance = new Singleton();
            }
            return Instance;
        }
    }

    private Singleton()
    {
        counter++;
        Console.WriteLine("Counter Value " + counter.ToString());
    }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}