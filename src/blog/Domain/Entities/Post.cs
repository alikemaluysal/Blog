using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Post : Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }

    public virtual User User { get; set; }
    public virtual Category Category { get; set; }
    public virtual List<Comment> Comments { get; set; }


}
