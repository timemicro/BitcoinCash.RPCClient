﻿using System;
using Newtonsoft.Json;

namespace Timemicro.BitcoinCash.RPCClient
{
    public class JsonRPCResponseError
    {
        public JsonRPCResponseError()
        {
        }

        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    }
}
