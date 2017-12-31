using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Coralcode.Framework.Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class IgnoreAttribute : System.Attribute
    {
        public static bool IsDefined(Type type)
        {
            return System.Attribute.IsDefined(type, typeof(IgnoreAttribute), false);
        }

        public static bool IsDefined(MemberInfo member)
        {
            return System.Attribute.IsDefined(member, typeof(IgnoreAttribute), false);
        }

        public static string[] GetIgnoreMembers(Type type)
        {
            return type.GetProperties().Where(IsDefined).Select(item => item.Name).ToArray();
        }

        public static bool IsRequired(MemberInfo member)
        {
            return System.Attribute.IsDefined(member, typeof(RequiredAttribute), false);
        }

        public static string[] GetRequiredMembers(Type type)
        {
            return type.GetProperties().Where(IsRequired).Select(item => item.Name).ToArray();
        }

    }
}
