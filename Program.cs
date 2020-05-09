using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using ConsoleBronto.Models;
using WagerCoreWebAPI.Utils.Http;

namespace ConsoleBronto
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPlayers();
        }
        public static void GetPlayers()
        {
            try
            {
                List<BrontoResult> BrontoList = new List<BrontoResult>();
                BrontoResult ObjBronto = new BrontoResult();
                ObjBronto = new GenericHttpJson().PostEventResponse <BrontoResult, BrontoResult>(ObjBronto, "https://localhost:44346/api/Bronto/UpdateContactsData ", " ");

                Console.WriteLine(ObjBronto.ToString());
                Thread.Sleep(5000);
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
