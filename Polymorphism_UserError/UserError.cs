using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_UserError
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }
    public class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field. This fired an error!";
    }
    public class TextInputError : UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numericonly field. This fired an error!";
    }
    public class EmptyInputError : UserError
    {
        public override string UEMessage() => "You must write value. This fired an error!";
    }
    public class ValidInputError : UserError
    {
        public override string UEMessage() => "You must enter a valid number. This fired an error!";
    }
    public class MinimumInputError : UserError
    {
        public override string UEMessage() => "You must enter at least three letters. This fired an error!";
    }
    ////11 Q: Help in use the same interface in different classes "define one interface and  have multiple implementations"
    ///
    ///12 Q: Reduce code redundancy, easy to maintain code, unify code behavior
    ///
    ///13 Q:An abstract class allows you to create functionality that subclasses can implement or override. 
    ///An interface only allows you to define functionality, not implement it.
    ///A class can implement (inherit) from many interfaces but only from one abstract class.

}
