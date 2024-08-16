using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
	public class Response<T>
	{
		public bool IsSuccess { get; set; }
		public T Data { get; set; }
		public string Message { get; set; }

		public Response()
		{

		}
		public Response(bool isSuccess, T data, string message)
		{
			IsSuccess = isSuccess;
			Data = data;
			Message = message;
		}

		public Response<T> Success(T data)
		{
			return new Response<T>(true, data, "");
		}
		public Response<T> Success(string message)
		{
			return new Response<T>(true, default(T), message);
		}

		public Response<T> Error(string message)
		{
			return new Response<T>(false, default(T), message);
		}
	}
}
