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
       
        public IActionResult Details(int? id) //İndex action methodu oluşturduk.
        {
            if (id == null)
            {
                // return Redirect("/course/list"); //id null ise liste sayfasına yönlendir.
                return RedirectToAction("List"); //id null ise liste sayfasına yönlendir. Redirect'e alternatif bir yöntem.
            }
            var kurs = Repostory.GetById(id);
            return View(kurs); 
           
        }
        
        public IActionResult List() //List action methodu oluşturduk.
        {

            return View("CourseList", Repostory.Courses); //Views klasörünün içindeki Course klasörünün içindeki CourseList.cshtml dosyasını döndürüyor.
        }
    }
} 