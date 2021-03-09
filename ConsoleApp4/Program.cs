namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.display();
            System.Console.WriteLine("");

            //image will not be loaded from disk
            image.display();
            System.Console.Read();
        }
    }
}
