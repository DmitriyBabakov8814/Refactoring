using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public static class InterestCalculatorFactory
    {
        public static ITypeCalculate ReturnDependingOnType(string accountType)
        {
            return accountType switch
            {
                "Обычный" => new ClassicCalculateInterest(),
                "Зарплатный" => new SalaryCalculateInterest(),
                _ => throw new ArgumentException("Type not found")
            };
        }
    }
}
