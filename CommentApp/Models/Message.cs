using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommentApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }

        public Message()
        {

        }
    }
}
