using DnD_Arena_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD_Arena_Web.Controllers
{
    public class NPCController : Controller
    {
        // GET: NPC
        public ViewResult Index()
        {
            NPC npc = new NPC() { Name = "Goblin" };

            return View(npc);
        }
    }
}