using Entities.Models;
using Repository.Efcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
	public class ContactRepository : IContactRepository
	{
		private readonly RepositoryContext _dbContext;

		public ContactRepository(RepositoryContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void AddContact(Contact contact)
		{
			_dbContext.Contacts.Add(contact);
			_dbContext.SaveChanges();
		}
	}
}
