using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;
using TreasureOceanDAO;

namespace TreasureOceanRepository
{
    public class SeaAreasRepository : ISeaAreasRepository
    {
        private SeaAreasDAO _seaAreasDAO;
        public SeaAreasRepository()
        {
            if(_seaAreasDAO == null)
            {
                _seaAreasDAO = new SeaAreasDAO();
            }
        }
        public void CreateSeaAreas(SeaAreas seaAreas)
        {
            _seaAreasDAO.AddSeaArea(seaAreas);
        }

        public void DeleteSeaAreas(int seaAreasId)
        {
            _seaAreasDAO.DeleteSeaArea(seaAreasId);
        }

        public List<SeaAreas> GetAllSeaAreas()
        {
            return _seaAreasDAO.GetSeaAreas();
        }

        public SeaAreas GetSeaAreas(int seaAreaId)
        {
            return _seaAreasDAO.GetSeaArea(seaAreaId);
        }

        public void UpdateSeaAreas(SeaAreas seaAreas)
        {
            _seaAreasDAO.UpdateSeaArea(seaAreas);
        }
    }
}
