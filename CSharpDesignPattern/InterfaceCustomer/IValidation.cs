namespace InterfaceCustomer
{
    //Design Pattern :- Strategy Pattern
    //This is a behavioural design pattern which helps to select
    //algorithms on runtime.
    public interface IValidation<AnyType>
    {
        void Validate(AnyType type);
    }
}
