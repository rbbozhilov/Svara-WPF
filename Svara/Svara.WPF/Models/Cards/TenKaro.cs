using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class TenKaro: BaseCard
    {
        public TenKaro()
        {
            this.Name = "Ten";
            this.Type = "Karo";
            this.Points = 10;
            this.ImagePath = "/Images/tenkaro.png";
        }
    }
}
