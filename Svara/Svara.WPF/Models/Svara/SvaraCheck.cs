using System.ComponentModel.DataAnnotations;


namespace Svara.WPF.Models.Svara
{
    public class SvaraCheck
    {
        [Key]
        public int Id { get; set; }

        public int Bet { get; set; }

        public bool IsSvara { get; set; }
    }
}
