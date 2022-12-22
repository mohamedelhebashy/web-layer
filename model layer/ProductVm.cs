using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_layer
{
   public class ProductVm
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CatID { get; set; }
       
        public string CatName { get; set; }
    }
}
