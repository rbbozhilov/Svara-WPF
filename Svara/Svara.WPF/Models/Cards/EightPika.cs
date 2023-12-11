using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class EightPika: BaseCard
    {
        public EightPika()
        {
            this.Name = "Eight";
            this.Type = "Pika";
            this.Points = 8;
            this.ImagePath = "/Images/eightpika.png";
        }
    }
}
