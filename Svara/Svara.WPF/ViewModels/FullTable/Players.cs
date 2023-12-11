using Svara.WPF.Models.Cards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.ViewModels.FullTable
{
    public class Players
    {

        public Players()
        {
            this.FirstPlayerCards = new List<BaseCard>();
            this.FirstPlayerCards.Add(new AsoKaro());
            this.FirstPlayerCards.Add(new AsoPika());
            this.FirstPlayerCards.Add(new AsoKupa());
        }


        public List<BaseCard> FirstPlayerCards { get; set; }

        public int ScoreFirstPlayer { get; set; }

        public List<BaseCard> SecondPlayerCards { get; set; }

        public int ScoreSecondPlayer { get; set; }




    }
}
