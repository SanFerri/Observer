namespace Observer
{
    public interface IObserver
    {
        void StartReporting(ISubject provider);
        void StopReporting();
        void Update(Temperature value);
    }
    
}