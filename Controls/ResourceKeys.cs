namespace Controls
{
    using System.Windows;

    public static class ResourceKeys
    {
        public static readonly ComponentResourceKey BrushKey = new ComponentResourceKey(
            typeof(ResourceKeys),
            $"{nameof(ResourceKeys)}.{nameof(BrushKey)}");
    }
}
