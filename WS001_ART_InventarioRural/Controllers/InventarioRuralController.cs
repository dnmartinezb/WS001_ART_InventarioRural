using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS001_ART_InventarioRural.Data;
using WS001_ART_InventarioRural.Models;

namespace WS001_ART_InventarioRural.Controllers
{
    [Route("WS001/[controller]")]
    [ApiController]
    public class InventarioRuralController : ControllerBase
    {
        private readonly WS001_ART_InventarioRuralContext _context;

        public InventarioRuralController(WS001_ART_InventarioRuralContext context)
        {
            _context = context;
        }

        // GET: WS001/InventarioRural
        [HttpGet]
        public ActionResult<IEnumerable<InventarioRural>> GetInventarioRural()
        {
            return _context
                        .InventarioRural
                        .FromSqlRaw("exec WS001_ART_InventarioRural_ObtenerDetalleInventario_sp")
                        .ToList();
        }
    }
}
