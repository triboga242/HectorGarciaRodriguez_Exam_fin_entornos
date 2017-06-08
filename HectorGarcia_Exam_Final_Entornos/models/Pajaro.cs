using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HectorGarcia_Exam_Final_Entornos.models
{
    class Pajaro:Animal
    {
        private bool _cantor;
        private string _especie;

        public Pajaro(String nombre, String fechaNac, double peso, bool canta, string especie) : base(nombre, fechaNac, peso)
        {
            _cantor = canta;
            Especie = especie;
        }

        public string Cantor
        {
            get
            {
                if (_cantor)
                    return "Uy si que canta";
                else
                    return "No canta no";
            }  
        }

        public string Especie
        {
            get
            {
                return _especie;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new Exception("Micro vacio"); }
                else { _especie = value; }
            }
        }

        public override string ToString()
        {
            return ("Pitas, pitas [\n nombre=" + Nombre + "\n Canta=" + Cantor + "\n fechaNac=" + FechaNac + "\n peso=" + Peso + "\n comentarios=" + Comentarios
                + "\n Especie=" + Especie + "\n]");
        }
    }
}
