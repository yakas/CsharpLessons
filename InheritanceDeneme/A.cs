﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDeneme
{
    public class A
    {
        //FİELD 
        public int id;
        public string name;
        public string description;
        public A(int sayi) // Contructor metod parametre alırsa A sınıftan kalıtım alan B class
                           // icin base() ifadesiye A classın aldıgı parametre tipinde ekleme yapılır.
        {
            sayi += 2;
        
        }
    }
}
