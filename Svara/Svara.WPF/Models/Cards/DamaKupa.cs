using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public class DamaKupa : BaseCard
    {

        public DamaKupa()
        {
            this.Name = "Dama";
            this.Type = "Kupa";
            this.Points = 10;
            this.ImagePath = "/Images/damakupa.png";
        }
    }
}
