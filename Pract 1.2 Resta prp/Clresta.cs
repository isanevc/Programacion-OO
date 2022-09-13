﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_1._2_Resta_prp
{
    internal class Clresta
    {
        private int n1;
        private int n2;

        //Constructor (siempre se llama igual que la clase)
        public Clresta(int n1, int n2)
        {
            this.N1 = n1;
            this.N2 = n2;
        }

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        //Constructor vacío
        public Clresta()
        {

        }

        //Método, acción, lo que hace
        public int restar()
        {
            return (N1 - N2);
        }
    }
}
