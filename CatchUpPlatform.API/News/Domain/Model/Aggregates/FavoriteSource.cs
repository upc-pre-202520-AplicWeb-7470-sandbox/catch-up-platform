using CatchUpPlatform.API.News.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Domain.Model.Aggregates;

/// FavoriteSource Aggregate
/// <summary>
///     This class represents the FavoriteSource aggregate. It is used to store the favorite sources of a user.
/// </summary>
public partial class FavoriteSource
{
    protected FavoriteSource()
    {
        NewsApiKey = string.Empty;
        SourceId = string.Empty;
    }

    /// <summary>
    ///     Constructor for the FavoriteSource aggregate.
    /// </summary>
    /// <remarks>
    ///     The constructor is the command handler for the CreateFavoriteSourceCommand.
    /// </remarks>
    /// <param name="command">The CreateFavoriteSourceCommand command</param>
    public FavoriteSource(CreateFavoriteSourceCommand command)
    {
        NewsApiKey = command.NewsApiKey;
        SourceId = command.SourceId;
    }

    public int Id { get; }
    public string NewsApiKey { get; private set; }
    public string SourceId { get; private set; }
}