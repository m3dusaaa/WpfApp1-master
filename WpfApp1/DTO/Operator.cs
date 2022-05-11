    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Operator
    {
        [Table("operator")]
        public class Operator : BaseDTO
        {
            [Column("operatorFIO")]
            public string OperatorFIO { get; set; }
            [Column("phone")]
            public string PhoneNumber { get; set; }
            [Column("idoperator")]
            public int OperatorID { get; set; }
        }
    }
}


