﻿using System;

namespace Service.Exceptions
{
    public class UserAlreadyExistsException:ApplicationException
    {
        public UserAlreadyExistsException() { }
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}
