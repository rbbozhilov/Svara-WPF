using Svara.WPF.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Services
{
    public class DeckService : IDeckService
    {

        private List<BaseCard> cards;

        public DeckService()
        {
            this.cards = new List<BaseCard>()
            {
                new AsoKupa(),
                new AsoPika(),
                new AsoKaro(),
                new AsoSpatia(),
                new TenKaro(),
                new TenPika(),
                new TenKupa(),
                new TenSpatia(),
                new NineKaro(),
                new NinePika(),
                new NineKupa(),
                new NineSpatia(),
                new EightKaro(),
                new EightKupa(),
                new EightPika(),
                new EightSpatia(),
                new SevenKaro(),
                new SevenKupa(),
                new SevenPika(),
                new SevenSpatia(),
                new ValeKaro(),
                new ValeKupa(),
                new ValePika(),
                new ValeSpatia(),
                new DamaPika(),
                new DamaKaro(),
                new DamaKupa(),
                new DamaSpatia(),
                new PopKaro(),
                new PopKupa(),
                new PopSpatia(),
                new PopPika(),
            };

        }


        public List<BaseCard> Cards => cards;

        public List<BaseCard> StirringDeck()
        {

            Random rng = new Random();

            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                BaseCard value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
            return this.cards;
        }

        public BaseCard GetCard()
        {

            BaseCard currentCard = this.cards[0];
            this.cards.Remove(currentCard);

            return currentCard;
        }
    }
}
