using HectorGarcia_Exam_Final_Entornos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HectorGarcia_Exam_Final_Entornos
{
    class Program
    {

        private static TiendaVeterinaria c;

        static void Main(string[] args)
        {
            c = new TiendaVeterinaria("TriboBichos");
            c.menu1();
        }
    }
}
