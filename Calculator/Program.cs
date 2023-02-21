using Calculator;

Tokenizer tokenizer = new Tokenizer();
// 12 +( 3418*34)+ 2324826 ^   43
while (true)
{
    Console.WriteLine("Enter equation: ");
    var input = Console.ReadLine();
    var tokenized = tokenizer.Tokenize(input);
    for (int i = 0; i < tokenized.Count(); i++)
    {
        Console.WriteLine(tokenized.GetAt(i));
    }
    Console.WriteLine("");
} 