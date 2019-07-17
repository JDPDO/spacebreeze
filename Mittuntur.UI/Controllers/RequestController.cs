﻿using JDPDO.Mittuntur.UI.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace JDPDO.Mittuntur.UI.Controllers
{
    [ApiController, Route("Request")]
    public class RequestController : ControllerBase
    {
        [HttpGet("{uri}")]
        public IActionResult GetDirectoryContentIActionResult(string uri)
        {
            return null;
        }

        public IEnumerable<IFileSystemItem> GetDirectoryContent(string uri)
        {
            FileTree<LocalDirectory> fileTree = new FileTree<LocalDirectory>(uri);
            return fileTree.GetChildren();
        }
    }
}