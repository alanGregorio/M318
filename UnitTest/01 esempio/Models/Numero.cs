﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_esempio.Models
{
    public class Numero
    {
        public string VerificaPari(int numero)
        {
           if(numero % 2 == 0)
            {
                return "pari";
            }
            else
            {
                return "dispari"; 
            }
        }
    }
}
