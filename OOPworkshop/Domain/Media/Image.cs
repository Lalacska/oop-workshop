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

        public Image(int[] resolution, string fileFormat, double fileSize, DateTime dateTaken)
        {
            this.resolution = resolution;
            this.fileFormat = fileFormat;
            this.fileSize = fileSize;
            this.dateTaken = dateTaken;
        }

        public void Display()
        {

        }

    }
}
