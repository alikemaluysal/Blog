using NArchitecture.Core.Application.Responses;

namespace Application.Features.Posts.Commands.Update;

public class UpdatedPostResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
}