using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ICommentService
    {
        List<Comment> GetComments();
        bool SetComment(Comment comment);
    }
}
