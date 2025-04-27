namespace DeclarativeComposition.Utils;

/// <summary>
/// This class is used to generate unique indexes for anonymous objects.
/// </summary>
public static class AnonymousObjectIndexer
{
    /// <summary>
    /// The current index for anonymous objects.
    /// </summary>
    private static int _count;
    
    /// <summary>
    /// Resets the indexer to 0. Called before each translation of a DCL AST tree.
    /// </summary>
    public static void Reset() => _count = 0;

    /// <summary>
    /// Increments the indexer and returns the next index.
    /// </summary>
    /// <returns>Index for the next anonymous object.</returns>
    public static int Next() => ++_count;
}