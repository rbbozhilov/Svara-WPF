using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class DamaKaro : BaseCard
    {
        public DamaKaro()
        {
            this.Name = "Dama";
            this.Type = "Karo";
            this.Points = 10;
            this.ImagePath = "/Images/damakaro.png";
        }
    }
}
