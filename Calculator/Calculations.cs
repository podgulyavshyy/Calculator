namespace Calculator;

public class Calculations
{
    public void Calculate(KSEList input)
    {
        KSEStack calcStack = new KSEStack();
        for (int i = 0; i < input.Count(); i++)
        {
            if (input.GetAt(i).All(char.IsDigit))
            {
                calcStack.Push(input.GetAt(i));
            }
            else
            {
                int b = Int32.Parse(calcStack.Pull());
                int a = Int32.Parse(calcStack.Pull());
                int result = 0;
                if (input.GetAt(i) == "+")
                {
                    result = a + b;
                }
                if (input.GetAt(i) == "-")
                {
                    result = a - b;
                }
                if (input.GetAt(i) == "*")
                {
                    result = a * b;
                }
                if (input.GetAt(i) == "/")
                {
                    result = a / b;
                }
                if (input.GetAt(i) == "^")
                {
                    double ap = Convert.ToDouble(a);
                    double bp = Convert.ToDouble(b);
                    double temp = 0;
                    temp = Math.Pow(ap, bp);
                    result = Convert.ToInt32(temp);
                }
                calcStack.Push(result.ToString());
            }
        }
        Console.WriteLine(calcStack.Pull());
    }
}