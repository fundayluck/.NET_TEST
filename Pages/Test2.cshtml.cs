using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_ILCS.Pages;

public class Test2Model : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public Test2Model(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

