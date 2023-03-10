using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
	[Owned]
	public class FullName
	{
		[Display(Name = "first Name")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 25 characters")]
		public string firstName { get; set; }
		[Display(Name = "Last Name")]
		public string lastName { get; set; }
		public FullName() { }

		public FullName(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}
	}
}
