using System;
using Coralcode.Framework.GenericsFactory;

namespace Coralcode.Framework.MessageBus
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public class MessageAttribute : StrategyAttribute
    {
        public MessageAttribute(string description) : base(description)
        {
        }
    }
    
}
