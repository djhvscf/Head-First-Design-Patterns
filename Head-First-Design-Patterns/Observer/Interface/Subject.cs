
namespace Head_First_Design_Patterns.ObserverInterfaces
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }
}
