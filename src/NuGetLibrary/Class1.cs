namespace NuGetLibrary;

/// <summary>
/// Provides the sample API used by the NuGet publishing workflow.
/// </summary>
public static class SampleApi
{
    /// <summary>
    /// Returns a greeting for the supplied name.
    /// </summary>
    /// <param name="name">The name to greet.</param>
    /// <returns>A greeting message.</returns>
    public static string Greet(string name) => $"Hello, {name}!";
}
