using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureOceanBusinessObjects;

namespace TreasureOceanRepository
{
    public interface ISeaAreasRepository
    {
        void CreateSeaAreas(SeaAreas seaAreas);
        void UpdateSeaAreas(SeaAreas seaAreas);
        void DeleteSeaAreas(int seaAreasId);
        SeaAreas GetSeaAreas(int seaAreaId);
        List<SeaAreas> GetAllSeaAreas();
    }
}
