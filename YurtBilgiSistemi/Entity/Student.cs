using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtBilgiSistemi.Entity
{
    public class Student:Person
    {
        public string RoomType { get; set; }
        public int RoomNo { get; set; }
        public string Term { get; set; }
        public bool Breakfast { get; set; }
        public bool Dinner { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public Double RemainingPayment { get; set; }
        public string GuardianName { get; set; }
        public string GuardianPhone { get; set; }
        public string CardNo { get; set; }
    }
}
