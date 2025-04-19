namespace Grind75;

public static class ValidParentheses
{
    public static bool StackApproach(string s)
    {

        // {[()]}
        // {}[]()

        Stack<char> stack = new();

        foreach (var c in s)
        {
            if (c == '(')
                stack.Push(')');
            else if (c == '{')
                stack.Push('}');
            else if (c == '[')
                stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }

        return stack.Count == 0;
    }


    public static bool StackApproach1(string s)
    {

        // {[()]}
        // {}[]()

        Dictionary<char, char> mapping = new()
        {
            [')'] = '(',
            ['}'] = '{',
            [']'] = '['
        };

        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (!mapping.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    char popped = stack.Pop();
                    if (popped != mapping[c])
                    {
                        return false;
                    }
                }
            }
        }

        return stack.Count == 0;
    }

}
