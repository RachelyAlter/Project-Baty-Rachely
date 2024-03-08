

namespace Bl.BlModels
{
    public class BLCustomer
    {
        public BLCustomer(string kalaName, string chatanName, string phone)
        {
            this.KalaName = kalaName;
            this.ChatanName = chatanName;
            this.Phone = phone;
            
        }
        public string KalaName { get; set; } = null!;

        public string ChatanName { get; set; } = null!;

        public string Phone { get; set; } = null!;

    }
}
