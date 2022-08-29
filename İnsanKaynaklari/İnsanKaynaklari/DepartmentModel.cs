using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
     class DepartmentModel
    {
        private string _dep_Id;
        private string _department;
        private string _explanation;

        public string Dep_Id { get => _dep_Id; set => _dep_Id = value; }
        public string Department { get => _department; set => _department = value; }
        public string Explanation { get => _explanation; set => _explanation = value; }
    }
}
