using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Splendent.Master.Dto
{
    public class BaseResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; }

        public bool IsSuccess { get; set; }

        [JsonProperty("sessionid")]
        public Guid SessionID { get; set; }
    }
}
