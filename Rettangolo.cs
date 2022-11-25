﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        public int recbase;
        public int recheight;

        public int calcolaArea()
        {
            int area = 0;
            area = recbase * recheight;
            return area;
        }

        public int calcolaPerimetro()
        {
            int l = 0;
            l= (2* recbase) + (2* recheight);
            return l;
        }

        public void PrintRectangle()
        {
            Console.WriteLine("Base: \t\t" + this.recbase+"cm.");
            Console.WriteLine("Altezza: \t" + this.recheight+"cm.");
            Console.WriteLine("Perimetro: \t" + this.calcolaPerimetro()+"cm");
            Console.WriteLine("Area: \t\t" + this.calcolaArea()+ "cm2");
        }
    }
}
