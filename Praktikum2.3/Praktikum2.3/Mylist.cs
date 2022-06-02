using System.Collections;


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
    public class Enum : IEnumerator 
    {
        Element<T>? current;
        Element<T>? head;

        public Enum(Element<T>? head)
        {
            this.head = head;
        }


        public object Current //return info of current element
        {
            get { return current.GetObj().GetInfo(); }
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

        public void Reset() //set current to null to start over
        {
            current = null;
        }
    }
    private Element<T>? first = default(Element<T>);


    public void Add(T newValue)
    {
        if (first == null)//add first element
        {
            first = new Element<T>(newValue);
        }
        else if (first.GetObj().RegistrationDate.CompareTo(newValue.RegistrationDate) < 0) //if newelements date is after first elements date add as new first element
        {
            Element<T> temp = new Element<T>(newValue);
            temp.next = first;
            first = temp;
        }

        else
        {
            Element<T> current = first;
            Element<T> previous = first;
            while (current != null) //loop to find correct place 
            {
                if (current.GetObj().RegistrationDate.CompareTo(newValue.RegistrationDate) < 0) // check if newvalue is younger than current 
                {
                    Element<T> temp = new Element<T>(newValue); // create new element 
                    temp.next = current;
                    if (previous != current) // add between previous and current 
                    {
                        previous.next = temp;
                    }


                    return;
                }

                previous = current;
                current = current.next;
            }


            previous.next = new Element<T>(newValue); // add element at the end of the list
        }
    }

    public int Remove(Color id)
    {
        //remove all elements with the same color
        int counter = 0; 
        Element<T> current = first;

        while (current.next != null) //loop through list
        {
            if (first.GetObj().VehicleColor == id) // check if first is has color
            {
                counter++;
                first = first.next;
            }
            else if (current.next.GetObj().VehicleColor == id) // check if current has color 
            {
                counter++; 
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        if (counter == 0)
        {
            throw new ColorNotFoundException();
        }

        return counter-1;
    }

    public IEnumerator GetEnumerator()
    {
        return new Enum(first);
    }
}

internal class ColorNotFoundException : Exception
{
}

