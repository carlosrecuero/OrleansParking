using Orleans;

namespace GrainsInterfaces
{
    public interface IEntranceBarrierGrain: IGrainWithIntegerCompoundKey
    {
        Task Lock();
        Task Unlock();
        Task Lift(string licencePlateNumber);
    }
}