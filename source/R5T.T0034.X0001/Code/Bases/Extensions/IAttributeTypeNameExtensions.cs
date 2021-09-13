using System;

using R5T.Magyar;

using R5T.T0034;
using R5T.T0034.X0001;

using Instances = R5T.T0034.X0001.Instances;


namespace System
{
    public static class IAttributeTypeNameExtensions
    {
        public static string AttributeTypeNameSuffix(this IAttributeTypeName _)
        {
            return "Attribute";
        }

        public static bool HasAttributeTypeNameSuffix(this IAttributeTypeName _,
            string typeName)
        {
            var output = typeName.EndsWith(_.AttributeTypeNameSuffix());
            return output;
        }

        public static string ExtensionMethodBaseMarkerAttribute(this IAttributeTypeName _)
        {
            return Instances.TypeName.ExtensionMethodBaseMarkerAttribute();
        }

        public static string ServiceImplementationConstructorMarkerAttribute(this IAttributeTypeName _)
        {
            return Instances.TypeName.ServiceImplementationConstructorMarkerAttribute();
        }

        public static string GetAttributeNameFromAttributeTypeName(this IAttributeTypeName _,
            string attributeTypeName)
        {
            var hasAttributeTypeNameSuffix = _.HasAttributeTypeNameSuffix(attributeTypeName);
            if(hasAttributeTypeNameSuffix)
            {
                var output = attributeTypeName.ExceptEnding(_.AttributeTypeNameSuffix());
                return output;
            }
            else
            {
                throw new ArgumentException($"Attribute type name '{attributeTypeName}' did not have attribute suffix.");
            }
        }
    }
}
