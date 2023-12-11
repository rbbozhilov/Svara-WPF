using Svara.WPF.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Services
{
    public interface IDeckService
    {

        BaseCard GetCard();

        List<BaseCard> StirringDeck();

    }
}
