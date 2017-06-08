using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HectorGarcia_Exam_Final_Entornos.models
{
    class TiendaVeterinaria
    {
        private String _nombre;
        public List<Animal> listaAnimales;

        public TiendaVeterinaria(String nombre)
        {
            _nombre = nombre;
            listaAnimales = new List<Animal>();
        }
        //menuses

        /**
	 * muestra el menu principal
	 */
        public void menu1()
        {
            Console.WriteLine("Bienvenido a esta su clinica [" + _nombre + "]");
            int opcion;
            do
            {

                Console.WriteLine();
                Console.WriteLine("*******MENU PRINCIPAL*******");
                Console.WriteLine("*1.Añadir animal           *");
                Console.WriteLine("*2.Modificar comentarios   *");
                Console.WriteLine("*3.Mostrar ficha           *");
                Console.WriteLine("*4.Salir de la cli­nica     *");
                Console.WriteLine("*******MENU PRINCIPAL*******");

                opcion = LeerEntero();

                switch (opcion)
                {

                    case 1:
                        aniadirAnimal();
                        break;

                    case 2:
                        cambiarComentarios();
                        break;

                    case 3:
                        buscarAnimal();
                        break;

                    case 4:
                        Console.WriteLine("Gracias por su visita, espero no tenga una tarde de perros.");
                        break;

                    default:
                        Console.WriteLine("[ERROR] Opcion no contemplada");
                        break;
                }
            } while (opcion != 5);
        }

        /**
 * Muestra el menu de tipos de animales
 * 
 * @return entero validado
 */
        private int menu1_1()
        {

            int opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine("*******TIPO ANIMAL*******");
                Console.WriteLine("*1.Perro                *");
                Console.WriteLine("*2.Gato                 *");
                Console.WriteLine("*3.Pajaro               *");
                Console.WriteLine("*4.Reptil               *");
                Console.WriteLine("*******TIPO ANIMAL*******");

                opcion = LeerEntero();
            } while (opcion < 1 || opcion > 4);
            return opcion;
        }


        /**
 * pedira los datos del animal, lo construira y aÃ±adira a la lista
 */
        private void aniadirAnimal()
        {
            string nombre;
            string fechaNac ="";
            int dia, mes, anio;
            double peso;
            int aux;

            int opcion = menu1_1();

            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Dia nacimiento:");
            dia = LeerEntero();
            Console.WriteLine("Mes nacimiento:");
            mes = LeerEntero();
            Console.WriteLine("Anio nacimiento:");
            anio = LeerEntero();
            Console.WriteLine("Peso:");
            peso = LeerDouble();
            string auxFecha = dia.ToString();
            fechaNac +=(dia.ToString() + "/" + mes.ToString() + "/" + anio.ToString());
            
            switch (opcion)
            {
                case 1:
                    String razaP, microP;
                    Console.WriteLine("Raza:");
                    razaP = Console.ReadLine();
                    Console.WriteLine("Numero microchip:");
                    auxFecha = Console.ReadLine();
                    microP = auxFecha.ToString();
                    Perro p = new Perro(nombre, fechaNac, peso, razaP, microP);
                    insertaAnimal(p);
                    break;
                case 2:
                    String razaG, microG;
                    Console.WriteLine("Raza:");
                    razaG = Console.ReadLine();
                    Console.WriteLine("Numero microchip:");
                    auxFecha = Console.ReadLine();
                    microG = auxFecha.ToString();
                    Gato g = new Gato(nombre, fechaNac, peso, razaG, microG);
                    insertaAnimal(g);
                    break;
                case 3:
                    String razaPa;
                    bool cantor = false;
                    Console.WriteLine("Raza:");
                    razaPa = Console.ReadLine();
                    Console.WriteLine("Canta: (1. si / 2. no)");
                    do
                    {
                        aux = LeerEntero();
                    } while (aux < 1 || aux > 2);
                    if (aux == 1)
                    {
                        cantor = true;
                    }
                    else if (aux == 2)
                    {
                        cantor = false;
                    }
                    else {
                        Console.WriteLine("[ERROR] opcion no contemplada");
                    }
                    Pajaro pa = new Pajaro(nombre, fechaNac, peso, cantor, razaPa);
                    insertaAnimal(pa);
                    break;
                case 4:

                    String razaR;
                    bool venenoso = false;
                    Console.WriteLine("Raza:");
                    razaR = Console.ReadLine();
                    Console.WriteLine("Es venenoso: (1. si / 2. no)");

                    do
                    {
                        aux = LeerEntero();
                    } while (aux < 1 || aux > 2);
                    if (aux == 1)
                    {
                        venenoso = true;
                    }
                    else if (aux == 2)
                    {
                        venenoso = false;
                    }
                    else {
                        Console.WriteLine("[ERROR] opcion no contemplada");
                    }
                    Serpiente r = new Serpiente(nombre, fechaNac, peso, venenoso, razaR);
                    insertaAnimal(r);
                    break;
            }
        }


        /**
	 * aÃ±adirÃ¡ a la lista
	 * 
	 * @param a
	 *            animal a aÃ±adir
	 */
        private void insertaAnimal(Animal a)
        {

            int control = 0;

            if (listaAnimales.Contains(a))
            {
                Console.WriteLine("Ya se encuentra registrado un animal con esas caracteristicas");
                control++;
            }
            foreach (Animal ani in listaAnimales)
            {
                if (ani.Nombre.Equals(a.Nombre))
                {
                    Console.WriteLine("Ya hay un animal registrado con ese nombre.");
                    control++;
                }
            }


            if (control == 0)
            {
                Console.WriteLine("Se ha añadido el Animal!");
                listaAnimales.Add(a);
            }
        }


        /**
	 * busca un animal por su nombre
	 */
        private void buscarAnimal()
        {
            if (listaAnimales.Count == 0)
            {
                Console.WriteLine("No hay animales ingresados.");
            }
            else {

                Console.WriteLine("Nombre de la mascota: ");
                String nombreAux = Console.ReadLine();
                Animal aBuscar = null;

                foreach (Animal a in listaAnimales)
                {
                    if (a.Nombre.ToUpper().Equals(nombreAux.ToUpper()))
                    {
                        aBuscar = a;
                    }
                }
                // Si se encuentra, lo muestra.
                if (aBuscar != null && listaAnimales.Contains(aBuscar))
                {

                    Console.WriteLine(aBuscar.ToString());

                }
                else {
                    Console.WriteLine("[ERROR]: Mascota no encontrada.");
                }
            }
        }

        /**
	 * Sustituira los comentarios por otro nuevo
	 */
        private void cambiarComentarios()
        {
            if (listaAnimales.Count == 0)
            {
                Console.WriteLine("No hay animales ingresados.");
            }
            else {

                Console.WriteLine("Nombre de la mascota: ");
                String nombreAux = Console.ReadLine();
                Animal aBuscar = null;
                foreach (Animal a in listaAnimales)
                {
                    if (a.Nombre.ToUpper().Equals(nombreAux.ToUpper()))
                    {
                        aBuscar = a;
                    }
                }
                // Si se encuentra, lo muestra.
                if (aBuscar != null && listaAnimales.Contains(aBuscar))
                {

                    String comentario;
                    Console.WriteLine("Introduzca el nuevo comentario:");
                    comentario = Console.ReadLine();
                    aBuscar.Comentarios = comentario;

                }
                else {
                    Console.WriteLine("[ERROR]: Mascota no encontrada.");
                }
            }
        }


        public override string ToString()
        {
            string tiendaAnimales2 = "";
            foreach(Animal ani in listaAnimales)
            {
                tiendaAnimales2 += ani.ToString() + "\n";
            }

            return "ClinicaVeterinaria [nombre=" + _nombre + "\n listaAnimales=" + tiendaAnimales2
                + "]";
        }





        //LEER FLOAT

        public static double LeerDouble()
        {

            string entrada = "";
            double num = 0;
            bool error = false;

            do
            {
                Console.WriteLine("Introduzca numero:");

                entrada = Console.ReadLine();
                error = double.TryParse(entrada, out num);
                if (!error)
                    Console.WriteLine("Error no has introducido un numero");

            } while (!error);
            return num;
        }

        //LEER INT
        public static int LeerEntero()
        {
            string entrada = "";
            int entero = 0;
            bool error = false;

            do
            {
                Console.WriteLine("Introduzca numero:");

                entrada = Console.ReadLine();
                error = Int32.TryParse(entrada, out entero);
                if (!error)
                    Console.WriteLine("Error no has introducido un numero");

            } while (!error);
            return entero;
        }

        //GENERA ARRAY DE ENTEROS ALEATORIOS POR SI SE QUIERE USAR PARA EL CHIP
        public static int[] RellenaArray(int[] array)
        {
            Random r = new Random();
            for (int f = 0; f < array.Length; f++)
            {
                array[f] = (r.Next(1, 100));
            }
            return array;
        }
    }
}


