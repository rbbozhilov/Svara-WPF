using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models
{
    public class Player
    {

        public Player()
        {
            this.FirstPlayerCards = new List<Card>();
            this.SecondPlayerCards = new List<Card>();
        }

        public List<Card> FirstPlayerCards { get; set; }

        public List<Card> SecondPlayerCards { get; set; }


    }
}
