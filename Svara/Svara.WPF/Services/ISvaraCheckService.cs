using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Services
{
    public interface ISvaraCheckService
    {

        void AddSvara(int bet);

        void Delete(int id);

        int GetBet();

        bool IsHaveSvara();

    }
}
