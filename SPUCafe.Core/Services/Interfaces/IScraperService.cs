using System;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace SPUCafe.Core
{
	public interface IScraperService
	{
		Task<string> getDocAsync();
	}
}
