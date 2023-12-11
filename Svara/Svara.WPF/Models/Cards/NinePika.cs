using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class NinePika : BaseCard
    {

        public NinePika()
        {
            this.Name = "Nine";
            this.Type = "Pika";
            this.Points = 9;
            this.ImagePath = "/Images/ninepika.png";
        }
    }
}
