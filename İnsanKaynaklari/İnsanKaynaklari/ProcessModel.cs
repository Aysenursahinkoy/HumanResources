using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
     class ProcessModel
    {
        private int _process_Id;
        private int _user_Id;
        private int _per_Id;
        private string _process;
        private DateTime _date;
        private string explanation;

        public int Process_Id { get => _process_Id; set => _process_Id = value; }
        public int User_Id { get => _user_Id; set => _user_Id = value; }
        public int Per_Id { get => _per_Id; set => _per_Id = value; }
        public string Process { get => _process; set => _process = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Explanation { get => explanation; set => explanation = value; }
    }
}
