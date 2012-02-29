using Coypu;

namespace CoypuTables
{
    public static class ElementScopeExtensions
    {
         public static TableElementScope AsTable(this ElementScope elementScope)
         {
             return new TableElementScope(elementScope);
         }
    }
}