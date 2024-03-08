

namespace Bl.BlServices
{
    internal class Conversion
    {
        public Conversion() { }

        public BLPrice PriceConversion(Price price)
        {
            return new BLPrice(price.PriceFor320Photos, price.PriceForAnAdditionalHourBeyond7Hours, price.PriceForAnAdditionalHourAfter1Am);

        }
        public BLPhotographer PhotographerConversion(Photographer photographer)
        {
            
            return new BLPhotographer(photographer.FirstName, photographer.LastName,PriceConversion(photographer.PriceCodeNavigation) );

        }
        public BLCustomer CustomerConversion(Customer customer)
        {

            return new BLCustomer(customer.KalaName, customer.ChatanName, customer.Phone);

        }

    }

}
