using Entities.Models;
using Repository.Efcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly RepositoryContext _dbContext;

        public ReservationRepository(RepositoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }
    }
}
