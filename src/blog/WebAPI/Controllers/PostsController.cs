using Application.Features.Posts.Commands.Create;
using Application.Features.Posts.Commands.Delete;
using Application.Features.Posts.Commands.Update;
using Application.Features.Posts.Queries.GetById;
using Application.Features.Posts.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePostCommand createPostCommand)
    {
        CreatedPostResponse response = await Mediator.Send(createPostCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePostCommand updatePostCommand)
    {
        UpdatedPostResponse response = await Mediator.Send(updatePostCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedPostResponse response = await Mediator.Send(new DeletePostCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdPostResponse response = await Mediator.Send(new GetByIdPostQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPostQuery getListPostQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPostListItemDto> response = await Mediator.Send(getListPostQuery);
        return Ok(response);
    }
}