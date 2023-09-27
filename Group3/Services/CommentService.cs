using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group3.Repository;
using Lib;

namespace Group3.Services
{
    public class CommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<ArticleComment> GetCommentByIdAsync(int id)
        {
            return await _commentRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ArticleComment>> GetCommentsByArticleIdAsync(int articleId)
        {
            return await _commentRepository.GetAllByArticalIdAsync(articleId);
        }

        public async Task<double> GetAverageRating(int articleId)
        {
            var comments = await GetCommentsByArticleIdAsync(articleId);
            if (comments.Any())
            {
                return comments.Average(c => c.Rating);
            }
            return 0;
        }

        public async Task CreateCommentAsync(ArticleComment comment)
        {
            await _commentRepository.CreateAsync(comment);
        }

        public async Task UpdateCommentAsync(ArticleComment comment)
        {
            await _commentRepository.UpdateAsync(comment);
        }

        public async Task DeleteCommentAsync(int id)
        {
            await _commentRepository.DeleteAsync(id);
        }

        public bool CommentExists(int id)
        {
            // Thực hiện kiểm tra xem comment có tồn tại dựa trên id hoặc logic kiểm tra của bạn.
            // Trả về true nếu comment tồn tại, ngược lại trả về false.
            // Ví dụ:
            var existingComment = _commentRepository.GetByIdAsync(id).Result;
            return existingComment != null;
        }
    }
}
