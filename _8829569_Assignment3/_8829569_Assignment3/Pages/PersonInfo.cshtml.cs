﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829569_Assignment3.Pages;

public class PersonInfoModel : PageModel
{
    private readonly ILogger<PersonInfoModel> _logger;

    public Person person = new Person();

    public PersonInfoModel(ILogger<PersonInfoModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
        
    }
    public void PostPersonInfo()
    {   
    }
    public IActionResult OnPost(Person person)
    {
        return RedirectToPage("PersonAdded",person);
    }
}
