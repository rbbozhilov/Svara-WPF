using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class ValeKaro : BaseCard
    {
        public ValeKaro()
        {
            this.Name = "Vale";
            this.Type = "Karo";
            this.Points = 10;
            this.ImagePath = "/Images/valekaro.png";
        }
    }
}
