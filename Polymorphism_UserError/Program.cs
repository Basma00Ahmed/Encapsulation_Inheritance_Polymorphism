using System;
using System.Collections.Generic;

namespace Polymorphism_UserError
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericInputError Numeric_InputError = new NumericInputError();
            TextInputError Text_InputError = new TextInputError();
            
            EmptyInputError Empty_InputError = new EmptyInputError();
            ValidInputError Valid_InputError = new ValidInputError();
            MinimumInputError Minimum_InputError = new MinimumInputError();
          
            List<UserError> User_Error = new List<UserError> 
            { Numeric_InputError, Text_InputError, Empty_InputError, Valid_InputError, Minimum_InputError };
            foreach (var userError in User_Error)
            {
                Console.WriteLine(userError.UEMessage());
            }


        }
    }
}
