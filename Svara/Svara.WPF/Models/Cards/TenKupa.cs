using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class TenKupa: BaseCard
    {
        public TenKupa()
        {
            this.Name = "Ten";
            this.Type = "Kupa";
            this.Points = 10;
            this.ImagePath = "/Images/tenkupa.png";
        }
    }
}
