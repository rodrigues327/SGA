using AutoMapper;
using SGA.Application.Interfaces;
using SGA.Application.ViewModel;
using StructureMap;
using System.Net;
using System.Web.Mvc;

namespace SGA.Web.Controllers
{
    public class InstituicaoController : Controller
    {
        private readonly IMapper _mapper;

        private readonly IInstituicaoAppService _instituicaoService;

        public InstituicaoController(IContainer iocContainer)
        {
            _mapper = iocContainer.GetInstance<IMapper>();
            _instituicaoService = iocContainer.GetInstance<IInstituicaoAppService>();
        }

        // GET: Instituicaos
        public ActionResult Index()
        {
            var viewModels = _instituicaoService.GetAll();

            return View(viewModels);
        }

        // GET: Instituicaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instituicaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InstituicaoViewModel instituicao)
        {
            if (ModelState.IsValid)
            {
                _instituicaoService.Add(instituicao);

                return RedirectToAction("Index");
            }

            return View(instituicao);
        }

        // GET: Instituicaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var instituicao = _mapper.Map<InstituicaoViewModel>(_instituicaoService.GetById(id.Value));

            if (instituicao == null)
            {
                return HttpNotFound();
            }

            return View(instituicao);
        }

        // POST: Instituicaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InstituicaoViewModel instituicao)
        {
            if (ModelState.IsValid)
            {
                _instituicaoService.Update(instituicao);

                return RedirectToAction("Index");
            }
            return View(instituicao);
        }

        // GET: Instituicaos/Delete/5
        [HttpGet, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _instituicaoService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}