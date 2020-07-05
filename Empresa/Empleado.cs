using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa{
    class Empleado{
        private string nomb, ape, cod;
        private double sueldo;

        Producto[] productos;

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
    }
}
