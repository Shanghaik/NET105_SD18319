using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreeController : ControllerBase
    {
        [HttpGet("get-fake-tree")]
        public ActionResult GetFakeTree()
        {
            List<Tree> tree = new List<Tree>()
            {
                new Tree() {Name = "KICM", Description = "Nhạc sỹ liêm khiết"},
                new Tree() {Name = "JJK", Description = "Hội 1/2"},
                new Tree() {Name = "Cây phấn đào", Description = "Mọc ở chân đèo"}
            };
            return Ok(tree);
        }
        [HttpPost("get-tree-by-name")] // Cái này viết ra để mình test và nhớ thôi/ đừng thử 
        public ActionResult GetTreeDetails(string name, List<Tree> trees)
        {
            Tree tree = trees.FirstOrDefault(x => x.Name == name);
            return Ok(tree);
        }
    }
    public class Tree
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
