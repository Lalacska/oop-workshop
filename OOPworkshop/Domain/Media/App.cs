using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class App : Media
    {
        private double version;
        private string publisher;
        private string[] supportedPlatforms;
        private double fileSize; 

        public App(int ID, string title, int[] ratings, bool isAvailable, double version, string publisher, string[] supportedPlatforms, double fileSize) : base(ID, title, ratings, isAvailable)
        {
            this.version = version;
            this.publisher = publisher;
            this.supportedPlatforms = supportedPlatforms;
            this.fileSize = fileSize;
        }
        public void Execute()
        {
            Console.WriteLine("You can now execute the app");
        }
        public override string ToString()
        {
            return "Title of app: " + "Version: " + "SupportedPlatforms: " + "File size: ";
        }
    }
}
