using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_ILCS.Pages;

public class Test1Model : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public Test1Model(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}



