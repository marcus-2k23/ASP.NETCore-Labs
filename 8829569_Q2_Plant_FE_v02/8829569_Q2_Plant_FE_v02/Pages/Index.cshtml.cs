// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829569_Q2_Plant_FE_v02.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        try{
            _logger = logger;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        
    }

    public void OnGet()
    {
        try{
           
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }

    }
}
