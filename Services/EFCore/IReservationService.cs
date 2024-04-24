using Entities.ModelDto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EFCore
{
    public interface IReservationService
    {
        void MakeReservation(ReservationDto reservationDto);
    }

}
