namespace Praktikum2._3;

// Element ist eine generische Wrapper-Klasse, welche Vehicles kapseln
// kann.
// Verwenden Sie diese Klasse in ihrer Implementierung der verketteten
// Liste.
public class Element<T> where T : Vehicle
{
    private T obj;
    public Element<T> next;

    public T GetObj()
    {
        return obj;
    }

    public Element(T obj)
    {
        this.obj = obj;
        this.next = null;
    }
}

public abstract class Vehicle
{
    public Color VehicleColor { get; }

// Zum Speichern des Zulassungsdatums wird System.DateTime verwendet.
// Hinweis: Das Zeitformat, das in der Ausgabe erzeugt wird, erhalten
// Sie durch die Methode <DateTime-Objekt>.ToString("yyyy-M-d").
    public DateTime RegistrationDate { get; }

// Implementierung ersichtlich anhand der Ausgabe des Programms.
    public abstract string GetInfo();

    public Vehicle(Color color, DateTime date)
    {
        this.VehicleColor = color;
        this.RegistrationDate = date;
    }
    public static implicit operator String(Vehicle d) => d.GetInfo();
}

public class Car : Vehicle
{
    public Car(Color color, DateTime date) : base(color, date)
    {
    }

    public override string GetInfo()
    {
        return $"{VehicleColor} Car, Registration Date: {RegistrationDate.ToString("yyyy-M-d")}";
    }
    public static implicit operator string(Car d) => d.GetInfo();

}

public class Motorbike : Vehicle
{
    public Motorbike(Color color, DateTime date) : base(color, date)
    {
    }

    public override string GetInfo()
    {
        return $"{VehicleColor} Motorbike, Registration Date: {RegistrationDate.ToString("yyyy-M-d")}";
    }

}

