namespace RestaurantConsoleApp.Utilities
{
    using System;
    public class Validator
    {
        public static void ThrowAnExceptionIfIntIsLessThanZero(string objectName, decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{objectName} cannot be less than zero!");
            }
        }

        public static void ThrowAnExceptionIfObjectIsNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentException($"{paramName} cannot be null!");
            }
        }
    }
}
