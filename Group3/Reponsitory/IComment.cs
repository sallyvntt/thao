using Group3.Models;
using Lib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group3.Repository
{
    public interface ICommentRepository
    {
        Task<IEnumerable<ArticleComment>> GetAllByArticalIdAsync(int articleId);
        Task<ArticleComment> GetByIdAsync(int id);
        Task CreateAsync(ArticleComment comment);
        Task UpdateAsync(ArticleComment comment);
        Task DeleteAsync(int id);
    }
}
