using System;

using R5T.T0034;
using R5T.T0034.X0001.X001;


namespace System
{
    public static partial class INamespacedTypeNameExtensions
    {
        public static string IExtensionMethodBaseFunctionality(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Values().R5T_T0039(),
                Instances.TypeName.IExtensionMethodBaseFunctionality());

            return output;
        }

        public static string IHost_ExtensionMethodBase(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Values().R5T_T0070(),
                Instances.TypeName.IHost());

            return output;
        }

        public static string IProjectPath(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Values().R5T_T0040(),
                Instances.TypeName.IProjectPath());

            return output;
        }
    }
}
