using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport_Buildings.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Authorization;

namespace Sport_Buildings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //public iactionresult index()
        //{
        //    return view();
        //}
    }
    public class MainPageObjectList
    {
        public int ID { get; set; }
        public string ObjectName { get; set; }
        public string Variety { get; set; }
        public string DocNum { get; set; }
        public string Address { get; set; }
        public string PhotoAddress { get; set; }
        public string FileAddress { get; set; }
        public string Author { get; set; }
        public string AuthorAll { get; set; }
        public string linkPath { get; set; }
        public string Period { get; set; }
        public bool isChecked { get; set; }
        public string objType { get; set; }
        public bool isPublic { get; set; }
        public string mapType { get; set; }
        public int mapID { get; set; }
    }

    public class DamxmareNagebobebiSatavsoebiObjectList
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
        public string linkPath { get; set; }
    }
}