using Entities.ModelDto;
using Entities.Models;
using Repository.Efcore;
using Services.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void MakeReservation(ReservationDto reservationDto)
        {
            var reservation = new Reservation
            {
                PhoneNumber = reservationDto.PhoneNumber,
                PickUpLocation = reservationDto.PickUpLocation,
                DropOffLocation = reservationDto.DropOffLocation,
                PickUpDate = reservationDto.PickUpDate,
                DropOffDate = reservationDto.DropOffDate,
            };

            _reservationRepository.AddReservation(reservation);
        }
    }
}
