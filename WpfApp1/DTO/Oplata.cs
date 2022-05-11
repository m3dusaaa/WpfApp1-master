using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Oplata
    {
        [Column("datazakaza")]
        public DateTime Zakaza { get; set; }
        [Column("client_id")]
        public string idclient { get; set; }
        [Column("order_num")]
        public int NomerZakaza { get; set; }
        [Column("summa")]
        public string Price { get; set; }
        [Column("idoperator")]
        public int IDOperator { get; set; }
    }
}
