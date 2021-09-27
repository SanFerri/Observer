namespace Observer
{
    public interface ISubject<T>
    {
        void Unsubscribe(IObserver<T> observer);
        void Subscribe(IObserver<T> observer);
    }
    
}