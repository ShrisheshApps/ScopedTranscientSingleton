using Microsoft.AspNetCore.Mvc;
using ScopedServiceDemo.Repository;

namespace ScopedServiceDemo.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ISingleRepository singleRepository1;
        private readonly ISingleRepository singleRepository2;
        private readonly IScopedRepository scopedRepository1;
        private readonly IScopedRepository scopedRepository2;
        private readonly ITranscientRepository transcientRepository1;
        private readonly ITranscientRepository transcientRepository2;

        public HomeController(ISingleRepository SingleRepository1, ISingleRepository SingleRepository2,
            IScopedRepository ScopedRepository1, IScopedRepository ScopedRepository2,
            ITranscientRepository TranscientRepository1, ITranscientRepository TranscientRepository2
            )
        {
            this.singleRepository1 = SingleRepository1;
            this.singleRepository2 = SingleRepository2;
            this.scopedRepository1 = ScopedRepository1;
            this.scopedRepository2 = ScopedRepository2;
            this.transcientRepository1 = TranscientRepository1;
            this.transcientRepository2 = TranscientRepository2;
        }
        public ContentResult Index()
        {
            var res1 = singleRepository1.Counter().ToString();
            var res2 = singleRepository2.Counter().ToString();
            var res3 = scopedRepository1.Counter().ToString();
            var res4 = scopedRepository2.Counter().ToString();
            var res5 = transcientRepository1.Counter().ToString();
            var res6 = transcientRepository2.Counter().ToString();
            var data = $"<h1>Refresh to update.</h1><h1>Single: {res1} and {res2}</h1><h1>Scoped: {res3} and {res4}</h1><h1>Transcient: {res5} and {res6}</h1>";
            return Content(data, "text/html", System.Text.Encoding.UTF8);
        }
    }
}
