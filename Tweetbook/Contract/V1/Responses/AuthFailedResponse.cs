﻿using System.Collections.Generic;

namespace Tweetbook.Contract.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}