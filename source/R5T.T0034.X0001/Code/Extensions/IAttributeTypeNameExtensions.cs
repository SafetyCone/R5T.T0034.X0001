using System;

using R5T.T0034;
using R5T.T0034.X0001;


namespace System
{
    public static class IAttributeTypeNameExtensions
    {
        public static string ExtensionMethodBaseMarkerAttribute(this IAttributeTypeName _)
        {
            return Instances.TypeName.ExtensionMethodBaseMarkerAttribute();
        }

        public static string ServiceImplementationConstructorMarkerAttribute(this IAttributeTypeName _)
        {
            return Instances.TypeName.ServiceImplementationConstructorMarkerAttribute();
        }
    }
}
