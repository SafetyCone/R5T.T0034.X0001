using System;

using R5T.T0034;
using R5T.T0034.X0001;


namespace System
{
    public static class IAttributeTypeNameExtensions
    {
        public static string ServiceImplementationConstructorMarker(this IAttributeTypeName _)
        {
            return Instances.TypeName.ServiceImplementationConstructorMarker();
        }
    }
}
