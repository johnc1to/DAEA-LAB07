using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
namespace Business
{
    public class BProduct
    {

        public List<Product> GetByName(string Name)
        {
            List<Product> result = new List<Product>();
            DProduct data=new DProduct();

            //Obtengo todos los productos
            var products = data.Get();
            //filtro por nombre
            foreach (var item in products) {
                if (item.Name == Name)
                {
                    result.Add(item);
                }
            }
            return null;
        }
    }
}
