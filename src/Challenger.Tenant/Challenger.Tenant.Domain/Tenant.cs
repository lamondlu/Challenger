using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenger.Tenant.Domain
{
	public class Tenant
	{
		public Guid TenantId { get; set; }

		public string TenantName { get; set; }

		public List<OwnedApiService> ApiServices { get; set; }
	}
}
