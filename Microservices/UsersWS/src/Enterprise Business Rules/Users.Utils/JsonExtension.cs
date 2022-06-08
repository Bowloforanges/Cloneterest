using System;
using System.Text.Json;

namespace Alta.Utils
{
    /// <summary>
    ///  Extension method used to wrap JSON serialization and deserialization
    /// </summary>
    public static class JsonExtension
    {
        //Converts JSON object to string
        public static string ToJson<T>(this T t) => JsonSerializer.Serialize(t);

        //Converts string object to JSON
        public static T FromJson<T>(this string s) => JsonSerializer.Deserialize<T>(s);

        //Converts string object to JSON, specifying an object type to cast
        public static T FromJson<T>(this string s, Type type) => (T)JsonSerializer.Deserialize(s, type);
    }
}
