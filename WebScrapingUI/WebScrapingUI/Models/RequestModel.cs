using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BaseScraperLibrary;
using WebScrapingUI.Resources;

namespace WebScrapingUI.Models
{
    public class RequestModel
    {
        public Dictionary<string, bool> AllSites { get; set; }
        public List<string> CheckedSites { get; set; }

        public AvailableCurrencies? Currency { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }

        [Required]
        //[Display(Name = "Required", ResourceType = typeof(Home))]
        public string ItemName { get; set; }

        [Required]
        //[Display(Name = "Required", ResourceType = typeof(Home))]
        public int ItemCount { get; set; }

        public RequestModel()
        {
            CheckedSites = new List<string>();
            AllSites = new Dictionary<string, bool>();
        }
    }
}
