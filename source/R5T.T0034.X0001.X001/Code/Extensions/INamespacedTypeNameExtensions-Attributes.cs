using System;

using R5T.T0034;
using R5T.T0034.X0001.X001;


namespace System
{
    public static partial class INamespacedTypeNameExtensions
    {
        public static string ExtensionMethodBaseMarkerAttribute(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.R5T().T0039().T002().Value(),
                Instances.TypeName.ExtensionMethodBaseMarkerAttribute());

            return output;
        }

        public static string ServiceDefinitionMarkerAttribute(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.R5T().Dacia().Value(),
                Instances.TypeName.ServiceDefinitionMarkerAttribute());

            return output;
        }

        public static string ServiceImplementationConstructorMarkerAttribute(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.R5T().Dacia().Value(),
                Instances.TypeName.ServiceImplementationConstructorMarkerAttribute());

            return output;
        }

        public static string ServiceImplementationMarkerAttribute(this INamespacedTypeName _)
        {
            var output = _.From(
                Instances.NamespaceName.R5T().Dacia().Value(),
                Instances.TypeName.ServiceImplementationMarkerAttribute());

            return output;
        }
    }
}
