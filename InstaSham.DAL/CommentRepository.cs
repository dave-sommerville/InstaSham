using InstaSham.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaSham.DAL
{
    public class CommentRepository
    {
        private readonly InstaShamContext _context;
        public CommentRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<Comment> GetAllComments()
        {
            return _context.Comments.ToList();
        }
        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
