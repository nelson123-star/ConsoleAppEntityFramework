using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Models
{
    public class Payment : Entities
    {
        public int ID { get; set; }
        //public string ChatId { get; set; }
        public decimal Sum{ get; set; }
        public string Command { get; set; }
    }
}
