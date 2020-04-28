using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBronto.Models
{
    public class PlayerDTO
    {
        public int IdPlayer { set; get; }
        public string Player { set; get; }
        public string Email { set; get; }
        public DateTime AccountOpened { set; get; }
        public decimal CurrentBalance { set; get; }
        public decimal Days { set; get; }

        public override string ToString()
        {
            return $"IdPlayer: {IdPlayer} ,Player: {Player} ,Email: {Email} ,AccountOpened: {AccountOpened},CurrentBalance: {CurrentBalance} , Days: {Days}   ";
        }
    }
}
