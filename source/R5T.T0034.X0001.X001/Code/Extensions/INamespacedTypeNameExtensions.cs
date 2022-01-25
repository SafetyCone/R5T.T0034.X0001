using System;

using R5T.T0034;
using R5T.T0034.X0001.X001;


namespace System
{
    public static partial class INamespacedTypeNameExtensions
    {
        /// <summary>
        /// R5T.T0062.IServiceAction extension method base.
        /// </summary>
        public static string IServiceAction_ExtensionMethodBase(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.Values().R5T_T0062(),
                Instances.TypeName.IServiceAction());

            return output;
        }
    }
}
