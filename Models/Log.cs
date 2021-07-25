using System.Data;
namespace ConsoleAppEntityFramework.Models
{
    public class Log : Entities
    {
        public int ID { get; set; }
        public string Command { get; set; }
        public System.DateTime DataTime { get; set; }
    }
}
