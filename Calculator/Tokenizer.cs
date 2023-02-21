namespace Calculator;

public class Tokenizer
{
    public KSEList Tokenize(string line)
    {
        KSEList kseList = new KSEList();
        KSEList kseListFinal = new KSEList();

        string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
        string[] operators = {"+", "-", "*", "/", "^", "(", ")"};
    
        for (int i = 0; i < line.Length; i++)
        {
            var element = line[i].ToString();
            if (element == " ")
            {
                continue;
            }
            else
            {
                kseList.Add(element);
            }
        }

        string currNum = "";
        for (int i = 0; i < kseList.Count(); i++)
        {
            if (numbers.Contains(kseList.GetAt(i)))
            {
                currNum += kseList.GetAt(i);
            }
            else if (operators.Contains((kseList.GetAt(i))))
            {
                if (currNum != "")
                {
                    kseListFinal.Add(currNum);
                }
                kseListFinal.Add(kseList.GetAt(i));
                currNum = "";
            }
        
        }

        if (currNum != "")
        {
            kseListFinal.Add(currNum);
        }
        return kseListFinal;
    }
}