using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class SevenKaro: BaseCard
    {
        public SevenKaro()
        {
            this.Name = "Seven";
            this.Type = "Karo";
            this.Points = 7;
            this.ImagePath = "/Images/sevenkaro.png";
        }
    }
}
