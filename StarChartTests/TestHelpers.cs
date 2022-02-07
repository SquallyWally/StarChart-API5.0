using System;
using System.Linq;
using System.Reflection;

namespace StarChartTests
{
    public static class TestHelpers
    {
        private static readonly string _projectName = "StarChart";

        public static Type GetUserType(string fullName)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (assembly.FullName == null || !assembly.FullName.StartsWith(_projectName)) continue;
                foreach (var type in assembly.GetTypes())
                {
                    if (type.FullName == fullName) return type;
                }
            }

            return null;
        }
    }
}