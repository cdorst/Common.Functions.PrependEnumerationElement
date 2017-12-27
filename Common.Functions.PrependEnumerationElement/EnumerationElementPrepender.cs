using System.Collections.Generic;
using System.Linq;
using static Common.Functions.CheckNullableEnumerationForAnyElements.NullableEnumerationAny;
using static Common.Functions.CreateNewArrayFromSingleElement.ArrayCreator;

namespace Common.Functions.PrependEnumerationElement
{
    public static class EnumerationElementPrepender
    {
        public static IEnumerable<T> Prepend<T>(T firstElement, IEnumerable<T> remainingElements)
            => Any(remainingElements)
                ? remainingElements.Prepend(firstElement)
                : Array(firstElement);
    }
}
