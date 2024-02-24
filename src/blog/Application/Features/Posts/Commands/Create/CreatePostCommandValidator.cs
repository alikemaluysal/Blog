using FluentValidation;

namespace Application.Features.Posts.Commands.Create;

public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
{
    public CreatePostCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Content).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.CategoryId).NotEmpty();
    }
}