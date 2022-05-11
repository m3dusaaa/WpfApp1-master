using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Tour
    {
        [Table("tour")]
        public class Tour : BaseDTO
        {
            [Column("country")]
            public string Country { get; set; }
            [Column("city")]
            public string City { get; set; }
            [Column("order_num")]
            public int NomerZakaza { get; set; }
            [Column("time")]
            public string Dlitelnost { get; set; }
            [Column("summa")]
            public string Price { get; set; }
            [Column("hotel")]
            public DateTime hotel { get; set; }
            [Column("idoperator")]
            public int IDOperator { get; set; }
        }
    }
}