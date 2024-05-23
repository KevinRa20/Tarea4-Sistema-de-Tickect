using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Estructura_de_Datos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Usuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Usuario> colaUsuarios = new Queue<Usuario>();
            int opcion;

            do
            {
                Console.WriteLine("Sistema de Atención al Cliente");
                Console.WriteLine("1. Ingresar usuario a la Fila");
                Console.WriteLine("2. Atender usuario");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarUsuario(colaUsuarios);
                        break;
                    case 2:
                        AtenderUsuario(colaUsuarios);
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 3);
        }

        static void IngresarUsuario(Queue<Usuario> cola)
        {
            Console.Write("Ingrese el ID del cliente: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Usuario nuevoUsuario = new Usuario(id, nombre);
            cola.Enqueue(nuevoUsuario);

            Console.WriteLine("Usuario ingresado a la fila.");
        }

        static void AtenderUsuario(Queue<Usuario> cola)
        {
            if (cola.Count > 0)
            {
                Usuario usuarioAtendido = cola.Dequeue();
                Console.WriteLine($"Atendiendo al cliente: {usuarioAtendido}");
            }
            else
            {
                Console.WriteLine("No hay usuarios en la cola para atender.");
            }
        }
    }
}
        
       
     
    


