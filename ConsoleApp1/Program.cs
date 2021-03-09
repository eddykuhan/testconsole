namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var sg = SingleClass.GetInstance();

            sg.showMsg();

            System.Console.Read();
        }
    }
}
