Kata.Solution(10); 

public static class Kata
{
    public static int Solution(int value)
    {
        var sum = 0;

        if (value < 0)
            return sum;

        for (var count = 0; count < value; count++)
        {
            if (count % 3 == 0 || count % 5 == 0)
                sum += count;
        }

        return sum;
    }
}

