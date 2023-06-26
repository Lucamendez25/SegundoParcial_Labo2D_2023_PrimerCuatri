using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClasesCarniceria
{
    public enum eTipoProducto
    {
        CarnePollo = 0,
        CarneRes = 1,
        Variedad = 2
    }
    public class Producto
    {
        string codigoProducto;
        string nombre;
        eTipoProducto tipo;
        double valorPorKilo;
        double stock;
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public eTipoProducto Tipo { get => tipo; set => tipo = value; }
        public double ValorPorKilo { get => valorPorKilo; set => valorPorKilo = value; }
        public string ImagenProducto { get; set; }
        public double Stock { get => stock; set => stock = value; }

        public Producto(string nombre, eTipoProducto tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public Producto(string codigoProducto, string nombre, eTipoProducto tipo, double valorPorKilo) : this(nombre, tipo)
        {
            this.codigoProducto = codigoProducto;
            this.valorPorKilo = valorPorKilo;
        }

        public bool VerificoQueHayaStock(Producto producto, double peso) 
        {
            if (producto.Stock > peso) 
            {
                return true;
            }
            return false;
        }
    }
}