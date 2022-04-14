﻿using Nilgon.Validation.Helpers.Exceptions;

namespace Nilgon.Validation.Helpers
{
    public static partial class StringValidationHelpers
    {
        public static string Required(this string value, string? message = "Sring is required")
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                NilgonValidationException.Throw(message);
            }
            
            return value;
        }
    }
}