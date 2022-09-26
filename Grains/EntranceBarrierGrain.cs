using GrainsInterfaces;
using Orleans;

namespace Grains
{
    public class EntranceBarrierGrain : Grain, IEntranceBarrierGrain
    {
        public Task Lock()
        {
            return Task.CompletedTask;
        }

        public Task Unlock()
        { 
            return Task.CompletedTask; 
        }

        public Task Lift(string licencePlateNumber)
        {
            return Task.CompletedTask;
        }
    }
}
