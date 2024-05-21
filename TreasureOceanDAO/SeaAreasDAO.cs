using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;

namespace TreasureOceanDAO
{
    public class SeaAreasDAO
    {
        private List<SeaAreas> _seaAreas;
        public SeaAreasDAO() 
        {
            if(this._seaAreas == null)
            {
                _seaAreas = new List<SeaAreas>();
                _seaAreas.Add(new SeaAreas(1, "Bournemouth", 1500, 60, 1000000, new DateTime(2024, 1, 1), new DateTime(2034, 1, 1), 1));
                _seaAreas.Add(new SeaAreas(2, "Biarritz", 3500, 80, 3000000, new DateTime(2025, 2, 2), new DateTime(2030, 2, 2), 2));
                _seaAreas.Add(new SeaAreas(3, "Phuket", 1000, 40, 500000, new DateTime(2023, 3, 3), new DateTime(2033, 3, 3), 3));
                _seaAreas.Add(new SeaAreas(4, "Miyako", 500, 20, 10000, new DateTime(2023, 4, 4), new DateTime(2043, 4, 4), 5));
                _seaAreas.Add(new SeaAreas(5, "Amami", 700, 70, 20000, new DateTime(2025, 5, 5), new DateTime(2055, 5, 5), 5));
            }
        }
        public void AddSeaArea(SeaAreas seaAreas)
        {
            _seaAreas.Add(seaAreas);
        }
        public List<SeaAreas> GetSeaAreas() {  return _seaAreas; }
        public SeaAreas GetSeaArea(int seaAreaID) { return _seaAreas.FirstOrDefault(p => p.SeaID.Equals(seaAreaID)); }
        public void UpdateSeaArea(SeaAreas seaAreas)
        {
            for(int i = 0; i < _seaAreas.Count; i++)
            {
                if (_seaAreas[i].SeaID.Equals(seaAreas.SeaID))
                {
                    _seaAreas[i].SeaName = seaAreas.SeaName;
                    _seaAreas[i].Fee = seaAreas.Fee;
                    _seaAreas[i].Treasure = seaAreas.Treasure;
                    _seaAreas[i].CountryID = seaAreas.CountryID;
                }
            }
        }

        public void DeleteSeaArea(int seaAreaID)
        {
            for(int i = 0; i < _seaAreas.Count; i++)
            {
                if (_seaAreas[i].SeaID.Equals(seaAreaID))
                {
                    _seaAreas.RemoveAt(i);
                }
            }
        }

    }
}
