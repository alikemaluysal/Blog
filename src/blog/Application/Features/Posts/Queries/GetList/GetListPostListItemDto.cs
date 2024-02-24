using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Posts.Queries.GetList;

public class GetListPostListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
}