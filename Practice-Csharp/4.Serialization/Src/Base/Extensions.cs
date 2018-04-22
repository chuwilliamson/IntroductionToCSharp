using System; 
using System.Linq;

namespace _4.Serialization
{
    public static class Extensions
    {
        public static Type[] FindObjectsOfType<T>()
        {
            return (from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                            from assemblyType in domainAssembly.GetTypes()
                            where typeof(T).IsAssignableFrom(assemblyType)
                            select assemblyType).ToArray();
        }
    } 
}
