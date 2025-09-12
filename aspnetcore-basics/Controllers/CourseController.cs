using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnetcore_basics.Controllers //ilk olarak namespace Oluşturacağız. Namespace projemizin ismi ile aynı olmalı.  yani ilk önce projemizin ismi sonrada Klasör ismi gelmeli.

{
    public class CourseController : Controller //Controller klası oluşturduk ve Controller class'ından miras aldık.  #using Microsoft.AspNetCore.Mvc; Kütüphanesi eklendi projeye.
    {
        //Action methodlarımızı oluşturacağız. Action methodlar controller içindeki metotlardır. Her action method bir view döner.
        //Action methodlar public olmalı ve geriye IActionResult döndürmeli. view döndürür bu IActionResult türü.
        //Eğer string döndüreceksek geriye string döndürebiliriz.
        //Action methodların ismi büyük harfle başlamalı.   
        // Her action method bir view döner.
        public IActionResult Index() //İndex action methodu oluşturduk.
        {
            var kurs = new Course(); //Course sınıfından bir nesne oluşturduk.

            kurs.Id = 1; //Id property'sine değer atadık.
            kurs.Title = "Asp.Net Core 8.0"; //Title property'sine değer atadık.
            kurs.Description = "Asp.Net Core 8.0 Eğitimi"; //Description property'sine değer atadık.
            kurs.Image = "1.jpg"; //Image property'sine değer atadık.
            
            return View(kurs); //View döndürüyoruz. Views klasörünün içindeki Course klasörünün içindeki Index.cshtml dosyasını döndürüyor.
        }
         public IActionResult Details() //İndex action methodu oluşturduk.
        {
            var kurs = new Course(); //Course sınıfından bir nesne oluşturduk.

            kurs.Id = 1; //Id property'sine değer atadık.
            kurs.Title = "Asp.Net Core 8.0"; //Title property'sine değer atadık.
            kurs.Description = "Asp.Net Core 8.0 Eğitimi"; //Description property'sine değer atadık.
            kurs.Image = "1.jpg"; //Image property'sine değer atadık.
            
            return View(kurs); //View döndürüyoruz. Views klasörünün içindeki Course klasörünün içindeki Index.cshtml dosyasını döndürüyor.
        }
        
        public IActionResult List() //List action methodu oluşturduk.
        {

            return View("CourseList", Repostory.Courses); //Views klasörünün içindeki Course klasörünün içindeki CourseList.cshtml dosyasını döndürüyor.
        }
    }
} 