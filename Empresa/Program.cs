using System;
using System.Globalization;

namespace Empresa{
    class Program{
        static void Main(string[] args){
            string nEmpresa;
            int nEmp,op;
            Producto[] prod = new Producto[4];
            Console.WriteLine("Ingrese el nombre de la empresa");
            nEmpresa = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de empleados");
            nEmp = Convert.ToInt32(Console.ReadLine());
            Empleado[] empleados = new Empleado[nEmp];

            //Leemos los datos de los productos
            for (int i = 0; i < prod.Length; i++) {
                prod[i] = new Producto();
                prod[i].Leer();
            }
            //Leemos los datos de los empleados
            for (int j = 0; j < empleados.Length; j++) {
                empleados[j] = new Empleado();
                empleados[j].Leer();
            }
            //Calculamos la comision


            do {
                Console.WriteLine("Ingrese una de las siguientes opciones del menú");
                Console.WriteLine("(1) Para mostrar la información de los empleados"
                    +"\n(2) Para mostrar la información de los productos"
                    +"\n(3) Para salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case 1:
                        for (int i = 0; i < empleados.Length; i++) {
                            empleados[i].Mostrar();
                        }
                        break;
                    case 2:
                        for (int j = 0; j < prod.Length; j++) {
                            prod[j].Mostrar();
                        }
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion válida");
                        break;
                }
            } while (op != 3);
        }
    }
}
