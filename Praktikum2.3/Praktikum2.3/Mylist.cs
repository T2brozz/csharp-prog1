using System.Collections;
using System.Reflection.Metadata;

namespace Praktikum2._3;

public enum Color
{
    Red,
    Green,
    Blue,
    Black
}

public interface IMyList<T> : IEnumerable where T : Vehicle
{
// Fügt ein Element absteigend sortiert nach dem Zulassungsdatum in
// die verkettete Liste ein. Verwenden Sie die CompareTo()-Methode um // einen DateTime Wert mit einem anderen zu
// vergleichen. Fahrzeuge mit identischem Zulassungsdatum sind hinter // den bereits existierenden Fahrzeugen einzufügen.
    void Add(T newValue);

//Löscht alle Elemente einer bestimmten Farbe aus der verketteten
// Liste. Die Methode gibt die Anzahl der gelöschten Fahrzeuge zurück.
// Sollten keine Fahrzeuge einer übergebenen Farbe in der Liste sein, wird eine ColorNotFound-Exception geworfen. Diese ist von Ihnen zu implementieren.
    int Remove(Color id);
}

class MyList<T> : IMyList<T> where T : Vehicle

{
    private Element first = null;


    public void Add(T newValue)
    {
        if (first == null)
        {
            first = new Element(newValue, null);
        }
        else if (first.value.RegistrationDate.CompareTo(newValue.RegistrationDate) < 0)
        {
            Element temp = new Element(newValue, first);
            first = temp;
        }
        
        else
        {
            Element current = first;
            Element previous = first;
            while (current != null)
            {
                if (current.value.RegistrationDate.CompareTo(newValue.RegistrationDate) < 0)
                {
                    Element temp = new Element(newValue, current);
                    if (previous != current)
                    {
                        previous.next = temp;
                    }
                

                    return;
                }

                previous = current;
                current = current.next;
            }

            
            previous.next = new Element(newValue, null);
        }
    }

    public int Remove(Color id)
    {
        //remove all elements with the same color
        int counter = 0;//TODO
        Element current = first;
      
        while (current.next != null )
        {
            if (first.value.VehicleColor == id)
            {
                first = first.next;
            }
            else if (current.next.value.VehicleColor == id)
            {
                counter++;
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return counter;
    }

    public IEnumerator GetEnumerator()
    {
        return new Enum(first);
    }
}

class Enum : IEnumerator
{
    Element current;
    Element head;

    public Enum(Element head)
    {
        this.head = head;
    }

    public object Current
    {
        get { return current.value.GetInfo(); }
    }

    public bool MoveNext()
    {
        if (current == null)
        {
            current = head;
            return true;
        }

        if (current.next == null)
        {
            return false;
        }

        current = current.next;
        return true;
    }

    public void Reset()
    {
        current = null;
    }
}

public class Element
{
    public Vehicle value;
    public Element next;

    public Element(Vehicle value, Element next)
    {
        this.value = value;
        this.next = next;
    }
}