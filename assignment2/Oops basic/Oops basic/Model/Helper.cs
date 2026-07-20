using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_basic.Model
{
    internal class Helper
    {
        internal static bool IsChoiceValid(string inputChoice)
        {
            if(string.IsNullOrEmpty(inputChoice) || string.IsNullOrWhiteSpace(inputChoice) || inputChoice.Length!=1 || !inputChoice.All(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal static bool IsColorValid(string color)
        {
            return Enum.IsDefined(typeof(System.Drawing.KnownColor), color);
        }

        internal static bool IsDimensionValid(string? DimensionInput)
        {
            if (string.IsNullOrWhiteSpace (DimensionInput)||string.IsNullOrEmpty(DimensionInput))
            {
                return false;
            }
            else if (!double.TryParse(DimensionInput, out double length) || length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
