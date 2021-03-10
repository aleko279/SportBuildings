using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sport_Buildings.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sport_Buildings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportBuildingController : ControllerBase
    {
        // GET: api/<controller>
        [HttpPost("[action]")]
        public DataPager GetSportBuildingList(int count, int page = 1)
        {
            //if (filterText == null) filterText = "";
            //int num;
            //bool isNumeric = int.TryParse(filterText, out num);
            SportBuildingsContext con = new SportBuildingsContext();
            //List<int> idsLit = new List<int>();

            //if (!String.IsNullOrEmpty(filterIds))
            //{
            //    idsLit = filterIds.Split(',').Select(x => int.Parse(x)).ToList();
            //}


            DataPager obj = new DataPager();
            obj.aaData = GetSportBuildings(count, page);
            obj.iTotalRecords = con.SportBuildings.Count();
            obj.iTotalDisplayRecords = count;
            obj.currentPage = page;


            int page_range = 4;
            int startRange = (page < page_range) ? 1 : ((page > obj.totalPages - page_range + 1) ? obj.totalPages - page_range + 1 : page - 2);
            obj.pages = Enumerable.Range(startRange, (obj.totalPages > page_range) ? page_range : obj.totalPages).ToList();
            return obj;
        }
        [HttpGet("[action]")]
        public IEnumerable<MainPageObjectList> GetSportBuildings(int count, int page = 1)
        {
            //  if (filterText == null) filterText = "";
            int num;
            // bool isNumeric = int.TryParse(filterText, out num);
            SportBuildingsContext con = new SportBuildingsContext();
            List<int> idsLit = new List<int>();

            //   if (!String.IsNullOrEmpty(idsList)) idsLit = idsList.Split(',').Select(x => int.Parse(x)).ToList();

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
                obj.linkPath = "objects/SportBuilding/SportBuildingObject?id=" + x.Objectid.ToString();
                obj.objType = "immovable";
                obj.mapType = "immovable";
                //obj.mapID = x.Id;
                list.Add(obj);
            }
            return list;
        }


        [HttpGet("[action]")]
        public SportBuildingCustomClass getSportBuildingObject(int id)
        {
            SportBuildingsContext con = new SportBuildingsContext();
            SportBuildings dbobj = con.SportBuildings.FirstOrDefault(m => m.Objectid == id);
            SportBuildingCustomClass obj = new SportBuildingCustomClass()
            {
                Objectid = dbobj.Objectid,
                BuildingName = dbobj.BuildingName,
                SportTypeId = dbobj.SportTypeId,
                Regioni = dbobj.Regioni,
                Raioni = dbobj.Raioni,
                Sofeli = dbobj.Sofeli,
                Qucha = dbobj.Qucha,
                Saxli = dbobj.Saxli,
                TelNumber = dbobj.TelNumber,
                OwnedBy = dbobj.OwnedBy,

                EqspSesvlisTariRi = dbobj.EqspSesvlisTariRi,
                SabalansoRirebuleba = dbobj.SabalansoRirebuleba,
                ParcelArea = dbobj.ParcelArea,
                SaqKodi = dbobj.SaqKodi,
                Gengegma = dbobj.Gengegma,
                Gatboba = dbobj.Gatboba,
                ElKveba = dbobj.ElKveba,
                Ventilacia = dbobj.Ventilacia,
                Kondicireba = dbobj.Kondicireba,
                Radioficireba = dbobj.Radioficireba,
                Interneti = dbobj.Interneti,
                TeritorisSemogobva = dbobj.TeritorisSemogobva,
                Wyalmomarageba = dbobj.Wyalmomarageba,
                TeqnikuriAgwera = dbobj.TeqnikuriAgwera,
                WebSite = dbobj.WebSite,
                PostalCode = dbobj.PostalCode,
                Email = dbobj.Email,
                DaarsebisWeli = dbobj.DaarsebisWeli,
                DawesebulebisXelmdzgvaneli = dbobj.DawesebulebisXelmdzgvaneli,
                OrganizaciisIuridiuliSaxelwodeba = dbobj.OrganizaciisIuridiuliSaxelwodeba,
                OrganizaciisIuridiuliStatusi = dbobj.OrganizaciisIuridiuliStatusi,
                GoogleMapCoordinates = dbobj.GoogleMapCoordinates,
                OrganizaciisXelmdzgvaneli = dbobj.OrganizaciisXelmdzgvaneli,
                OrganizaciisXelmdzgvanelisStatusi = dbobj.OrganizaciisXelmdzgvanelisStatusi,
                InformaciaAdaptirebulobis = dbobj.InformaciaAdaptirebulobis,
                NagebobisStatusi = dbobj.NagebobisStatusi,
                NagebobisMdgomareoba = dbobj.NagebobisMdgomareoba
            };
            return obj;
        }
        [HttpPost("[action]")]
        public DataPager GetDamxmareNagebobebiSatavsoebiList(int objID, int count, int page = 1)
        {
            SportBuildingsContext con = new SportBuildingsContext();

            DataPager obj = new DataPager();
            obj.DaxmareNagebobebiData = GetDaxmareNagebobebiSatavsoebis(objID, count, page);
            obj.iTotalRecords = obj.DaxmareNagebobebiData.Count();
            obj.iTotalDisplayRecords = count;
            obj.currentPage = page;


            int page_range = 4;
            int startRange = (page < page_range) ? 1 : ((page > obj.totalPages - page_range + 1) ? obj.totalPages - page_range + 1 : page - 2);
            obj.pages = Enumerable.Range(startRange, (obj.totalPages > page_range) ? page_range : obj.totalPages).ToList();
            return obj;

        }
        [HttpGet("[action]")]
        public IEnumerable<DamxmareNagebobebiSatavsoebiObjectList> GetDaxmareNagebobebiSatavsoebis(int objID, int count, int page = 1)
        {
            //  if (filterText == null) filterText = "";
            int num;
            // bool isNumeric = int.TryParse(filterText, out num);
            SportBuildingsContext con = new SportBuildingsContext();
            List<int> idsLit = new List<int>();

            //   if (!String.IsNullOrEmpty(idsList)) idsLit = idsList.Split(',').Select(x => int.Parse(x)).ToList();

            int toskip = count * (page - 1);
            List<DamxmareNagebobebiSatavsoebiObjectList> list = new List<DamxmareNagebobebiSatavsoebiObjectList>();
            foreach (DamxmareNageboba x in con.DamxmareNageboba.Where(m => Convert.ToInt32(m.BuildingId) == objID)
                .OrderByDescending(x => x.Objectid).Skip(toskip).Take(count))
            {
                DamxmareNagebobebiSatavsoebiObjectList obj = new DamxmareNagebobebiSatavsoebiObjectList();
                obj.Objectid = x.Objectid;
                obj.Dasaxeleba = x.Dasaxeleba;
                obj.Raodenoba = x.Raodenoba;
                obj.Shenishvna = x.Shenishvna;

                //obj.Variety = String.Join(", ", x.ImmovableObjectsVariety.Select(v => v.Variety.Name));

                //                obj.PhotoAddress = !String.IsNullOrEmpty(x.PhotoAddress) ? Program.proxy + x.PhotoAddress : "";
                obj.linkPath = "objects/SportBuilding/DamxmareNagebobebiSatavsoebi?id=" + x.Objectid.ToString();
                //obj.objType = "immovable";
                //obj.mapType = "immovable";
                //obj.mapID = x.Id;
                list.Add(obj);
            }
            return list;
        }
        public DamxmareNagebobebiCustomClass getDamxmareNagebobebiObject(int id)
        {
            SportBuildingsContext con = new SportBuildingsContext();
            DamxmareNageboba dbobj = con.DamxmareNageboba.FirstOrDefault(m => m.Objectid == id);
            DamxmareNagebobebiCustomClass obj = new DamxmareNagebobebiCustomClass()
            {
                Objectid = dbobj.Objectid,
                Dasaxeleba = dbobj.Dasaxeleba,
                Danishnuleba = dbobj.Danishnuleba,
                Raodenoba = dbobj.Raodenoba,
                Area = dbobj.Area,
                Shenishvna = dbobj.Shenishvna,
                BuildingId = dbobj.BuildingId
            };
            return obj;
        }

        [HttpGet("[action]")]
        public List<Lkpregion> getLkpRegion()
        {
            SportBuildingsContext con = new SportBuildingsContext();
            List<Lkpregion> dbobj = con.Lkpregion.ToList();

            return dbobj;
        }
        [HttpGet("[action]")]
        public List<SportType> getLkpSportType()
        {
            SportBuildingsContext con = new SportBuildingsContext();
            List<SportType> dbobj = con.SportType.ToList();

            return dbobj;
        }

        [HttpPost("[action]")]
        public IActionResult AddObject([FromForm] SportBuildingCustomClass model)
        {
            SportBuildingsContext con = new SportBuildingsContext();
            string userID = null;
            if (User.Identity.Name != null)
            {
                userID = User.Identity.Name;
            }
            try
            {
                if (model.Objectid == 0)
                {
                    SportBuildings ob = new SportBuildings()
                    {
                        BuildingName = model.BuildingName,
                        Regioni = model.Regioni,
                        Raioni = model.Raioni,
                        Sofeli = model.Sofeli,
                        Qucha = model.Qucha
                    };
                    // ob.UserObjectPhotos = new List<UserObjectPhotos>();

                    //if (model.photos != null)
                    //{
                    //    foreach (var photo in model.photos)
                    //    {
                    //        if (photo != null)
                    //        {
                    //            MemoryStream target = new MemoryStream();
                    //            photo.OpenReadStream().CopyTo(target);
                    //            var data = target.ToArray();
                    //            ob.UserObjectPhotos.Add(new UserObjectPhotos() { Photo = data });
                    //        }
                    //    }
                    //}

                    con.SportBuildings.Add(ob);
                    // con.SaveChanges();
                    return Ok("");
                }
                else
                {
                    SportBuildings ob = con.SportBuildings.FirstOrDefault(x => x.Objectid == model.Objectid);
                    con.Entry(ob).CurrentValues.SetValues(model);

                    //   List<UserObjectPhotos> photos = new List<UserObjectPhotos>();

                    //if (ob.UserObjectPhotos != null)
                    //{
                    //    foreach (UserObjectPhotos uphoto in ob.UserObjectPhotos)
                    //    {
                    //        string photo = Convert.ToBase64String(uphoto.Photo);
                    //        string p = String.Format("data:image/jpg;base64,{0}", photo);

                    //        if (!model.images.Contains(p)) photos.Add(uphoto);
                    //    }

                    //    if (photos.Count > 0)
                    //    {
                    //        photos.ForEach(x => con.UserObjectPhotos.Remove(x));
                    //    }
                    //}

                    //if (model.photos != null)
                    //{
                    //    foreach (var photo in model.photos)
                    //    {
                    //        if (photo != null)
                    //        {
                    //            MemoryStream target = new MemoryStream();
                    //            photo.OpenReadStream().CopyTo(target);
                    //            var data = target.ToArray();
                    //            ob.UserObjectPhotos.Add(new UserObjectPhotos() { Photo = data });
                    //        }
                    //    }
                    //}

                    //  con.SaveChanges();
                    return Ok("");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, });
            }


            return Ok("");
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public class DamxmareNagebobebiCustomClass
        {
            public int Objectid { get; set; }
            public string Dasaxeleba { get; set; }
            public string Danishnuleba { get; set; }
            public string Raodenoba { get; set; }
            public decimal? Area { get; set; }
            public string Shenishvna { get; set; }
            public string BuildingId { get; set; }
            public string BuildingIdunic { get; set; }
            public short? F1 { get; set; }
        }
        public class SportBuildingCustomClass
        {
            public int Objectid { get; set; }
            public short? PassNumber { get; set; }
            public string BuildingName { get; set; }
            public string Creator { get; set; }
            public string Regioni { get; set; }
            public string Raioni { get; set; }
            public string Qalaqi { get; set; }
            public string Daba { get; set; }
            public string Sofeli { get; set; }
            public string Qucha { get; set; }
            public string Saxli { get; set; }
            public string TelNumber { get; set; }
            public string OwnedBy { get; set; }
            public string EqspSesvlisTariRi { get; set; }
            public string SabalansoRirebuleba { get; set; }
            public string ParcelArea { get; set; }
            public string SaqKodi { get; set; }
            public string Gengegma { get; set; }
            public string Gatboba { get; set; }
            public string ElKveba { get; set; }
            public string Ventilacia { get; set; }
            public string Kondicireba { get; set; }
            public string Radioficireba { get; set; }
            public string Interneti { get; set; }
            public string TeritorisSemogobva { get; set; }
            public string Wyalmomarageba { get; set; }
            public string TeqnikuriAgwera { get; set; }
            public string BuildingId { get; set; }
            public string Pictures { get; set; }
            public string Sakutreba { get; set; }
            public string Link { get; set; }
            public int? SportTypeId { get; set; }
            public string WebSite { get; set; }
            public string PostalCode { get; set; }
            public string Email { get; set; }
            public DateTime? DaarsebisWeli { get; set; }
            public string DawesebulebisXelmdzgvaneli { get; set; }
            public string OrganizaciisIuridiuliSaxelwodeba { get; set; }
            public string OrganizaciisIuridiuliStatusi { get; set; }
            public string GoogleMapCoordinates { get; set; }
            public string OrganizaciisXelmdzgvaneli { get; set; }
            public string OrganizaciisXelmdzgvanelisStatusi { get; set; }
            public string InformaciaAdaptirebulobis { get; set; }
            public string NagebobisStatusi { get; set; }
            public string NagebobisMdgomareoba { get; set; }
        }
    }
}
