using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class ValeKupa: BaseCard
    {
        public ValeKupa()
        {
            this.Name = "Vale";
            this.Type = "Kupa";
            this.Points = 10;
            this.ImagePath = "/Images/valekupa.png";
        }
    }
}
