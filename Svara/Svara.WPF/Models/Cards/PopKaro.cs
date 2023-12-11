using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class PopKaro: BaseCard
    {
        public PopKaro()
        {
            this.Name = "Pop";
            this.Type = "Karo";
            this.Points = 10;
            this.ImagePath = "/Images/popkaro.png";
        }
    }
}
