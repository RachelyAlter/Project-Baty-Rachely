

namespace Bl.BlServices
{
    public class BLCustomerServise : IBLCustomer
    {
        IDalCustomer dalManager;
        Conversion conversion;
        public BLCustomerServise(DalManager dalManager)
        {
            this.dalManager = dalManager.Customer;
            conversion = new Conversion();
        }

        public List<BLCustomer> GetAll()
        {
            List<Customer> dalAllCustomers= dalManager.GetAll();
            List<BLCustomer> blAllCustomers=new List<BLCustomer>();
            for (int i = 0; i < dalAllCustomers.Count(); i++)
            {
                blAllCustomers.Add(new BLCustomer(dalAllCustomers[i].KalaName, dalAllCustomers[i].ChatanName, dalAllCustomers[i].Phone));
            }
            return blAllCustomers;
        }

        public BLCustomer Get(int id)
        {
            return conversion.CustomerConversion(dalManager.Get(id));
        }


        public BLCustomer Post(BLCustomer t)
        {
            throw new NotImplementedException();
        }

        public BLCustomer Put(int id)
        {
            throw new NotImplementedException();
        }
        public BLCustomer Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
