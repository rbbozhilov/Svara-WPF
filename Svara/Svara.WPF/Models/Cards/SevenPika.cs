using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class SevenPika : BaseCard
    {
        public SevenPika()
        {
            this.Name = "Seven";
            this.Type = "Pika";
            this.Points = 7;
            this.ImagePath = "/Images/sevenpika.png";
        }
    }
}
