﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceTraffic.GithubToTfsSync
{
    [Serializable]
    public class InvalidRequestException : Exception
    {
        public InvalidRequestException(string message) : base(message)
        {
            
        }

        public InvalidRequestException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}