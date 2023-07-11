using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Model
{
    public interface IValidator
    {
        string PreValidation();

        bool PostValidation();

        bool AccetableRange();

    }
    public class Validator : IValidator
    {
        public string PreValidation()
        {
            throw new NotImplementedException();
        }

        public bool PostValidation()
        {
            throw new NotImplementedException();
        }

        public bool AccetableRange()
        {
            throw new NotImplementedException();
        }
    }
}
