using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KillTrackerCS2
{
    internal class api
    {
        private WebClient client = new WebClient();
        private string endpoint = "http://localhost:80";
        public struct Stats
        {
            public Stats(string ranking,int kill, int assists, int deaths)
            {
                this.Ranking = ranking;
                this.assist = assists;
                this.kills = kill;
                this.deaths = deaths;
            }
            public string Ranking;
            public int kills;
            public int assist;
            public int deaths;
        }
        public void SubmitNewMatch(int kills, int assist, int deaths,int steamid)
        {
            client.DownloadString($"{endpoint}/api/Submit.php?k={kills}&a={assist}&d={deaths}&s={steamid}");
        }
        public Stats RetreiveStats(int steamid)
        {
            string reply = client.DownloadString($"{endpoint}/api/getstats.php?steamid={steamid}");
            string[] lines = reply.Split(new char[] { '\n' });
            if (lines.Length < 4)
                return new Stats("Unranked", 0, 0, 0);

            string rank = lines[0];
            int kills = int.Parse(lines[1]);
            int assists = int.Parse(lines[2]);
            int deaths = int.Parse(lines[3]);
            return new Stats(rank, kills, assists, deaths);
        }
        public bool IsCorrectServer()
        {
            return client.DownloadString($"{endpoint}/api/checkconn.php") == "ok";
        }
    }
}
