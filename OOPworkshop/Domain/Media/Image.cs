using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class Image : Media
    {
        private int[] resolution = new int[2];
        private string fileFormat;
        private double fileSize;
        private DateTime dateTaken;

        public Image(int ID, string title, int[] ratings, bool isAvailable, int[] resolution, string fileFormat, double fileSize, DateTime dateTaken) : base(ID, title, ratings, isAvailable)
        {
            this.resolution = resolution;
            this.fileFormat = fileFormat;
            this.fileSize = fileSize;
            this.dateTaken = dateTaken;
        }

        public void Display()
        {
            Console.WriteLine("Displaying image...");
        }
        public override string ToString()
        {
            return "Title of image: " + GetTitle() + " Resolution: " + resolution + " File format: " + fileFormat + " File size: " + fileSize + " Date taken: " + dateTaken;
        }

    }
}
