using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtBilgiSistemi.Entity
{
    public class Payment
    {
        public int StudentNo { get; set; }
        public int PaymentNo { get; set; }
        public string Name { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal RemainPaid { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime Date { get; set; }
    }
}
