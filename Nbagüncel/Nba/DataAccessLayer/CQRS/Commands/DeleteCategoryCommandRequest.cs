using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.CQRS.Commands
{
    public class DeleteCategoryCommandRequest : IRequest
    {
        public int CategoryID { get; set; }
        public DeleteCategoryCommandRequest(int id)
        {
            CategoryID = id;
        }
    }
}
