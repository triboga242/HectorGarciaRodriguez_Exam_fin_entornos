using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HectorGarcia_Exam_Final_Entornos.models
{
    class Gato:Animal
    {
        private string _raza;
        private string _micro;

        public Gato(String nombre, String fechaNac, double peso, string raza, string micro) : base(nombre, fechaNac, peso)
        {
            Raza = raza;
            Micro = micro;
        }

        public string Raza
        {
            get
            {
                return _raza;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new Exception("Raza vacia"); }
                else { _raza = value; }
            }
        }

        public string Micro
        {
            get
            {
                return _micro;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new Exception("Micro vacio"); }
                else { _micro = value; }
            }
        }

        public override string ToString()
        {
            return ("Gatico [\n nombre=" + Nombre + "\n Raza=" + Raza + "\n fechaNac=" + FechaNac + "\n peso=" + Peso + "\n comentarios=" + Comentarios
                + "\n Micro=" + Micro + "\n]");
        }
    }
}
