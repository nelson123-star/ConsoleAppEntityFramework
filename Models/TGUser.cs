using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Models
{
    public class TGUser : Entities
    {
        public int ID { get; set; }
        //public long ChadID { get; set; }
        public string Name { get; set; }
    }
}
