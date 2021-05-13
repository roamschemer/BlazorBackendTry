using BlazorBackendTry.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBackendTry.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class VTuberController : ControllerBase {
        [HttpGet]
        public ActionResult<IEnumerable<VTuber>> Get() {
            return new List<VTuber>() {
                new VTuber() { Name = "想間ミレイ", Type = "バ蠱毒wiki" },
                new VTuber() { Name = "巻乃もなか", Type = "工具" },
                new VTuber() { Name = "セヲハヤミ", Type = "私ハ自由ダ" },
                new VTuber() { Name = "御掬この子", Type = "人狼クォーター" },
                new VTuber() { Name = "ばぶかす", Type = "人造人間" }
            }.ToArray();
        }
        [HttpGet("id/{id}")]
        public ActionResult<VTuber> GetName(int id) {
            var list = new List<VTuber>() {
                new VTuber() { Name = "想間ミレイ", Type = "バ蠱毒wiki" },
                new VTuber() { Name = "巻乃もなか", Type = "工具" },
                new VTuber() { Name = "セヲハヤミ", Type = "私ハ自由ダ" },
                new VTuber() { Name = "御掬この子", Type = "人狼クォーター" },
                new VTuber() { Name = "ばぶかす", Type = "人造人間" }
            }.ToArray();
            return list[id];
        }
    }
}
