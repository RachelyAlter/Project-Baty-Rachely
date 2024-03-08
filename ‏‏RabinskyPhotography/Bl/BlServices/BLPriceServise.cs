

namespace Bl.BlServices
{
    public class BLPriceServise : IBLPrice
    {
        IDalPrice dalManager;
        Conversion conversion;
        //PhotographerProfile mapper;
        public BLPriceServise(/* PhotographerProfile mapper,*/DalManager dalManager)
        {
            this.dalManager = dalManager.Price;
            this.conversion = new();
            //this.mapper = mapper;
        }

        public List<BLPrice> GetAll()
        {
            {
                List<Price> dalAllPrice = dalManager.GetAll();
                List<BLPrice> blAllPrice = new List<BLPrice>();
                for (int i = 0; i < dalAllPrice.Count(); i++)
                {
                    blAllPrice.Add(new BLPrice(dalAllPrice[i].PriceFor320Photos, dalAllPrice[i].PriceForAnAdditionalHourBeyond7Hours, dalAllPrice[i].PriceForAnAdditionalHourAfter1Am));
                }
                return blAllPrice;
            }
        }

        public BLPrice Get(int id)
        {
            return conversion.PriceConversion(dalManager.Get(id));
        }

        public BLPrice Post(BLPrice t)
        {
            throw new NotImplementedException();
        }

        public BLPrice Put(int id)
        {
            throw new NotImplementedException();
        }

        public BLPrice Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
