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

        public App(double version, string publisher, string[] supportedPlatforms, double fileSize)
        {
            this.version = version;
            this.publisher = publisher;
            this.supportedPlatforms = supportedPlatforms;
            this.fileSize = fileSize;
        }
        public void Execute()
        {

        }
    }
}
