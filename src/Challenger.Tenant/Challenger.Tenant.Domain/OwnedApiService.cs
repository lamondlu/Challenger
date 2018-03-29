using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenger.Tenant.Domain
{
	public class OwnedApiService
	{
		public Guid OwnedApiServiceId { get; set; }

		public ApiService ApiService { get; set; }

		public string AppClientId { get; set; }

		public string AppSecret { get; set; }
	}
}
