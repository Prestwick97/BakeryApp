using Sytem.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryApp.Models;

namespace BakeryApp.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    
  }
}