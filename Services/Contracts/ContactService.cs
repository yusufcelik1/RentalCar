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
	public class ContactService : IContactService
	{
		private readonly IContactRepository _contactRepository;

		public ContactService(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public void SendMessage(ContactDto contactDto)
		{
			var contact = new Contact
			{
				Name = contactDto.Name,
				Email = contactDto.Email,
				Subject = contactDto.Subject,
				Message = contactDto.Message
			};

			_contactRepository.AddContact(contact);
		}
	}
}
