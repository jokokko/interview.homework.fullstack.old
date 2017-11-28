using System;

namespace Sample.Tasks.Domain.Infrastructure
{
    public static class Guard
    {
        public static void AgainstNull(string value, string parameterName = "")
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}