using System.Collections;

namespace DSA;

public sealed class DArray<T> : IEnumerable<T>
{
    private T[] arr;
    private int length; // length user thinks array is
    private int capacity; // Actual array size

    public DArray() : this(16)
    { }

    public DArray(int capacity)
    {
        if (capacity < 0) throw new ArgumentException($"Illegal Capacity: {capacity}");
        this.capacity = capacity;
        arr = new T[capacity];
    }

    public int Size() => length;
    public bool IsEmpty => Size() == 0;

    public T Get(int index) => arr[index];

    // Should this be bound checked?
    public void Set(int index, T elem) => arr[index] = elem;

    public void Clear()
    {
        for (int i = 0; i < capacity; i++)
        {
            arr[i] = default;
        }

        length = 0;
    }

    public void Add(T elem)
    {
        // Time to resize!
        if (length + 1 >= capacity)
        {
            if (capacity == 0) capacity = 1;
            else capacity *= 2; // Double the size

            T[] newArray = new T[capacity];

            // Copy values to a new array
            for (int i = 0; i < length; i++)
            {
                newArray[i] = arr[i];
            }

            arr = newArray;
        }

        arr[length++] = elem;
    }

    public T RemoveAt(int rm_index)
    {
        if (rm_index >= length || rm_index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(rm_index), "Index out of range.");
        }

        T removedItem = arr[rm_index];
        T[] new_arr = new T[length - 1];

        for (int i = 0, j = 0; i < length; i++)
        {
            if (i == rm_index) continue;
            new_arr[j++] = arr[i];
        }

        arr = new_arr;
        capacity = --length;
        return removedItem;
    }

    public bool Remove(T elem)
    {
        for (int i = 0; i < length; i++)
        {
            if (Equals(arr[i], elem))
            {
                RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public int IndexOf(T elem)
    {
        for (int i = 0; i < length; i++)
        {
            if (Equals(arr[i], elem))
            {
                return i;
            }
        }
        return -1;
    }

    public bool Contains(T elem) => IndexOf(elem) != -1;

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < length; i++)
        {
            yield return arr[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}