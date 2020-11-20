// ReSharper disable UnusedMemberInSuper.Global
namespace Modulos.Messaging
{
    public interface IFreezable
    {
        void Freeze();
        bool IsFrozen { get; }
    }
}