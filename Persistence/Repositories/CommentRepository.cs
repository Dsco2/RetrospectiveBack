using System.Collections.Generic;
using System.Linq;
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

        public List<Comment> GetComments()
        {
            var data = _context.Comments.ToList();
            return data;
        }

        public bool SetComment(Comment comment)
        {
            _context.Comments.Add(comment);
            return _context.SaveChanges() > 0;
        }
    }
}
