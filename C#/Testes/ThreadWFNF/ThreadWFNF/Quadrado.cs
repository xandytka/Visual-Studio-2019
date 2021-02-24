using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadWFNF
{
    class Quadrado
    {
        private int lado_a;
        private int lado_b;

        //declaração setters getters

        public void setLado_a(int a)
        {
            lado_a = a;
        }
        public void setLado_b(int b)
        {
            lado_b = b;
        }
        public int getLado_a()
        {
            return lado_a;
        }
        public int getLado_b()
        {
            return lado_b;
        }
        //Declaração metodo da classe
        public int MostraArea()
        {
            return lado_a * lado_b;
        }
    }
}
