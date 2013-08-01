using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var facade = new Facade())
            {

                //var category = facade.AddCategory("test");
                
                //var product = facade.AddProduct(category.Id, 30, "test1");
                
                //var sale = facade.CreateOTCSale(new Guid("80a94d23-780e-4fa6-a907-2a83373388a3"), new Guid("376b44b3-2235-4bf8-b560-ed085692b30d"),new Guid("8511fbff-63d8-411b-aa62-3696fb7d7a70"));
                //var sli = facade.AddSaleLineItem(new Guid("80a94d23-780e-4fa6-a907-2a83373388a3"), new Guid("376b44b3-2235-4bf8-b560-ed085692b30d"),sale.Id, new Guid("82fc4620-68c4-4084-b2ec-6629be19caeb"));
                //Console.ReadKey();
            }
           
        
          
        }
    }
}
