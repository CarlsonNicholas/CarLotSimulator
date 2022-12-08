using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        
        public Car()
        {
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public int Year;

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The engine goes {EngineNoise}"); 
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"The Honk goes {HonkNoise}");
        }

    }
}
