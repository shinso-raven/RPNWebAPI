using Optional;
using RPNCalculator;
using WebapiCalculator.Models;

namespace WebapiCalculator.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("20 5 /", "4")]
    [TestCase("20 5 +", "25")]
    [TestCase("20 5 -", "15")]
    [TestCase("20 5 *", "100")]
    [TestCase("100 5 /", "20")]
    [TestCase("20 4 / ", "5")]
    public void Calculator_solves_basic_Operations(string input, string expectResult)
    {
        CalcultatorRPN _calculator = new CalcultatorRPN();


        string result = _calculator.Calculate(input);




        Assert.That(result, Is.EqualTo(expectResult));
    }
}