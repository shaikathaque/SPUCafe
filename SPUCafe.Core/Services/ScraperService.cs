using System;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;

namespace SPUCafe.Core 
{
	public class ScraperService : IScraperService
	{
		HtmlDocument _doc;
		string _week;

		public async Task<string> getDocAsync()
		{
			HtmlWeb web = new HtmlWeb();
			_doc = await web.LoadFromWebAsync("https://saintpeters.sodexomyway.com/dining-choices/index.html");

			Debug.WriteLine(_doc.DocumentNode.InnerHtml);

			string textFromDoc = getText(_doc);
			Debug.WriteLine(textFromDoc);
			return textFromDoc;
		}

		public string getText(HtmlDocument document)
		{
			var linkNode = document.DocumentNode.Descendants("a").FirstOrDefault(x => x.InnerHtml.Contains("the Menu"));
			_week = linkNode.InnerHtml;
			return linkNode.InnerHtml;
		}

		public string getWeek()
		{
			return _week;
		}
	}
}
