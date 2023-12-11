using Svara.WPF.Models;
using Svara.WPF.Models.Svara;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Services
{
    public class SvaraCheckService : ISvaraCheckService
    {

        private SvaraDbContext db;

        public SvaraCheckService()
        {
            this.db = new SvaraDbContext();
        }

        public void AddSvara(int bet)
        {
            this.db.SvaraChecks.Add(new SvaraCheck() { Bet = bet, IsSvara = true });

            this.db.SaveChanges();
        }

        public void Delete(int bet)
        {
            var svara = this.db.SvaraChecks.Where(x => x.Bet == bet).FirstOrDefault();

            if(svara == null)
            {
                return;
            }

            this.db.SvaraChecks.Remove(svara);
            this.db.SaveChanges();
        }

        public int GetBet()
        => this.db.SvaraChecks.Where(x => x.IsSvara == true).Select(x => x.Bet).FirstOrDefault();

        public bool IsHaveSvara()
        => this.db.SvaraChecks.Any(x => x.IsSvara == true);
    }
}
