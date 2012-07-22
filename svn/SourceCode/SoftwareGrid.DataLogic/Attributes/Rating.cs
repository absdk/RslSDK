using System.ComponentModel.DataAnnotations;
using EasySoft.Helper;

namespace RecruiterGrid.DataLogic.Attributes
{
    public class Rating : DataTypeAttribute
    {
        public override bool IsValid(object value)
        {
            int rating = value.ToInteger(true);
            if (rating <= 5 && rating >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Rating()
            : base("double")
        {

        }
    }
}
