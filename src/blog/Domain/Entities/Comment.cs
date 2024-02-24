using NArchitecture.Core.Persistence.Repositories;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Comment : Entity<Guid>
{
    public string Content { get; set; }
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }

    public virtual User User { get; set; }
    public virtual Post Post { get; set; }
}