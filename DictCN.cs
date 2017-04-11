using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace DictCN
{
	class DictCN
	{
		Action<string> _found;
		HttpWebRequest _request;
		StringBuilder _result;

		public DictCN(Action<string> callback)
		{
			_found = callback;
			_result = new StringBuilder();
		}

		public void Find(string text)
		{
			ThreadPool.QueueUserWorkItem(DoFind, text);
		}

		void DoFind(object state)
		{
			HttpWebResponse response = null;
			StreamReader reader = null;

			try
			{
				if (_request != null)
					_request.Abort();

				string text = (string)state;
				_found("Searching " + text);
				_result.Length = 0;
				_result.AppendLine(text);

				var request = _request = (HttpWebRequest)WebRequest.Create("http://dict.cn/" + text);
				request.Timeout = 5000;
				response = (HttpWebResponse)request.GetResponse();
				reader = new StreamReader(response.GetResponseStream());
				string html = reader.ReadToEnd();
				_Parse(html);
			}
			catch
			{
				_found("Exception!");
			}
			finally
			{
				if (reader != null)
					reader.Close();
				if(response != null)
					response.Close();
				_request = null;
			}
		}

		string _FindMiddle(string text, string start, string end, ref int offset)
		{
			int start_p = text.IndexOf(start, offset);
			if (start_p < 0)
				return null;
			start_p += start.Length;
			int end_p = text.IndexOf(end, start_p);
			if (end_p < 0)
				return null;
			offset = end_p + end.Length;
			return text.Substring(start_p, end_p - start_p);
		}

		string _FindInnerHtml(string text, string tag, ref int offset)
		{
			return _FindMiddle(text, "<" + tag + ">", "</" + tag + ">", ref offset);
		}

		int _Parse(string html)
		{
			const string H = "<ul class=\"dict-basic-ul\">";
			int p = html.IndexOf(H);
			if (p < 0)
				goto NORESULT;
			p += H.Length;

			int q = html.IndexOf("</ul>", p);
			if (q < 0)
				goto NORESULT;

			string meaning;
			bool found = false;
			while(null != (meaning = _FindInnerHtml(html, "li", ref p)) && p <= q)
			{
				int innerOffset = 0;
				string type = _FindInnerHtml(meaning, "span", ref innerOffset);
				if (type != null)
					_result.Append(type).Append(' ');
				string realmeaning = _FindInnerHtml(meaning, "strong", ref innerOffset);
				if (realmeaning != null)
					_result.AppendLine(realmeaning);
				found = innerOffset > 0;
			}

			if (found)
				goto OUTPUT;
NORESULT:
			_result.AppendLine("No result");
OUTPUT:
			return output();
		}

		int output()
		{
			_found(_result.ToString());
			return 0;
		}
	}
}
