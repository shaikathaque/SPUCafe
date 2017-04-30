using System.Collections.Generic;

namespace SPUCafe.Core
{
	public interface ICafeDataRepository
	{
		List<CafeData> getCafeData();
	}
}
