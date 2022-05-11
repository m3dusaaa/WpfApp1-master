using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DTO
{
    internal class Client
    {
        [Table("client")]
        public class Client : BaseDTO
        {
            [Column("idclient")]
            public string IDClient { get; set; }
            [Column("clientFIO")]
            public string FIO { get; set; }
            [Column("birthday")]
            public DateTime Birthday { get; set; }
            [Column("idoperator")]
            public int OperatorId { get; set; }
        }
    }
}
