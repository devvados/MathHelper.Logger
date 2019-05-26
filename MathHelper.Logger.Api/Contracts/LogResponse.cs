using System.Collections.Generic;

namespace MathHelper.Logger.Api.Contracts
{
    public class LogResponse
    {
        public bool Success { get; set; }
        public IEnumerable<dynamic> Errors { get; set; }
    }
}