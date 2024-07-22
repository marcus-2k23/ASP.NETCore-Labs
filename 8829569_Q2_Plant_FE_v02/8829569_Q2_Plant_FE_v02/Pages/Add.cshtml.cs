// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829569_Q2_Plant_FE_v02.Pages;

public class AddModel : PageModel
{

    public Flower flower = new Flower();
    private readonly ILogger<AddModel> _logger;

    public AddModel(ILogger<AddModel> logger)
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
    public IActionResult OnPost(Flower flower)
    {
        try{
            
            return RedirectToPage("ThankYou",flower);
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            return null;
        }
        
    }
}
