using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class PopPika: BaseCard
    {
        public PopPika()
        {
            this.Name = "Pop";
            this.Type = "Pika";
            this.Points = 10;
            this.ImagePath = "/Images/poppika.png";
        }
    }
}
