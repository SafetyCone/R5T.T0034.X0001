using System;

using R5T.T0034;
using R5T.T0034.X0001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string ExtensionMethodBaseMarkerAttribute(this ITypeName _)
        {
            return R5TTypeNames.ExtensionMethodBaseMarkerAttribute;
        }

        public static string ServiceImplementationConstructorMarkerAttribute(this ITypeName _)
        {
            return R5TTypeNames.ServiceImplementationConstructorMarkerAttribute;
        }
    }
}
