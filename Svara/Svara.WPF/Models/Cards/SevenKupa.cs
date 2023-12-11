using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class SevenKupa: BaseCard
    {
        public SevenKupa()
        {
            this.Name = "Seven";
            this.Type = "Kupa";
            this.Points = 7;
            this.ImagePath = "/Images/sevenkupa.png";
        }
    }
}
