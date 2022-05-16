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
    void Add(T newElement);

//Löscht alle Elemente einer bestimmten Farbe aus der verketteten
// Liste. Die Methode gibt die Anzahl der gelöschten Fahrzeuge zurück.
// Sollten keine Fahrzeuge einer übergebenen Farbe in der Liste sein, wird eine ColorNotFound-Exception geworfen. Diese ist von Ihnen zu implementieren.
    int Remove(Color id);
}

class MyList<T> : IMyList<T> where T : Vehicle

{
    private Element first = null;
    

    public void Add(T newElement)
    {
        if (first == null)
        {
            first = new Element(newElement, null);
        }
        else
        {
            Element current = first;
            while (current.next != null)
            {
                if (current.value.RegistrationDate.CompareTo(newElement.RegistrationDate) == -1)
                {
                    break;
                }
                current = current.next;
            }
            if (current.next == null)
            {
                current.next = new Element(newElement, null);
            }
            else
            {
                Element temp = current.next;
                current.next = new Element(newElement, temp);
            }
        }
    }

    public int Remove(Color id)
    {
        //remove all elements with the same color
        int counter = 0;
        Element current = first;
        while (current != null)
        {
            if (current.value.VehicleColor == id)
            {
                counter++;

                if (current == first)
                {
                    first = current.next;

                }
                else
                {
                    Element temp = current;
                    current = current.next;
                    temp.next = null;
                }
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
