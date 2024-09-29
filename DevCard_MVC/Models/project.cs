using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;

namespace DevCard_MVC.Models
{
	public class project : IEnumerable
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public string Client { get; set; }
		public project(long id, string name, string image, string description, string client)
		{
			Id = id;
			Name = name;
			Image = image;
			Description = description;
			Client= client;
		}

		public IEnumerator GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
	}

	
}