using System;
using Nancy;

namespace NancyDockerDemo
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ => "Nancy: Hello World";
            Get["/os"] = _ => Environment.OSVersion.ToString();
        }
    }
}