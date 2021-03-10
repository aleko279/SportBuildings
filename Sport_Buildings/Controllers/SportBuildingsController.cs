using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sport_Buildings.Models;

namespace Sport_Buildings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportBuildingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("[action]")]
        [Route("api/SportBuildings/GetSportBuildingList")]
        public DataPager GetSportBuildingList(int count, int page = 1, string filterText = "", [FromBody] string filterIds = null)
        {
            if (filterText == null) filterText = "";
            int num;
            bool isNumeric = int.TryParse(filterText, out num);
            SportBuildingsContext con = new SportBuildingsContext();
            List<int> idsLit = new List<int>();

            if (!String.IsNullOrEmpty(filterIds))
            {
                idsLit = filterIds.Split(',').Select(x => int.Parse(x)).ToList();
            }


            DataPager obj = new DataPager();
            obj.aaData = GetSportBuildings(count, page, String.Join(',', idsLit), filterText);
            obj.iTotalRecords = con.SportBuildings.Count();
            obj.iTotalDisplayRecords = count;
            obj.currentPage = page;


            int page_range = 4;
            int startRange = (page < page_range) ? 1 : ((page > obj.totalPages - page_range + 1) ? obj.totalPages - page_range + 1 : page - 2);
            obj.pages = Enumerable.Range(startRange, (obj.totalPages > page_range) ? page_range : obj.totalPages).ToList();
            return obj;
        }
        [HttpGet("[action]")]
        public IEnumerable<MainPageObjectList> GetSportBuildings(int count, int page = 1, string idsList = null, string filterText = "")
        {
            if (filterText == null) filterText = "";
            int num;
            bool isNumeric = int.TryParse(filterText, out num);
            SportBuildingsContext con = new SportBuildingsContext();
            List<int> idsLit = new List<int>();

            if (!String.IsNullOrEmpty(idsList)) idsLit = idsList.Split(',').Select(x => int.Parse(x)).ToList();

            int toskip = count * (page - 1);
            List<MainPageObjectList> list = new List<MainPageObjectList>();
            foreach (SportBuildings x in con.SportBuildings
                .OrderByDescending(x => x.Objectid).Skip(toskip).Take(count))
            {
                MainPageObjectList obj = new MainPageObjectList();
                obj.ID = x.Objectid;
                obj.ObjectName = x.BuildingName;
                //obj.Variety = String.Join(", ", x.ImmovableObjectsVariety.Select(v => v.Variety.Name));

//                obj.PhotoAddress = !String.IsNullOrEmpty(x.PhotoAddress) ? Program.proxy + x.PhotoAddress : "";
                obj.linkPath = "objects/immovable/immovableObject?id=" + x.Objectid.ToString();
                obj.objType = "immovable";
                obj.mapType = "immovable";
                //obj.mapID = x.Id;
                list.Add(obj);  
            }
            return list;
        }
    }
}