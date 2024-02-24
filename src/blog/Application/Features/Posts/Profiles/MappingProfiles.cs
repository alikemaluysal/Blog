using Application.Features.Posts.Commands.Create;
using Application.Features.Posts.Commands.Delete;
using Application.Features.Posts.Commands.Update;
using Application.Features.Posts.Queries.GetById;
using Application.Features.Posts.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Posts.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Post, CreatePostCommand>().ReverseMap();
        CreateMap<Post, CreatedPostResponse>().ReverseMap();
        CreateMap<Post, UpdatePostCommand>().ReverseMap();
        CreateMap<Post, UpdatedPostResponse>().ReverseMap();
        CreateMap<Post, DeletePostCommand>().ReverseMap();
        CreateMap<Post, DeletedPostResponse>().ReverseMap();
        CreateMap<Post, GetByIdPostResponse>().ReverseMap();
        CreateMap<Post, GetListPostListItemDto>().ReverseMap();
        CreateMap<IPaginate<Post>, GetListResponse<GetListPostListItemDto>>().ReverseMap();
    }
}