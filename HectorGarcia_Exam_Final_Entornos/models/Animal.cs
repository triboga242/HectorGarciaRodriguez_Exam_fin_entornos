using HectorGarcia_Exam_Final_Entornos.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HectorGarcia_Exam_Final_Entornos.models
{
    abstract class Animal:IPesable
    {

        protected String _nombre;
        protected String _fechaNac;
        protected double _peso;
        protected String _comentarios;

        public Animal(String nombre, String fechaNac, double peso)
        {
            Nombre = nombre;
            FechaNac = fechaNac;
            Peso = peso;
            Comentarios = "";
        }


        public double Peso
        {
            get
            {
                return _peso;
            }
            private set
            {
                if (value < 1 || value > 200) { throw new Exception("Peso fuera de rango"); }
                else { _peso = value; }
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new Exception("Nombre vacio"); }
                
                else { _nombre = value; }
            }
        }

        public string FechaNac
        {
            get
            {
                return _fechaNac;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new Exception("Fecha vacia"); }
                else { _fechaNac = value; }
            }
        }

        public string Comentarios
        {
            get
            {
                return _comentarios;
            }
            set
            {
                 _comentarios = value; 
            }
        }



        public override string ToString()
        {
            return ("Animal [nombre=" + Nombre + "\n fechaNac=" + FechaNac + "\n peso=" + Peso + "\n comentarios=" + Comentarios
                + "]");
        }

        public void Pesar(double peso)
        {
            Peso=peso;
        }
    }
}
