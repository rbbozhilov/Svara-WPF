using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class PopKupa: BaseCard
    {
        public PopKupa()
        {
            this.Name = "Pop";
            this.Type = "Kupa";
            this.Points = 10;
            this.ImagePath = "/Images/popkupa.png";
        }
    }
}
