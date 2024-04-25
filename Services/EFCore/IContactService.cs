using Entities.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EFCore
{
	public interface IContactService
	{
		void SendMessage(ContactDto contactDto);
	}
}
