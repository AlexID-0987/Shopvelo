using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Models
{
    public static class TestData
    {
        public static void Init(Bakecontext context)
        {
            if(!context.Bakes.Any())
            {
                context.Bakes.AddRange(
                    new Bake
                    {
                        Model="Trassa",
                        Name="Comanche",
                        Color="Yellow",
                        Price=13.456,
                        Foto= "https://velopark.com.ua/wa-data/public/shop/products/18/11/1118/images/308/308.750@2x.jpg",
                        DateTime =System.DateTime.Now
                        
                    },
                    new Bake
                    {
                        Model = "City",
                        Name = "Comanche",
                        Color = "Black",
                        Price = 12.452,
                        Foto= "https://velomarket.org.ua/wa-data/public/shop/products/03/26/2603/images/2624/2624.970.jpg",
                        DateTime=System.DateTime.Now
                        
                    },
                    new Bake
                    {
                        Model = "Trassa",
                        Name = "Azimyt",
                        Color = "Yellow",
                        Price = 10.216,
                        Foto= "https://velotime.com.ua/wa-data/public/shop/products/39/23/2339/images/4554/4554.970.jpg",
                        DateTime=System.DateTime.Now
                    },
                    new Bake
                    {
                        Model = "Aist",
                        Name = "Aist",
                        Color = "Yellow",
                        Price = 7.456,
                        Foto= "https://kupi.bike/upload/iblock/6ad/6ad9dd266bcfefa56cf152b0bb984641.jpg",
                        DateTime=System.DateTime.Now
                        
                    }

                    );
                context.SaveChanges();
            }
        }
    }
    
}
