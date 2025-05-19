public static class MysteryStack1
{
    public static string Run(string text)
    {
        var stack = new Stack<char>(); //new character array from text
        foreach (var letter in text)
            stack.Push(letter); // push each letter in stack // racecar

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}

// 