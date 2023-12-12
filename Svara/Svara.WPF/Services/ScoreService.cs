using Svara.WPF.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Services
{
    public class ScoreService : IScoreService
    {
        private readonly List<BaseCard> cards;


        public ScoreService(List<BaseCard> cards)
        {
            this.cards = cards;
        }


        public int MakeScore()
        {

            BaseCard firstCard = this.cards[0];
            BaseCard secondCard = this.cards[1];
            BaseCard thirdCard = this.cards[2];


            if (firstCard.Name == secondCard.Name && secondCard.Name == thirdCard.Name)
            {

                if ((firstCard.Name == "Seven") && (firstCard.Type == "Spatia" || secondCard.Type == "Spatia" || thirdCard.Type == "Spatia"))
                {
                    return 34;
                }
                else if (firstCard.Name == "Seven")
                {
                    return 30;
                }


                return firstCard.Points + secondCard.Points + thirdCard.Points;
            }

            int sum = 0;

            if ((firstCard.Name == "Seven" && firstCard.Type == "Spatia" && secondCard.Type == thirdCard.Type) || (secondCard.Name == "Seven" && secondCard.Type == "Spatia" && firstCard.Type == thirdCard.Type) || (thirdCard.Type == "Spatia" && thirdCard.Name == "Seven" && firstCard.Type == secondCard.Type))
            {
                return firstCard.Points + secondCard.Points + thirdCard.Points;
            }

            if ((firstCard.Name == "Seven" && firstCard.Type == "Spatia" && secondCard.Name == thirdCard.Name) || (secondCard.Name == "Seven" && secondCard.Type == "Spatia" && firstCard.Name == thirdCard.Name) || (thirdCard.Name == "Seven" && thirdCard.Type == "Spatia" && firstCard.Name == secondCard.Name))
            {
                return firstCard.Points + secondCard.Points + thirdCard.Points;
            }



            if ((firstCard.Name == "Aso" && secondCard.Name == "Aso") || (secondCard.Name == "Aso" && thirdCard.Name == "Aso") || (firstCard.Name == "Aso" && thirdCard.Name == "Aso"))
            {
                return 22;
            }

            if ((firstCard.Name == "Seven" && secondCard.Name == "Seven") || (secondCard.Name == "Seven" && thirdCard.Name == "Seven") || (firstCard.Name == "Seven" && thirdCard.Name == "Seven"))
            {
                return 23;
            }


            if ((firstCard.Name == "Seven" && firstCard.Type == "Spatia") || (secondCard.Name == "Seven" && secondCard.Type == "Spatia") || (thirdCard.Name == "Seven" && thirdCard.Type == "Spatia"))
            {
                sum = BiggestNumber();
            }
            else if (firstCard.Type == secondCard.Type && secondCard.Type == thirdCard.Type)
            {
                sum = firstCard.Points + secondCard.Points + thirdCard.Points;
            }
            else if (firstCard.Type == secondCard.Type && thirdCard.Type != secondCard.Type)
            {
                sum = firstCard.Points + secondCard.Points;
            }
            else if (firstCard.Type == thirdCard.Type && firstCard.Type != secondCard.Type)
            {
                sum = firstCard.Points + thirdCard.Points;
            }
            else if (secondCard.Type == thirdCard.Type && thirdCard.Type != firstCard.Type)
            {
                sum = secondCard.Points + thirdCard.Points;
            }
            else
            {
                sum = BiggestNumber();
            }


            return sum;
        }

        private int BiggestNumber()
        {

            int sum = 0;
            BaseCard firstCard = this.cards[0];
            BaseCard secondCard = this.cards[1];
            BaseCard thirdCard = this.cards[2];

            if (firstCard.Name == "Seven" && firstCard.Type == "Spatia")
            {
                if (secondCard.Points >= thirdCard.Points)
                {
                    return firstCard.Points + secondCard.Points;
                }
                else
                {
                    return firstCard.Points + thirdCard.Points;
                }
            }
            else if (secondCard.Name == "Seven" && secondCard.Type == "Spatia")
            {
                if (firstCard.Points >= thirdCard.Points)
                {
                    return firstCard.Points + secondCard.Points;
                }
                else
                {
                    return secondCard.Points + thirdCard.Points;
                }
            }
            else if (thirdCard.Name == "Seven" && thirdCard.Type == "Spatia")
            {
                if (secondCard.Points >= firstCard.Points)
                {
                    return secondCard.Points + thirdCard.Points;
                }
                else
                {
                    return firstCard.Points + thirdCard.Points;
                }
            }

            if (firstCard.Points >= secondCard.Points && thirdCard.Points <= firstCard.Points)
            {
                sum = firstCard.Points;
            }
            else if (thirdCard.Points >= firstCard.Points && thirdCard.Points >= secondCard.Points)
            {
                sum = thirdCard.Points;
            }
            else
            {
                sum = secondCard.Points;
            }
            return sum;
        }
    }
}
