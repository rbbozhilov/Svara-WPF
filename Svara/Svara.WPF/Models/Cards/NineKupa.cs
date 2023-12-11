using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class NineKupa: BaseCard
    {
        public NineKupa()
        {
            this.Name = "Nine";
            this.Type = "Kupa";
            this.Points = 9;
            this.ImagePath = "/Images/ninekupa.png";
        }
    }
}
