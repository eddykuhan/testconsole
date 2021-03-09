using System;

namespace ConsoleApp4
{
    public class RealImage : IImage
    {
        private string fileName;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }
        public void display()
        {
            Console.WriteLine("Displaying IMage " + fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading .. " + fileName);
        }
    }
}
