using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests.Helper
{
    public static class FileHelper
    {
        public static T ReadFile<T, J>(string path)
            where J : JContainer
        {
            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JArray jArray = (JArray)JToken.ReadFrom(reader);
                return jArray.ToObject<T>();
            }
        }
    }
}
