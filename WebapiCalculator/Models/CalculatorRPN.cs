
using Optional;
using RPNCalculator;

namespace WebapiCalculator.Models
{

    public class CalcultatorRPN
    {

        public string Calculate(string input)
        {

            Option<RpnNotation, string> rpn = RpnNotation.From(input);

            RpnCalculation requestCalculation = new RpnCalculation(rpn);

            string result = requestCalculation.ResultOrError();

            return result;
        }
    }

}
