using Entities.ModelDto;
using Microsoft.AspNetCore.Mvc;
using Services.EFCore;

namespace WebApp.Controllers
{
    public class ContactController : Controller
    {
		private readonly IContactService _contactService;
		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}
		public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult SendMessage(ContactDto contactDto)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_contactService.SendMessage(contactDto);
					ViewBag.SuccessMessage = "Message has been successfully sent.";
				}
				catch (Exception ex)
				{
					ViewBag.ErrorMessage = "An error occurred while sending the message: " + ex.Message;
				}
			}
			return RedirectToAction("Index");
		}

	}
}
