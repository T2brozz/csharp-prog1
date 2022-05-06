namespace uebung5;

public class linkedlist
{
    public node tail = null;
    public node head = null;
        
    
    public node add(int val)
    {
        if (tail == null)
        {
            head=tail=new node(val);
            return tail;
        }
        else
        {
            node tmp = new node(val, null, null);
            head.next = tmp;
            tmp.prev = head;
            head = tmp;
            return head;
        }
        
    }
}

public class node
{
    public node prev;
    public node next;
    public int val;

    public node(int val, node prev = null, node next = null)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}