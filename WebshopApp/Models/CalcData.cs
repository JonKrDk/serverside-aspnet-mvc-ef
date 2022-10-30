using System.ComponentModel.DataAnnotations;

namespace WebshopApp.Models
{
    public class CalcData
    {
        public int OperandA { get; set; }
        public int OperandB { get; set; }

        [Range(1, 20, ErrorMessage = "Arh, det mener du vist ikke!")]
        public int Result   { get; set; }

        public string Description { get; set; }
    }
}
