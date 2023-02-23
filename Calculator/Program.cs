using Calculator;

Tokenizer tokenizer = new Tokenizer();
Notation notation = new Notation();
Calculations calculator = new Calculations();

// 2+2^4+3+(3-1)*3^2 = 39

while (true)
{
    Console.WriteLine("Enter equation: ");
    var input = Console.ReadLine();
    var tokenized = tokenizer.Tokenize(input);
    var post = notation.InfixToPostfix(tokenized);
    for(int i = 0; i < post.Count(); i++)
    {
        Console.Write(post.GetAt(i));
    }
    Console.WriteLine("");
    calculator.Calculate(post);

    // calculator.Calculate(notation.InfixToPostfix(tokenizer.Tokenize(input)));
    Console.WriteLine("");
} 