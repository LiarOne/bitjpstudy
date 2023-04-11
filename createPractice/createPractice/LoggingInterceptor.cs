using Castle.DynamicProxy;
using System.Diagnostics;

namespace createPractice
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            //Log method call before
            Debug.WriteLine($"Calling method {invocation.Method.Name} in {invocation.TargetType.Name}");

            //Proceed with the method call
            invocation.Proceed();

            //Log method call after
            Debug.WriteLine($"Method {invocation.Method.Name} in {invocation.TargetType.Name} returned successfully");
        }
    }
}
