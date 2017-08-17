using System;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace SPUCafe.Core 
{
	public class ScraperService : IScraperService
	{
		HtmlDocument _doc;

		public async Task<string> getDocAsync()
		{
			HtmlWeb web = new HtmlWeb();
			HtmlDocument doc = await web.LoadFromWebAsync("https://saintpeters.sodexomyway.com/dining-choices/index.html");

			//Debug.WriteLine(doc.DocumentNode.InnerHtml);
			String result = await printDoc(doc);
			return result;
		}

		public async Task<string> printDoc(HtmlDocument doc)
		{
			_doc = doc;	
			Debug.WriteLine(_doc.DocumentNode.InnerHtml);
			return "this is fake cafe data!";
		}
	}
}
