using Rosier.Blog.Models;
using Rosier.Blog.Services.Abstractions;

namespace Rosier.Blog.Services;

public class EntriesService : IEntriesService
{
    public Task<Entry[]> GetMostRecentEntriesAsync(int top = 5, CancellationToken token = default)
    {
        return Task.FromResult(EntryData.Values);
        throw new NotImplementedException();
    }
}

internal static class EntryData
{
    public static Entry[] Values = new[]
    {
        new Entry
        {
            Id = 1,
            Title = "First blog entry",
            Description = "This is my first blog entry description.",
            Content = "<div>This is my first blog entry.</div>",
            PublishDate = DateTime.UtcNow.AddDays(-5)
        },
        new Entry
        {
            Id = 2,
            Title = "Second blog entry",
            Description = "This is my second blog entry description.",
            Content = "<div>This is my second blog entry.</div>",
            PublishDate = DateTime.UtcNow.AddDays(-2)
        }
    };
}