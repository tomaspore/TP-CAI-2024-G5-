using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoWS
            {
            Guid _id;
            Guid _idcategoria;
            string _nombre;
            DateTime _fechaalta;
            DateTime _fechabaja;
            double _precio;
            int _stock;


            public ProductoWS(Guid id, Guid idCategoria, string nombre, DateTime fechaalta, DateTime fechabaja, double precio,int stock)
            {
                Id = id;
                IdCategoria = idCategoria;
                Nombre = nombre;
                FechaAlta = fechaalta;
                FechaBaja = fechabaja;
                Precio = precio;
                Stock = stock;
            }

            public Guid Id { get => _id; set => _id = value; }
            public Guid IdCategoria { get => _idcategoria; set => _idcategoria = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public DateTime FechaAlta { get => _fechaalta; set => _fechaalta = value; }
            public DateTime FechaBaja { get => _fechabaja; set => _fechabaja = value; }
            public double Precio { get => _precio; set => _precio = value; }
            public int Stock { get => _stock; set => _stock = value; }
            }
    }

