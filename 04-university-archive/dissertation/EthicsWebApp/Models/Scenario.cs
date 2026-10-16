using System.ComponentModel.DataAnnotations;

namespace EthicsWebApp.Models
{
    public class Scenario
    {
        // This needs improvment Mostly in how varibles are stored, Theres a few options
        // but all of which are are lot of hassle and dont seem like a good option
        [Key]
        public int SceID { get; set; }
        public required string Background { get; set; }
        public int? Var1 { get; set; }
        public int? Var2 { get; set; }

        public int? Attr1 { get; set; }
        public int? Attr2 { get; set; }

        // This is required for the Scaffoled Views
        public Scenario()
        {

        }

        // This is so the program can assign a Problem background
        [System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
        public Scenario(String bg)
        {
            Background = bg;
        }

        public override string? ToString()
        {
            String output = "";
            if (Background.Equals("Trolley"))
            {
                output = "A train is hurtling down a track towards a group of people, its brakes having failed. " +
                "It reaches a junction controlled by a lever. You are standing by the lever and have the option of pulling the " +
                "lever, killing {Var1} or letting the train pass, killing {Var2}";
            }
            return output;
        }
    }
}
