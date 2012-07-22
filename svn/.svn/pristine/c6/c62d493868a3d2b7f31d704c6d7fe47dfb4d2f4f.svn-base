using System.ComponentModel.DataAnnotations;
using EasySoft.Helper;

namespace RecruiterGrid.DataLogic.Attributes
{
    public class Percent : DataTypeAttribute
    {
        public override bool IsValid(object value)
        {
            int percent = value.ToInteger(true);
            if (percent <= 100 && percent >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Percent()
            : base("double")
        {

        }
    }
}
