using Orleans;

namespace Grains
{
    public interface IFloorGrain : IGrainWithIntegerKey
    {
        Task<float> GetOccupancy();
        Task Locate(string parkingSpaceId);
    }
}