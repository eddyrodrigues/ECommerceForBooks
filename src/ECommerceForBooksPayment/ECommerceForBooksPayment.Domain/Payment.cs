using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceForBooksPayment.Domain
{
    internal class Payment
    {
        public Payment() { }
        public int Id { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; } = string.Empty;
        public string CartId { get; set; }
    }
}
