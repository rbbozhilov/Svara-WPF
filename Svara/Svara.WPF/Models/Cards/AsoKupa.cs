using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class AsoKupa : BaseCard
    {

        public AsoKupa()
        {
            this.Name = "Aso";
            this.Type = "Kupa";
            this.Points = 11;
            this.ImagePath = "/Images/asokupa.png";
        }


    }
}
