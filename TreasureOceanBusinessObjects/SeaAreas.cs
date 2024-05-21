using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureOceanBusinessObjects
{
    public class SeaAreas
    {
        private int seaID;
        private string seaName;
        private int treasure;
        private int countryID;
        private int probability;
        private int fee;
        private DateTime startDate;
        private DateTime expiryDate;

        public SeaAreas() { }

        public SeaAreas(int seaID, string seaName, int treasure, int probability, int fee, DateTime startDate, DateTime expiryDate, int countryID)
        {
            this.seaID = seaID;
            this.seaName = seaName;
            this.treasure = treasure;
            this.probability = probability;
            this.fee = fee;
            this.startDate = startDate;
            this.expiryDate = expiryDate;
            this.countryID = countryID;
        }


        public int SeaID { get => seaID; set => seaID = value; }
        public string SeaName { get => seaName; set => seaName = value; }
        public int Treasure { get => treasure; set => treasure = value; }
        public int Probability { get => probability; set => probability = value; }
        public int Fee { get => fee; set => fee = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public int CountryID { get => countryID; set => countryID = value; }
    }
}
