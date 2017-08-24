using System;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;

namespace SPUCafe.Core 
{
	public static class ScraperService
	{
		static HtmlDocument _doc;
		static string _week;

		public static async Task<string> getDocAsync()
		{
			Debug.WriteLine("getDocAsync called");
			HtmlWeb web = new HtmlWeb();
			//_doc = await web.LoadFromWebAsync("https://saintpeters.sodexomyway.com/dining-choices/index.html");
			_doc = await web.LoadFromWebAsync("https://saintpeters.sodexomyway.com/images/WeeklyMenu_tcm1062-2231.htm");
			Debug.WriteLine(_doc.DocumentNode.InnerHtml);

			string textFromDoc = getText(_doc);
			return textFromDoc;
		}

		public static string getText(HtmlDocument document)
		{
			var linkNode = document.DocumentNode.Descendants("a").FirstOrDefault(x => x.InnerHtml.Contains("the Menu"));
			_week = linkNode.InnerHtml;
			return linkNode.InnerHtml;
		}

		public static string getWeek()
		{
			Debug.WriteLine("ScraperService getWeek called");
			return _week;
		}
	}
}
