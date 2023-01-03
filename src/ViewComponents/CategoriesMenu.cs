
using Microsoft.AspNetCore.Mvc;

namespace Rosier.Blog.ViewComponents;

public class CategoriesMenuViewComponent : ViewComponent
{
    public CategoriesMenuViewComponent() { }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        await Task.CompletedTask;
        return View();
    }
}