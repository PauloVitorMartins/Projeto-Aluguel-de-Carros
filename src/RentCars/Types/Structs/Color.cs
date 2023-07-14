namespace RentCars.Types;

//1 - Crie uma `Struct` para as **Cores**
public struct Color
{
    public string Name { get; set; }
    public string Hex { get; set; }

    public Color(string name, string hex)
    {
        this.Name = name;
        this.Hex = hex;
    }
}