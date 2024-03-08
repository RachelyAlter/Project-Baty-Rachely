

namespace Bl.BlModels
{
    public class BLPrice
    {
        public BLPrice(int priceFor320Photos, int priceForAnAdditionalHourBeyond7Hours, int priceForAnAdditionalHourAfter1Am/*, ICollection<BLPhotographer> photographers*/)
        {
            //this.Photographers = photographers;
            this.PriceFor320Photos = priceFor320Photos;
            this.PriceForAnAdditionalHourBeyond7Hours = priceForAnAdditionalHourBeyond7Hours;
            this.PriceForAnAdditionalHourAfter1Am= priceForAnAdditionalHourAfter1Am;
        }
        public int PriceFor320Photos { get; set; }

        public int PriceForAnAdditionalHourBeyond7Hours { get; set; }

        public int PriceForAnAdditionalHourAfter1Am { get; set; }

        //public virtual ICollection<BLPhotographer> Photographers { get; set; } 

    }
}
