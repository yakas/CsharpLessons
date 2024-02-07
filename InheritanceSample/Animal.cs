using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Animal
    {
        public string animalName;
        public string animalColor;
        public string animalType;
        private int animalAge;

        public void animalInfo()
        {
            Console.WriteLine("Animal name:"+animalName);
            Console.WriteLine("Animal color:" + animalColor);
            Console.WriteLine("Animal type:"+animalType);
            Console.ReadLine();
        }

        public int _animalAge
        {
            get
            {
                this.animalAge = -animalAge;
                return animalAge;
            }
            set
            {
                this.animalAge=_animalAge;

            }

        }

    }
}
