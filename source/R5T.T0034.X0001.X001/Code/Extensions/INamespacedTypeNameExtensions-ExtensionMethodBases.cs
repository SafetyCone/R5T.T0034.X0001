using System;

using R5T.T0034;
using R5T.T0034.X0001.X001;


namespace System
{
    public static partial class INamespacedTypeNameExtensions
    {
        public static string IProjectPath(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Values().R5T_T0040(),
                Instances.TypeName.IProjectPath());

            return output;
        }
    }
}
