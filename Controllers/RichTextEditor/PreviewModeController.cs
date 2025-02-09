#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class RichtextEditorController : Controller
    {
        public IActionResult PreviewMode()
        {
            ViewBag.items = new object[] {"Bold", "Italic", "StrikeThrough", "|", "Formats", "OrderedList", "UnorderedList", "|", "CreateTable", "CreateLink", "Image", "|",
                new {
                tooltipText =  "Preview", template = @"<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn'>
                      <span class='e-btn-icon e-md-preview e-icons'></span></button>" },
                new {
                tooltipText = "Split Editor", template = @"<button id='MD_Preview' class='e-tbar-btn e-control e-btn e-icon-btn'>
                      <span class='e-btn-icon e-view-side e-icons'></span></button>" }, "FullScreen", "|", "Undo", "Redo" };
            return View();
        }
    }
}
