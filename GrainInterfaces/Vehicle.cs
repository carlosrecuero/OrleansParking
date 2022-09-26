using Orleans.Concurrency;

namespace GrainInterfaces
{
    [Immutable]
    public record Vehicle(string LicencePlateNumber);
}
