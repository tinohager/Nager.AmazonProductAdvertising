using System.IO;
using System.Reflection;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    public class Resources
    {
        public static string LoadResource(string resourceName)
        {
            var assembly = typeof(Resources).GetTypeInfo().Assembly;
            using (var stream = assembly.GetManifestResourceStream(
                $"Nager.AmazonProductAdvertising.UnitTest.{resourceName}"))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}