namespace Calculator;

public class Notation
{
    public KSEList InfixToPostfix(KSEList tokens)
    {
        Dictionary<string, int> precedence = new Dictionary<string, int>
        {
            {"+", 1},
            {"-", 1},
            {"*", 2},
            {"/", 2},
            {"^", 3} 
        };
        KSEStack stack = new KSEStack();
        KSEList output = new KSEList();
        for(int i = 0; i < tokens.Count(); i++)
        {
            if (int.TryParse(tokens.GetAt(i), out int num))
            {
                output.Add(tokens.GetAt(i));
            }
            else if (precedence.ContainsKey(tokens.GetAt(i)))
            {
                while (stack.ViewTop() != null && precedence.ContainsKey(stack.ViewTop()) && precedence[tokens.GetAt(i)] <= precedence[stack.ViewTop()])
                {
                    output.Add(stack.Pull());
                }
                stack.Push(tokens.GetAt(i));
            }
            else if (tokens.GetAt(i) == "(")
            {
                stack.Push(tokens.GetAt(i));
            }
            else if (tokens.GetAt(i) == ")")
            {
                while (stack.ViewTop() != null && stack.ViewTop() != "(")
                {
                    output.Add(stack.Pull());
                }
                if (stack.ViewTop() != null && stack.ViewTop() == "(")
                {
                    stack.Pull();
                }
            else if (tokens.GetAt(i) == "^")
            {
                stack.Push(tokens.GetAt(i));
            }  
            }
        }
        while (stack.ViewTop() != null)
        {
            output.Add(stack.Pull());
        }
        return output;
    }
}