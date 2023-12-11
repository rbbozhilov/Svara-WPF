using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class EightKaro: BaseCard
    {
        public EightKaro()
        {
            this.Name = "Eight";
            this.Type = "Karo";
            this.Points = 8;
            this.ImagePath = "/Images/eightkaro.png";
        }
    }
}
