using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    CommentAppService
    :
    CrudAppService<Comment, //The Book entity
        CommentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCommentDto
    >, //Used to create/update a book
    ICommentAppService //implement the IBookAppService
    {
        public CommentAppService(IRepository<Comment, Guid> repository) :
            base(repository)
        {
        }
    }
}
