using System;
using FacebookAPI.Models;

namespace FacebookAPI
{
	/// <summary>
	/// Class Conversions API V16
	/// </summary>
	public static class Conversions
	{

		




		/// <summary>
		/// Send Method use for send data to facebook server 
		/// </summary>
		/// <param name="data"></param>
		/// <param name="accessToken"></param>
		/// <param name="pixelID"></param>
		/// <returns></returns>
		public static bool Send(FacebookDataAPI data, string accessToken, string pixelID)
		{


			string Url = Config.FACEBOOK_SERVER+"/"+Config.VERSION+"/"+pixelID+ "/events";

			return true;
		}


	}
}

