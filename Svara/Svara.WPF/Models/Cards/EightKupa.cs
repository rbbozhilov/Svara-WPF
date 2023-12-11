using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class EightKupa: BaseCard
    {

        public EightKupa()
        {
            this.Name = "Eight";
            this.Type = "Kupa";
            this.Points = 8;
            this.ImagePath = "/Images/eightkupa.png";
        }
    }
}
