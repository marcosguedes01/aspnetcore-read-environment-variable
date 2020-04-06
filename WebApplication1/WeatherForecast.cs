using System;

namespace WebApplication1
{
    public class EnvironmentModel
    {
        public string Name { get; set; }
        public string Value => Environment.GetEnvironmentVariable(Name);
    }
}
