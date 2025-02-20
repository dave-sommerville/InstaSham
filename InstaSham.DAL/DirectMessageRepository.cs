using InstaSham.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaSham.DAL
{
    public class DirectMessageRepository
    {
        private readonly InstaShamContext _context;
        public DirectMessageRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<DirectMessage> GetAllDirectMessages()
        {
            return _context.DirectMessages.ToList();
        }
        public void AddComment(DirectMessage directMessage)
        {
            _context.DirectMessages.Add(directMessage);
            _context.SaveChanges();
        }
    }
}
