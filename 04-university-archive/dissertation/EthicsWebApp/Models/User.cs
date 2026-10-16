using System.ComponentModel.DataAnnotations;

namespace EthicsWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public bool DidFinish { get; set; }

    }
}
