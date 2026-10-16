using System.ComponentModel.DataAnnotations;

namespace EthicsWebApp.Models
{
    public class Choice
    {
        [Key]
        public int ChoiceID { get; set; }
        public int UserID { get; set; }
        public int SenID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateDone { get; set; }
        public string? ChoiceMade { get; set; }

        public int Score { get; set; }
        //public NormativeEthicsFramework Framework { get; set; }

    }

}
