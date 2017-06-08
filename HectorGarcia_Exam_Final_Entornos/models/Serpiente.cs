using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HectorGarcia_Exam_Final_Entornos.models
{
    class Serpiente:Animal
    {
        private bool _venenosa;
        private string _especie;

        public Serpiente(String nombre, String fechaNac, double peso, bool veneno, string especie) : base(nombre, fechaNac, peso)
        {
            _venenosa = veneno;
            Especie = especie;
        }

        public string Envenena
        {
            get
            {
                if (_venenosa)
                    return "Uy si que mata";
                else
                    return "Totalmente inofensiva";
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
            return ("Bicha [\n nombre=" + Nombre + "\n Envenena=" + Envenena + "\n fechaNac=" + FechaNac + "\n peso=" + Peso + "\n comentarios=" + Comentarios
                + "\n Especie=" + Especie + "\n]");
        }
    }
}
