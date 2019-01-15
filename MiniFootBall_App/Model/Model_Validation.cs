using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootBall_App.Model
{
   public static class Model_Validation
    {
       public static Tuple<bool,List<ValidationResult>> Validate<T>(T item)
        {
            ValidationContext context = new ValidationContext(item);
            var list = new List<ValidationResult>();
            var result=Validator.TryValidateObject(item, context, list);

            return new Tuple<bool, List<ValidationResult>>(result, list);
        }
    }
}
