using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
     class OvertimeModel
    {
        private int _overtime_Id;
        private int _per_Id;
        private string _start_date;
        private string _end_date;
        private decimal _hourly_wage;
        private decimal _amount;
        private string _payment_status;
        private string _explanation;
        private DateTime date;
        private string period;
        private string payment_status;

        public int Overtime_Id { get => _overtime_Id; set => _overtime_Id = value; }
        public int Per_Id { get => _per_Id; set => _per_Id = value; }
        public string Start_date { get => _start_date; set => _start_date = value; }
        public string End_date { get => _end_date; set => _end_date = value; }
        public decimal Hourly_wage { get => _hourly_wage; set => _hourly_wage = value; }
        public decimal Amount { get => _amount; set => _amount = value; }
        public string Payment_status { get => _payment_status; set => _payment_status = value; }
        public string Explanation { get => _explanation; set => _explanation = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Period { get => period; set => period = value; }
      

       
    }
}
