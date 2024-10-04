using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAllByCategoryId(2))
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }






            Console.Read();
        }
    }
}
