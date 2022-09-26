using Orleans;

namespace GrainsInterfaces
{
    public interface IParkingSpaceGrain : IGrainWithStringKey
    {
        Task Take();
        Task Free();
        Task<bool> IsOccupied();
    }
}