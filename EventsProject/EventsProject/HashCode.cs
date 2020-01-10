using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EventsProject
{
	class HashCode
	{
		
		public string encrypt(string clearText)
		{
			using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
			{
				UTF8Encoding utf = new UTF8Encoding();
				byte[] data = md5.ComputeHash(utf.GetBytes(clearText));
				return Convert.ToBase64String(data);
			}
		}
	}
}
