using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtBilgiSistemi.Entity
{
    public class Salary
    {
        public int StaffNo { get; set; }
        public int SalaryNo { get; set; }
        public decimal SalaryAmount { get; set; }
        public DateTime Date { get; set; }
    }
}
