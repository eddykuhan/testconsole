using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ProxyImage : IImage
    {

        private IImage image;
        private string fileName;
        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void display()
        {

            if (image is null)
            {
                image = new RealImage(this.fileName);
            }
            image.display();
        }
    }
}
