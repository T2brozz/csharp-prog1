using System.Collections;

namespace Übung08;

public class randNum :IEnumerable
{
    public int iter { get; set; }

    public randNum(int iter)
    {
        this.iter = iter;
    }

    public IEnumerator GetEnumerator()
    {
        Random num =new Random();
        //get iterations -1
        for (int i = 0; i < iter; i++)
        {
            //generate random number
            int rnd = num.Next(100);
            //yield return rnd
            yield return rnd;
        }
        
    }
}
public class randNumNoYield :IEnumerable
{
    public int iter { get; set; }

    public randNumNoYield(int iter)
    {
        this.iter = iter;
    }

    public IEnumerator GetEnumerator()
    {
        return new numEnum(this.iter);
    }
}
public class numEnum : IEnumerator
{
    int position = -1;
    private int iter;

    public numEnum(int iter)
    {
        this.iter = iter;
    }
    public bool MoveNext()
    {
        position++;
        return position < iter;
    }

    public void Reset()
    {
        position =-1;
    }

    
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public object Current
    {
        get
        {
            try
            {
                return new Random().Next(100);
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}