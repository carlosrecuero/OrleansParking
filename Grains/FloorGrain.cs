using GrainsInterfaces;
using Orleans;

namespace Grains
{
    public class FloorGrain : Grain, IFloorGrain
    {
        private readonly List<string> _parkingSpaceIds = new();

        public Task Locate(string parkingSpaceId)
        {
            _parkingSpaceIds.Add(parkingSpaceId);
            return Task.CompletedTask;
        }

        public Task<float> GetOccupancy()
        {
            var totalSpaces = _parkingSpaceIds.Count;
            var occupiedSpaces = 0;
            foreach (var parkingSpaceId in _parkingSpaceIds)
            {
                var parkingSpace = GrainFactory.GetGrain<IParkingSpaceGrain>(parkingSpaceId);
                if (parkingSpace.IsOccupied())
                {
                    occupiedSpaces++;
                }
            }
            var occupancy = totalSpaces > 0 ?
                occupiedSpaces / totalSpaces :
                1.0f;
            return Task.FromResult(occupancy);
        }
    }
}
