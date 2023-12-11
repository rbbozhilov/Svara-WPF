using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models
{
    public class Card
    {

        public Card(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
