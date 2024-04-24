using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Efcore
{
    public interface IReservationRepository
    {
        void AddReservation(Reservation reservation);
    }
}
