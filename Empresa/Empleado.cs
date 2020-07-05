using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa{
    class Empleado{
        private string nomb, ape, cod;
        private double sueldo;
        //Constructor por defecto
        public Empleado() {
            setNomb("");
            setApe("");
            setCod("");
            setSueldo(0);
        }
        //Métodos setter
        public void setNomb(string n) {
            this.nomb = n;
        }
        public void setApe(string a) {
            this.ape = a;
        }
        public void setCod(string c) {
            this.cod = c;
        }
        public void setSueldo(double s) {
            this.sueldo = s;
        }
        //Métodos getter
        public string getNomb() {
            return this.nomb;
        }
        public string getApe() {
            return this.ape;
        }
        public string getCod() {
            return this.cod;
        }
        public double getSueldo() {
            return this.sueldo;
        }
        //Método para leer
        public void Leer() {
            Console.WriteLine("Ingrese el nombre del empleado");
            setNomb(Console.ReadLine());
            Console.WriteLine("Ingrese el apellido del empleado");
            setApe(Console.ReadLine());
            Console.WriteLine("Ingrese el código del empleado");
            setCod(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo del empleado");
            setSueldo(Convert.ToDouble(Console.ReadLine()));
        }
        //Métodos para mostrar
        public void Mostrar() {
            Console.WriteLine("Nombre: "+getNomb()
                +"\nApellido: "+getApe()+"\nCódigo: "+getCod()
                +"\nSueldo: "+getSueldo());
        }
    }
}
