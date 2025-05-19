/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param> 
    public void Enqueue(Person person)
    {
        ///Insert creates a LIFO(stack) behaviour, not a FIFO(queue) 
        // _queue.Insert(0, person); <-- fixed issue
        _queue.Add(person); // in a queue context .Add() works like Enqueue()
    }

    public Person Dequeue()
    {
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}