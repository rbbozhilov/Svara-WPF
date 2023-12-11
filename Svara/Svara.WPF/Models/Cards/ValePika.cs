using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class ValePika: BaseCard
    {
        public ValePika()
        {
            this.Name = "Vale";
            this.Type = "Pika";
            this.Points = 10;
            this.ImagePath = "/Images/valepika.png";
        }
    }
}
