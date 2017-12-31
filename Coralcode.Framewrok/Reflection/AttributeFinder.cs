using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Coralcode.Framework.Extensions;

namespace Coralcode.Framework.Reflection
{
    public class AttributeFinder
    {
        public TAttribute GetPropertyAttribute<TAttribute>(Type type, string propertyName)
            where TAttribute : System.Attribute
        {
            return type.GetProperty(propertyName).GetCustomAttribute<TAttribute>();
        }


        /// <summary>
        /// 获取成员特性,如枚举成员
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="type"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public TAttribute GetFieldAttribute<TAttribute>(Type type, string fieldName)
            where TAttribute : System.Attribute
        {
            return type.GetField(fieldName).GetCustomAttribute<TAttribute>();
        }
    }
}
