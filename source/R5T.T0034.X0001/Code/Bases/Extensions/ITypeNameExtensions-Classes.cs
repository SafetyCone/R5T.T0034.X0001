using System;

using R5T.T0034;
using R5T.T0034.X0001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string ProgramAsAService(this ITypeName _)
        {
            return R5TTypeNames.ProgramAsAServiceBase;
        }

        public static string ServiceAction(this ITypeName _)
        {
            return R5TTypeNames.ServiceAction;
        }
    }
}
