

public class ListInt
{
    private int[] array;
    private int count;

    public ListInt(int size)
    {
        array = new int[size];
        count = 0;
    }


    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < count)
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        set
        {
            if (index >= 0 && index < count)
            {
                array[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
    }


    public void Add(int num)
    {
        if (count < array.Length)
        {
            array[count++] = num;
        }
        else
        {
            throw new InvalidOperationException("Array is full");
        }
    }


    public void AddRange(params int[] nums)
    {
        foreach (var num in nums)
        {
            Add(num);
        }
    }


    public bool Contains(int num)
    {
        for (int i = 0; i < count; i++)
        {
            if (array[i] == num)
            {
                return true;
            }
        }
        return false;
    }
    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += array[i];
        }
        return sum;
    }



    public bool Remove(int num)
    {
        int index = Array.IndexOf(array, num, 0, count);
        if (index >= 0)
        {
            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[--count] = 0;
            return true;
        }
        return false;
    }


    public void RemoveRange(params int[] nums)
    {
        foreach (var num in nums)
        {
            Remove(num);
        }
    }


    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(array[i]);

            if (i < count - 1)
            {
                sb.Append(", ");
            }
        }

        return sb.ToString();
    }

}
