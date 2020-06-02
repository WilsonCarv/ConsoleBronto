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
using ConsoleBronto.Utils;

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
             string _ClassName = "Console Bronto";
            try
            {
                BrontoResult ObjBrontoJazz = new BrontoResult();
                ObjBrontoJazz = new GenericHttpJson().PostEventResponse <BrontoResult, BrontoResult>(ObjBrontoJazz, "https://localhost:44346/api/Bronto/UnfundedProcessJazz ", " ");
                Console.WriteLine("=========================Jazz SportsBook=======================");
                Console.WriteLine(ObjBrontoJazz.ToString());
                Console.WriteLine("==========================ABC Islands==========================");
                BrontoResult ObjBrontoABC = new BrontoResult();
                ObjBrontoABC = new GenericHttpJson().PostEventResponse<BrontoResult, BrontoResult>(ObjBrontoABC, "https://localhost:44346/api/Bronto/UnfundedProcessABC ", " ");
                Console.WriteLine(ObjBrontoABC.ToString());
                Console.WriteLine("==========================Loose lines==========================");
                BrontoResult ObjBrontoLooseLines = new BrontoResult();
                ObjBrontoLooseLines = new GenericHttpJson().PostEventResponse<BrontoResult, BrontoResult>(ObjBrontoLooseLines, "https://localhost:44346/api/Bronto/UnfundedProcessLooseLines ", " ");
                Console.WriteLine(ObjBrontoLooseLines.ToString());
                Thread.Sleep(5000);
               
            }
            catch (Exception ex)
            {
                new LogError().LogErrors(_ClassName, System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(ex));
                throw ex;
            }
        }
    }
}
