using Svara.WPF.Models.Cards;
using Svara.WPF.Services;
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

        private DeckService deck;
        private ScoreService scoreFirst;
        private ScoreService scoreSecond;

        public Players()
        {
            this.FirstPlayerCards = new List<BaseCard>();
            this.SecondPlayerCards = new List<BaseCard>();
            this.deck = new DeckService();
            this.AddCards();

            this.scoreFirst = new ScoreService(this.FirstPlayerCards);
            this.scoreSecond = new ScoreService(this.SecondPlayerCards);
        }


        public List<BaseCard> FirstPlayerCards { get; set; }

        public int ScoreFirstPlayer => this.scoreFirst.MakeScore();

        public List<BaseCard> SecondPlayerCards { get; set; }

        public int ScoreSecondPlayer => this.scoreSecond.MakeScore();

        public int FullBet { get; set; }

        public int OldBet { get; set; }

        public bool FirstPlayerTurn { get; set; } = true;

        public bool SecondPlayerTurn { get; set; } = false;


        private void ChangeTurn()
        {
            this.FirstPlayerTurn = false;
            this.SecondPlayerTurn = true;
        }



        private void AddCards()
        {
            this.deck.StirringDeck();

            this.FirstPlayerCards.Add(this.deck.GetCard());
            this.SecondPlayerCards.Add(this.deck.GetCard());
            this.FirstPlayerCards.Add(this.deck.GetCard());
            this.SecondPlayerCards.Add(this.deck.GetCard());
            this.FirstPlayerCards.Add(this.deck.GetCard());
            this.SecondPlayerCards.Add(this.deck.GetCard());
        }
    }
}
