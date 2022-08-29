using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
     class PermitModel:EmployeeModel
    {
        private int Id;
        private string permitType;

        public int Id1 { get => Id; set => Id = value; }
        public string PermitType { get => permitType; set => permitType = value; }
    }
}
