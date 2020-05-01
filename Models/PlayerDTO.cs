using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBronto.Models
{
    public class PlayerDTO
    {

        public int idPlayer { set; get; }
        public string email { set; get; }
        public string firstname { set; get; }
        public String birthday { set; get; }
        public string account { set; get; }
        public string last_login { set; get; }
        public string last_deposit { set; get; }
        public string last_wager { set; get; }
        public string acc_balance { set; get; }
        public string lastname { set; get; }
        public string phone_mobile { set; get; }
        public string US_state { set; get; }
        public string tier_level { set; get; }
        public decimal Days { set; get; }

        public override string ToString()
        {
            return $"IdPlayer: {idPlayer} ,Player: {account} ,Email: {email} ,Last Login: {last_login},CurrentBalance: {acc_balance} , Days: {Days}   ";
        }
    }
}
