using System.ComponentModel.DataAnnotations;

namespace EthicsWebApp.Models
{
    public class Variable
    {
        [Key]
        public int VarID { get; set; }
        
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public int? Score { get; set; }

        public override string? ToString()
        {
            return this.Name;
        }
    }

}
