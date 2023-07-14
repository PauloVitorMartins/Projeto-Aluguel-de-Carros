using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        this.Vehicle = vehicle;
        this.Person = person;
        this.Status = RentStatus.Confirmed;
        this.DaysRented = daysRented;
        vehicle.IsRented = true;
        if (person.GetType() == typeof(PhysicalPerson))
            Price = vehicle.PricePerDay * daysRented;
        else
            Price = (vehicle.PricePerDay * daysRented) / 0.90;
        person.Debit = Price;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        this.Status = RentStatus.Canceled;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        this.Status = RentStatus.Finished;
    }
}