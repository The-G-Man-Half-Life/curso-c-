namespace OctvaClaseTarea.Models;

public class UsefulMath4
{
    public double Num1 {get; set;}
    public double Num2 {get; set;}


    public UsefulMath4(double Num1,double Num2)
    {
        this.Num1 = Num1;
        this.Num2 = Num2;
    }

    public void Operations()
    {
        Console.WriteLine(@$"
        Sum: {this.Num1 +this.Num2}
        Difference: {this.Num1 - this.Num2}
        multiplication: {this.Num1 * this.Num2}
        Division: {this.Num1/this.Num2}
        ");
    }
}
