﻿using System.Runtime.Serialization;

namespace Gretly.Models
{
    public class Token
    {
        [DataMember(Name = "accessToken")]
        public string AccessToken { get; set; }
    }
}
