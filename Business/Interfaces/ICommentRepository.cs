using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetComments();
        bool SetComment(Comment comment);
    }
}
