using Business.Entities;
using Business.Interfaces;

namespace Persistence.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MainContext _context;

        public CommentRepository(MainContext context)
        {
            _context = context;
        }

        public bool AddComment()
        {
            _context.Comments.Add(new Comment());
            return _context.SaveChanges() > 0;
        }
    }
}
