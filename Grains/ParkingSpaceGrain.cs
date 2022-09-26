using Orleans;

namespace Grains
{
    public class ParkingSpaceGrain : Grain, IParkingSpaceGrain
    {
        private bool _isOccupied {get;set;}
        public Task Take()
        {
            _isOccupied = true;
            return Task.CompletedTask;
        }

        public Task Free()
        {
            _isOccupied = false;
            return Task.CompletedTask;
        }

        public Task<bool> IsOccupied() => Task.FromResult(_isOccupied);
    }
}
