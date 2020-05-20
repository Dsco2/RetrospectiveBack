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

        public bool AddComment()
        {
            return _commentRepository.AddComment();
        }
    }
}
