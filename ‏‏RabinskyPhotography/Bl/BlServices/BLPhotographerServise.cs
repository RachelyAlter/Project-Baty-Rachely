

namespace Bl.BlServices
{
    public class BLPhotographerServise : IBLPhotographer
    {
        IDalPhotographer dalManager;
        Conversion conversion;
        public BLPhotographerServise(DalManager dalManager)
        {
            this.dalManager = dalManager.Photographer;
            conversion = new Conversion();
        }


        public List<BLPhotographer> GetAll()
        {
            List<Photographer> dalAllPhotographer = dalManager.GetAll();
            List<BLPhotographer> blAllPhotographer = new List<BLPhotographer>();
            for (int i = 0; i < dalAllPhotographer.Count(); i++)
            {
                blAllPhotographer.Add(conversion.PhotographerConversion(dalAllPhotographer[i]));
            }
            return blAllPhotographer;
        }

        public BLPhotographer Get(int id)
        {
            return conversion.PhotographerConversion(dalManager.Get(id));
        }

        public BLPhotographer Post(BLPhotographer t)
        {
            throw new NotImplementedException();
        }

        public BLPhotographer Put(int id)
        {
            throw new NotImplementedException();
        }
        public BLPhotographer Delete(int id)
        {
            throw new NotImplementedException();
        }
       
    }
}
