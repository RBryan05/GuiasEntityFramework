using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public NorthwindEntities contexto = new NorthwindEntities();
        public List<Customers> ObtenerTodos()
        {
            var clientes = from customer in contexto.Customers
                           select customer;

            return clientes.ToList();
        }

        public Customers ClientePorID(string id)
        {
            var resultado = new Customers();
            var customer = from cliente in contexto.Customers
                          where cliente.CustomerID == id
                          select cliente;

            foreach (var i in customer) 
            {
                resultado.CustomerID = i.CustomerID;
                resultado.ContactTitle = i.ContactTitle;
                resultado.Address = i.Address;
                resultado.ContactName = i.ContactName;
                resultado.CompanyName = i.CompanyName;
            }

            return resultado;
        }
    }
}
