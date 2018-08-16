using System;

namespace Watcher.Common.MoveToFrontend
{
    /// <summary>
    /// Marks C# (class|interface) for export as equivalent type in Typescript so it can be used in the web/javascript application.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Interface)]
    public class ExportClassToTypescriptAttribute : Attribute
    {
        // Doesn't need anything in it; just its presence is enough.
    }

    /// <summary>
    /// Marks C# (enum) for export as equivalent type in Typescript so it can be used in the web/javascript application.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Interface)]
    public class ExportEnumToTypescriptAttribute : Attribute
    {
        // Doesn't need anything in it; just its presence is enough.
    }
    class MyAttributes
    {
    }
}
