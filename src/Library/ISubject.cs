namespace Observer
{
    public interface ISubject
    {
        void Unsubscribe(ISubject observer);
        void Subscribe(ISubject observer);
        void GetTemperature();  
    }
    
}