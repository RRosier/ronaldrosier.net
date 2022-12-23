using Rosier.Blog.Models;

namespace Rosier.Blog.Services.Abstractions;

public interface IEntriesService
{
    /// <summary>
    /// Gets the most recent posted entries.
    /// </summary>
    /// <param name="top"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    Task<Entry[]> GetMostRecentEntriesAsync(int top = 5, CancellationToken token = default);
}