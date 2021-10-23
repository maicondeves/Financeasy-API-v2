﻿using System;

namespace Financeasy.Business.Core
{
    public sealed class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}