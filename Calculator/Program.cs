using Calculator;

var operations = new Operations();
//Console.WriteLine("Add {0}", operations.Add(1, 1));
//Console.WriteLine("Subtract {0}", operations.Subtract(1, 1));
//Console.WriteLine("Multiply {0}", operations.Multiply(1, 1));
//Console.WriteLine("Divide {0}", operations.Divide(1, 2));

Exec(Operator.Add,      1, 1);
Exec(Operator.Subtract, 1, 1);
Exec(Operator.Multiply, 1, 1);
Exec(Operator.Divide,   1, 2);

void Exec(Operator op, int a, int b)
{

    var result = op switch
    {
        Operator.Subtract => operations.Subtract(a, b),
        Operator.Multiply => operations.Multiply(a, b),
        Operator.Divide => operations.Divide(a, b),
        _ => operations.Add(a, b),
    };
    var pad = 10 - op.ToString().Length;
    Console.WriteLine(" {1} {0} {2} is {3}", op, a, b.ToString().PadRight(pad,' '), result);
}
enum Operator
{
    Add, Subtract, Multiply, Divide
}
