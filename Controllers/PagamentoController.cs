#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ryanAps.Models;

namespace ryanAps.Controllers
{
    public class PagamentoController : Controller
    {
        private readonly MyDbContext _context;

        public PagamentoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Pagamento
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Pagamento.Include(p => p.NotaDeVenda);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Pagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento
                .Include(p => p.NotaDeVenda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            return View(pagamento);
        }

        // GET: Pagamento/Create
        public IActionResult Create()
        {
            ViewData["NotaDeVendaId"] = new SelectList(_context.NotaDeVenda, "Id", "Id");
            return View();
        }

        // POST: Pagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataLimite,Valor,Pago,NotaDeVendaId")] Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NotaDeVendaId"] = new SelectList(_context.NotaDeVenda, "Id", "Id", pagamento.NotaDeVendaId);
            return View(pagamento);
        }

        // GET: Pagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento.FindAsync(id);
            if (pagamento == null)
            {
                return NotFound();
            }
            ViewData["NotaDeVendaId"] = new SelectList(_context.NotaDeVenda, "Id", "Id", pagamento.NotaDeVendaId);
            return View(pagamento);
        }

        // POST: Pagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataLimite,Valor,Pago,NotaDeVendaId")] Pagamento pagamento)
        {
            if (id != pagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagamentoExists(pagamento.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["NotaDeVendaId"] = new SelectList(_context.NotaDeVenda, "Id", "Id", pagamento.NotaDeVendaId);
            return View(pagamento);
        }

        // GET: Pagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento
                .Include(p => p.NotaDeVenda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            return View(pagamento);
        }

        // POST: Pagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pagamento = await _context.Pagamento.FindAsync(id);
            _context.Pagamento.Remove(pagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagamentoExists(int id)
        {
            return _context.Pagamento.Any(e => e.Id == id);
        }
    }
}
