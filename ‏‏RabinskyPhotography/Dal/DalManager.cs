using Dal.DalApi;
using Dal.Dalimplementaion;
using Dal.Do;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
        public IDalCustomer Customer { get; set; }
        public IDalPhotographer Photographer { get; set; }
        public IDalPrice Price { get; set; }
        public DalManager() 
        {
            ServiceCollection service = new ServiceCollection();

            service.AddSingleton<PhotographyContext>();
            service.AddScoped<IDalPrice, DalPriceServise>();
            service.AddScoped<IDalPhotographer , DalPhotographerServise>();
            service.AddScoped <IDalCustomer,DalCustomerServise>();

            ServiceProvider serviceProvider = service.BuildServiceProvider();

            Customer=serviceProvider.GetRequiredService<IDalCustomer>();
            Photographer = serviceProvider.GetRequiredService<IDalPhotographer>();
            Price= serviceProvider.GetRequiredService<IDalPrice>();
        }


    }
}
