using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class TenPika: BaseCard
    {
        public TenPika()
        {
            this.Name = "Ten";
            this.Type = "Pika";
            this.Points = 10;
            this.ImagePath = "/Images/tenpika.png";
        }
    }
}
