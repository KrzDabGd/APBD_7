﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_7.DTOs
{
	public class EnrollStudentRequest
	{
		[Required]
		public string IndexNumber { get; set; }

		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string BirthDate { get; set; }
		//public string IdEnrollment { get; set; }
		[Required]
		public string Studies { get; set; }
	}
}