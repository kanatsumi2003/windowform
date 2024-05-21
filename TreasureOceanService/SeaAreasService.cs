using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;
using TreasureOceanRepository;

namespace TreasureOceanService
{
    public class SeaAreasService : ISeaAreaService
    {
        private readonly ISeaAreasRepository _seaAreasRepository;
        public SeaAreasService()
        {
            if(this._seaAreasRepository == null)
            {
                _seaAreasRepository = new SeaAreasRepository();
            }
        }
        public void CreateSeaAreas(SeaAreas seaAreas)
        {
            _seaAreasRepository.CreateSeaAreas(seaAreas);
        }

        public void DeleteSeaAreas(int seaAreasId)
        {
            _seaAreasRepository.DeleteSeaAreas(seaAreasId);
        }

        public List<SeaAreas> GetAllSeaAreas()
        {
            return _seaAreasRepository.GetAllSeaAreas();
        }

        public SeaAreas GetSeaAreas(int seaAreaId)
        {
            return _seaAreasRepository.GetSeaAreas(seaAreaId);
        }

        public void UpdateSeaAreas(SeaAreas seaAreas)
        {
            _seaAreasRepository.UpdateSeaAreas(seaAreas);
        }
    }
}
