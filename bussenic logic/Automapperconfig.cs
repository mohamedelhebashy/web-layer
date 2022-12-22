using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using model_layer;
namespace bussenic_logic
{

   public class Automapperconfig
    {
        public static IMapper mapper;
        public static void init()
        {
            var cnnfig = new MapperConfiguration(cnf =>
            {
                cnf.CreateMap<Products, ProductVm>()

                .ForMember(dst => dst.ID, src => src.MapFrom(e => e.ProductID))
                .ForMember(dst => dst.Name, src => src.MapFrom(e => e.ProductName))
                .ForMember(dst => dst.CatID, src => src.MapFrom(e => e.CategoryID))
                .ForMember(dst => dst.CatName, src => src.MapFrom(e => e.Categories.CategoryName))
                .ReverseMap();


            });
            mapper = cnnfig.CreateMapper();


        }
       
    }
}
