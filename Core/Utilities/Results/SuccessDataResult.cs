﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult() : base(default, true) { }
        public SuccessDataResult(string message) : base(default, true, message) { }
        public SuccessDataResult(T data, string message) : base(data, true, message) { }
        public SuccessDataResult(T data) : base(data, true) { }

    }
}
