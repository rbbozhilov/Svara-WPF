using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class NineKaro : BaseCard
    {
        public NineKaro()
        {
            this.Name = "Nine";
            this.Type = "Karo";
            this.Points = 9;
            this.ImagePath = "/Images/ninekaro.png";
        }
    }
}
