using System.ComponentModel.DataAnnotations;

namespace EthicsWebApp.Models
{
    // Named as such beccause C# has a system.Attribute and it caused errors 
    public class EthicAttribute
    {
        [Key]
        public int AttrID { get; set; }
        // Type is either 0, Num, Mod
        public required string  Type { get; set; }
        // Data on 0 is null, Data on Num is a Number data on mod is a modifier
        public string? Data { get; set; }

    }
}
