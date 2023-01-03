using Rosier.Blog.Models;

namespace Rosier.Blog.Services.Abstractions;

public interface IEntriesService
{
    /// <summary>
    /// Gets the most recent posted entries.
    /// </summary>
    /// <param name="top">Max nr of entries to retrieve.</param>
    /// <param name="token">The cancellation token.</param>
    /// <returns>The top most recent entries.</returns>
    Task<Entry[]> GetMostRecentEntriesAsync(int top = 5, CancellationToken token = default);

    /// <summary>
    /// Get the entry by unique slug.
    /// </summary>
    /// <param name="slug">The unique slug to search for.</param>
    /// <param name="token">The cancellation token.</param>
    /// <returns>If found, entry that correspond to the slug, else null.</returns>
    Task<Entry?> GetEntryBySlug(string slug, CancellationToken token = default);
}