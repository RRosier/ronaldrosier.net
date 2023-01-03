using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rosier.Blog.Models;
using Rosier.Blog.Services.Abstractions;

namespace Rosier.Blog.Pages
{
    public class EntryModel : PageModel
    {
        private readonly IEntriesService _entriesService;
        private readonly ILogger _logger;

        public EntryModel(IEntriesService entriesService, ILogger<EntryModel> logger)
        {
            this._entriesService = entriesService ?? throw new ArgumentNullException(nameof(entriesService));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Entry? Entry { get; set; }

        public async Task OnGetAsync(string slug)
        {
            this.Entry = await this._entriesService.GetEntryBySlug(slug);
        }
    }
}
