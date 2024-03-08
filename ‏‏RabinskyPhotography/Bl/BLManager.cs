
namespace Bl
{
    public class BLManager
    {
        public IBLCustomer Customer { get; set; }
        public IBLPhotographer Photographer { get; set; }
        public IBLPrice Price { get; set; }

        public BLManager() {

            ServiceCollection service = new ServiceCollection();

            service.AddSingleton<DalManager>();
            service.AddScoped<IBLPrice, BLPriceServise>();
            service.AddScoped<IBLPhotographer, BLPhotographerServise>();
            service.AddScoped<IBLCustomer, BLCustomerServise>();

            ServiceProvider serviceProvider = service.BuildServiceProvider();

            Customer = serviceProvider.GetRequiredService<IBLCustomer>();
            Photographer = serviceProvider.GetRequiredService<IBLPhotographer>();
            Price = serviceProvider.GetRequiredService<IBLPrice>();
        }
    }
}
