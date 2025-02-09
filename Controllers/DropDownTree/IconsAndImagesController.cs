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

namespace EJ2CoreSampleBrowser.Controllers.DropDownTree
{
    public partial class DropDownTreeController : Controller
    {
        public IActionResult IconsAndImages()
        {
            return View();
        }
    }
}

public class ParentItem
{
    public string nodeId;
    public string nodeText;
    public string icon;
    public string image;
    public bool expanded;
    public List<ChildItem> child;
}
public class ChildItem
{
    public string nodeId;
    public string nodeText;
    public string icon;
    public string image;
    public bool expanded;
    public List<SubChild> child;
}
public class SubChild
{
    public string nodeId;
    public string nodeText;
    public string icon;
    public string image;
    public bool expanded;
}
