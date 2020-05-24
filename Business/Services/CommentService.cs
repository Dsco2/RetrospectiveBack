using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public List<Comment> GetComments()
        {
            return _commentRepository.GetComments();
        }

        public bool SetComment(Comment comment)
        {
            return _commentRepository.SetComment(comment);
        }
    }
}
