using System;
using System.Linq;
using System.Threading.Tasks;
using Group3.Services;
using Lib;
using Microsoft.AspNetCore.Mvc;

namespace Group3.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: Comment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var comment = await _commentService.GetCommentByIdAsync(id.Value);

            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Comment,CommentOn,Rating")] ArticleComment comment)
        {
            if (ModelState.IsValid)
            {
                await _commentService.CreateCommentAsync(comment);
                return RedirectToAction(nameof(Index));
            }
            return View(comment);
        }

        // GET: Comment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var comment = await _commentService.GetCommentByIdAsync(id.Value);

            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        // POST: Comment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Comment,CommentOn,Rating")] ArticleComment comment)
        {
            if (id != comment.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _commentService.UpdateCommentAsync(comment);
                }
                catch (Exception)
                {
                    if (!_commentService.CommentExists(comment.Id))
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
            return View(comment);
        }

        // GET: Comment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var comment = await _commentService.GetCommentByIdAsync(id.Value);

            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _commentService.DeleteCommentAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            // Add code to retrieve a list of comments if needed.
            return View();
        }
    }
}
