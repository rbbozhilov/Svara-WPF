using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models.Cards
{
    public abstract class BaseCard
    {


        public string Name { get; set; }

        public string Type { get; set; }

        public string ImagePath { get; set; }

        public int Points { get; set; }

    }
}
