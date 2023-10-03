using Calculator;

var operations = new Operations();

Exec(Operator.Add,      10, 2);
Exec(Operator.Subtract, 10, 2);
Exec(Operator.Multiply, 10, 2);
Exec(Operator.Divide,   10, 2);

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
