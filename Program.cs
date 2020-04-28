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
                List<PlayerDTO> PlayerList = new List<PlayerDTO>();
                PlayerDTO ObjPlayer = new PlayerDTO();
                int contador = 0;

                PlayerList =  new GenericHttpJson().PostEventResponse<List<PlayerDTO>, PlayerDTO> (ObjPlayer, "https://localhost:44346/api/Bronto/GetPlayers ", " ");

                foreach (var item in PlayerList)
                {
                    Console.WriteLine(item.ToString());
                    contador++;
                }
                Console.WriteLine("Total : " + contador);
                Thread.Sleep(50000000);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
