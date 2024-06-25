using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
	public class MessageD
	{
		public MessageD(string _chat, string _message, string _sender)
		{
			Chat = _chat;
			Message = _message;
			Sender = _sender;
		}

		public string Chat { get; set; }
		public string Sender { get; set; }
		public string Message { get; set; }
	}
}
