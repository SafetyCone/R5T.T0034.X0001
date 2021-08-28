using System;

using R5T.T0034;
using R5T.T0034.X0001.X001;


namespace System
{
    public static class INamespacedTypeNameExtensions
    {
        public static string IServiceAction(this INamespacedTypeName namespacedTypeName)
        {
            var output = namespacedTypeName.From(
                Instances.NamespaceName.R5T().Dacia().Value(),
                Instances.TypeName.IServiceAction());

            return output;
        }
    }
}
