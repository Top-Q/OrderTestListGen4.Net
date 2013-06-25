using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderTestListGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestMethodInfo> testsList = new List<TestMethodInfo>();
            TestMethodInfo testInfo;
            Assembly asm = Assembly.LoadFrom(@"C:\Users\nimrod_t\Documents\Visual Studio 2012\Projects\DotNetTestingFramework\TessProj\bin\Debug\TessProj.dll");            

            var project = asm.GetModules()[0];
            var types = project.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Class : " + type.ToString());
                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    var customAttributes = method.GetCustomAttributes(false);
                    foreach (var customAtt in customAttributes)
                    {
                        if (customAtt.ToString().ToLower().Contains("testmethod"))
                        {
                            testInfo = new TestMethodInfo();
                            Console.WriteLine("Method name : " + method.Name);
                            testInfo.Name = method.Name;
                            Console.WriteLine(method.Module.FullyQualifiedName.ToLower());
                            testInfo.Storage = method.Module.FullyQualifiedName;
                            testInfo.Id = TestIdGenerator.getGuidFromString(method.ReflectedType.ToString() + "." + testInfo.Name).ToString();
                            Console.WriteLine(method.ReflectedType.ToString() + "." + testInfo.Name);                            
                            testsList.Add(testInfo);                            
                        }
                    }                    
                }
            }

            exportTestListToJson(testsList);
           
            Console.ReadKey();
        }

        private static void exportTestListToJson(List<TestMethodInfo> testsList)
        {
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<TestMethodInfo>));
            ser.WriteObject(ms, testsList);

            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);

            File.WriteAllText(@"C:\testsList\CapturedRequestsJson.txt", sr.ReadToEnd());
        }
    }
}
