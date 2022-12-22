using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model_layer;
using Data;
using AutoMapper;
namespace bussenic_logic
{
   public  interface Iproductlist
        {
         
    
        IEnumerable<ProductVm> Lict();
    }
    public class productlistBl : Iproductlist
    {
        private readonly IMapper m;
         
       public productlistBl()
        {
            Automapperconfig.init();
            m = Automapperconfig.mapper;
        }
        public IEnumerable<ProductVm> Lict()
        {
          
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var prods = db.Products.ToList();
             var prodlist=   m.Map<List<ProductVm>>(prods);
                return prodlist;
            }
        }
    }
}
