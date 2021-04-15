﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaExLivro.Data;
using ProvaExLivro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaExLivro.Controllers
{
    public class LivroController : Controller
    {
        private readonly IESContext _context;

        public LivroController(IESContext context)
        {
            _context = context;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            return View(await _context.Livros.OrderBy(l => l.LivroID).ToListAsync()); ;
        }
        #endregion

        #region Create - GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        #region Create - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Autor, Titulo, Genero, Editora, Idioma, DataPub, QtdePag")] Livro livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(livro);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(ex.Message, "Falha ao inserir");
            }
            return View(livro);
        }
        #endregion
    }
}
