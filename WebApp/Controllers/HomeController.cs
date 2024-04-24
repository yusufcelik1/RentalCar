using Entities.ModelDto;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Efcore;
using Services.EFCore;
using System.Diagnostics;
using System.Globalization;
using WebApp.Models;

namespace WebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IReservationService _reservationService;
		private readonly RepositoryContext _dbContext;
		public HomeController(ILogger<HomeController> logger, IReservationService reservationService, RepositoryContext dbContext)
		{
			_logger = logger;
			_reservationService = reservationService;
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult MakeReservation(ReservationDto reservationDto)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var reservation = new Reservation
					{
						PhoneNumber = reservationDto.PhoneNumber,
						PickUpLocation = reservationDto.PickUpLocation,
						DropOffLocation = reservationDto.DropOffLocation,
						PickUpDate = reservationDto.PickUpDate,
						DropOffDate = reservationDto.DropOffDate
					};

					_dbContext.Reservations.Add(reservation);
					_dbContext.SaveChanges();

					ViewBag.SuccessMessage = "Reservation has been successfully made.";
				}
				catch (Exception ex)
				{
					ViewBag.ErrorMessage = "An error occurred while making reservation: " + ex.Message;
				}
			}
			else
			{
				// Model geçersiz olduğunda, hata mesajını göster ve ana sayfaya geri dön
				ViewBag.ErrorMessage = "Reservation could not be made. Please check the form for errors.";
				return View("Index");
			}

			return RedirectToAction("Index", "Home"); // Başarılı bir rezervasyon yapıldığında ana sayfaya yönlendir
		}
	}
}
