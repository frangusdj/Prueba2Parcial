﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Producto
    {
        private string codigo, descripcion;
        private float precio;

        //Contructor
        public Producto(string codigo, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
        }


        //Metodos Set
        public void SetCodigo(string ncodigo)
        {
            codigo = ncodigo;
        }

        public void SetDescripcion(string ndescripcion)
        {
            descripcion = ndescripcion;
        }

        public void SetPrecio(float nprecio)
        {
            precio = nprecio;
        }

        //Metodos Get

        public string GetCodigo()
        {
            return codigo;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
        public float GetPrecio()
        {
            return precio;
        }


        //Leer
        public void Leer()
        {
        string ncodigo, ndescripcion;
        float nprecio;
            Console.WriteLine("Ingrese el codigo del producto");
            ncodigo = Console.ReadLine();

            Console.WriteLine("Ingrese la descripcion del producto");
            ndescripcion = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto");
            nprecio = (float)Convert.ToDouble(Console.ReadLine());

            SetCodigo(ncodigo);
            SetDescripcion(ndescripcion);
            SetPrecio(nprecio);
        }

        //Imprimir
        public void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("Codigo de Producto:" + GetCodigo());
            Console.WriteLine("Descripcion de Producto:" + GetDescripcion());
            Console.WriteLine("Precio de Producto:" + GetPrecio());
        }
    }
}
