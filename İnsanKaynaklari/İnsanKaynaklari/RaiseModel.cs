using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
     class RaiseModel
    {
        private int _raise_Id;
        private int _user_Id;
        private int _per_Id;
        private decimal _amount;
        private string _payment_status;
        private string process;
        private DateTime date;

        public int Raise_Id { get => _raise_Id; set => _raise_Id = value; }
        public int User_Id { get => _user_Id; set => _user_Id = value; }
        public int Per_Id { get => _per_Id; set => _per_Id = value; }
      
        public string Payment_status { get => _payment_status; set => _payment_status = value; }
        public string Process { get => process; set => process = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Amount { get => _amount; set => _amount = value; }
    }
}
