using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EasyTk.Core.Extensions
{
    public static class RequestExtension
    {
        /// <summary>
        /// 获取请求参数名称/参数值
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetParametersNameAndValue<TResponse>(this IRequest<TResponse> request) where TResponse : IResponse
        {
            var dic = new Dictionary<string, string>();
            var properties = request.GetPropertyAndName();
            foreach (var property in properties)
            {
                var value = property.Key.GetValue(request);
                if (value == null)
                {
                    continue;
                }
                dic.Add(property.Value, value.ToString());
            }

            return dic;
        }

        /// <summary>
        /// 获取请求参数名称/参数值
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetParametersNameAndJsonValue<TResponse>(this IRequest<TResponse> request) where TResponse : IResponse
        {
            var dic = new Dictionary<string, string>();
            var properties = request.GetPropertyAndName();
            foreach (var property in properties)
            {
                var value = property.Key.GetValue(request);
                if (value == null)
                {
                    continue;
                }

                var type = property.Key.PropertyType;
                if (type.IsValueType || type == typeof(string))
                {
                    dic.Add(property.Value, value.ToString());
                }
                else
                {
                    dic.Add(property.Value, Newtonsoft.Json.JsonConvert.SerializeObject(value));
                }
            }

            return dic;
        }

        /// <summary>
        /// 获取属性及其对应的请求参数名称
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Dictionary<PropertyInfo, string> GetPropertyAndName<TResponse>(this IRequest<TResponse> request) where TResponse : IResponse
        {
            var type = request.GetType();
            if (LocalProperties.ContainsKey(type))
            {
                return LocalProperties[type];
            }
            var dictionary = new Dictionary<PropertyInfo, string>();
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var name = property.Name.ToLower();
                var customs = property.GetCustomAttributes().ToList();
                if (customs.Any(p => p is Newtonsoft.Json.JsonIgnoreAttribute))
                {
                    continue;
                }

                var jsonProperty = customs.FirstOrDefault(p => p is Newtonsoft.Json.JsonPropertyAttribute);
                if (jsonProperty != null)
                {
                    name = ((Newtonsoft.Json.JsonPropertyAttribute)jsonProperty).PropertyName;
                }
                dictionary.Add(property, name);
            }

            LocalProperties[type] = dictionary;
            return dictionary;
        }

        /// <summary>
        /// 本地缓存
        /// </summary>
        private static readonly Dictionary<Type, Dictionary<PropertyInfo, string>>
            LocalProperties = new Dictionary<Type, Dictionary<PropertyInfo, string>>();
    }
}
