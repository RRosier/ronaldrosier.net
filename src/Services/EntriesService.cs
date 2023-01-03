using Rosier.Blog.Models;
using Rosier.Blog.Services.Abstractions;

namespace Rosier.Blog.Services;

public class EntriesService : IEntriesService
{
    public Task<Entry?> GetEntryBySlug(string slug, CancellationToken token = default)
    {
        var entry = EntryData.Values.SingleOrDefault(e => e.Slug == slug);
        return Task.FromResult(entry);
    }

    public Task<Entry[]> GetMostRecentEntriesAsync(int top = 5, CancellationToken token = default)
    {
        var entries = EntryData.Values.OrderByDescending(e => e.PublishDate).Take(top).ToArray();
        return Task.FromResult(entries);
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
            Content = "<p>This is my first blog entry.</p><p><a href=\"/\">Here's a link</a><p/><p>Some paragraph<br />with a break</p><h3>A sub header</h3><pre>public class MyClass { }</pre>",
            PublishDate = DateTime.UtcNow.AddDays(-5),
            Slug = "first-blog-entry"
        },
        new Entry
        {
            Id = 2,
            Title = "Second blog entry",
            Description = "This is my second blog entry description.",
            Content = "<div>This is my second blog entry.</div>",
            PublishDate = DateTime.UtcNow.AddDays(-2),
            Slug = "second-blog-entry"
        }
    };
}