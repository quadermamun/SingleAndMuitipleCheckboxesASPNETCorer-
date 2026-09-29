using CheckboxesAspCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckboxesAspCore.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            var model = new ViewModel()
            {       
                CheckBoxes= new List<CheckboxOption>()
                {
                    new CheckboxOption()
                    {
                        IsChecked = true,
                        Text="Cricket",
                        Value ="Cricket"
                    },

                    new CheckboxOption()
                    {
                        IsChecked = false,
                        Text="Football",
                        Value ="Football"
                    },
                    new CheckboxOption()
                    {
                        IsChecked = false,
                        Text="Hockey",
                        Value ="Hockey"
                    }
                }
            };

            return View(model);
        }

        //public IActionResult Index()
        //{
        //    var model = new ViewModel()
        //    {
        //        AcceptTerms=false,
        //        Text="I accept the terms"
        //    };

        //    return View(model);
        //}

        [HttpPost]
        public IActionResult Index(ViewModel data)
        {
            //var value=data.AcceptTerms;


            var model = new ViewModel()
            {
                CheckBoxes = new List<CheckboxOption>()
                {
                    new CheckboxOption()
                    {
                        IsChecked = true,
                        Text="Cricket",
                        Value ="Cricket"
                    },

                    new CheckboxOption()
                    {
                        IsChecked = false,
                        Text="Football",
                        Value ="Football"
                    },
                    new CheckboxOption()
                    {
                        IsChecked = false,
                        Text="Hockey",
                        Value ="Hockey"
                    }
                }
            };

            foreach (var item in data.Sports)
            {
                foreach (var checkboc in model.CheckBoxes)
                {
                    if(checkboc.Text == item)
                        checkboc.IsChecked = true;
                }

            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
