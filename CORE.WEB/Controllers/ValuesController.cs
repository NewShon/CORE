using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CORE.WEB.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		private static List<string> _storage = new List<string>();

		// GET api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return _storage;
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return _storage[id];
		}

		// PUT api/values
		[HttpPut]
		public void Put(string str)
		{
			_storage.Add(str);
		}
	}
}
