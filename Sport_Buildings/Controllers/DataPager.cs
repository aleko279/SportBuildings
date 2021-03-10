using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_Buildings.Controllers
{
    public class DataPager
    {
        public int iTotalRecords { get; set; }
        public int iTotalDisplayRecords { get; set; }
        public int currentPage { get; set; }

        public IEnumerable<int> pages { get; set; }
        public int totalPages => ((int)(iTotalRecords / iTotalDisplayRecords)) + (iTotalRecords % iTotalDisplayRecords > 0 ? 1 : 0);
        public IEnumerable<MainPageObjectList> aaData { get; set; }
        public IEnumerable<DamxmareNagebobebiSatavsoebiObjectList> DaxmareNagebobebiData { get; set; }
        public int immovableCount { get; set; }
        public int movableCount { get; set; }
        public int wallCount { get; set; }
        public int stoneCount { get; set; }
        public int museumCount { get; set; }
        public int zoneCount { get; set; }
        public int eventCount { get; set; }
        public int documentCount { get; set; }
        public int allCount => immovableCount + movableCount + wallCount + stoneCount + museumCount + zoneCount + eventCount + documentCount;
        public string filterText { get; set; }

        public dynamic classificator { get; set; }

    }

    public class Pager
    {
        public int startIndex;
        public int endIndex;
        public int pages;
        public int currentPage;
        public int totalPages;
    }
}
