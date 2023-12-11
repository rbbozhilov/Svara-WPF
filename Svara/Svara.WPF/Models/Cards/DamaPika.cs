using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class DamaPika: BaseCard
    {
        public DamaPika()
        {
            this.Name = "Dama";
            this.Type = "Pika";
            this.Points = 10;
            this.ImagePath = "/Images/damapika.png";
        }
    }
}
