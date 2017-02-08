using System;

namespace ApiFramwork.Services
{
    public interface IMethodCollection
    {
        string GetMethod(string service, string method);
    }

    
}