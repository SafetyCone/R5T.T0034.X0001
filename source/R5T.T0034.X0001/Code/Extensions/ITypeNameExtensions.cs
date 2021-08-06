using System;

using R5T.T0034;
using R5T.T0034.X0001;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string IServiceAction(this ITypeName _)
        {
            return R5TTypeNames.IServiceAction;
        }

        public static string ServiceAction(this ITypeName _)
        {
            return R5TTypeNames.ServiceAction;
        }
    }
}
