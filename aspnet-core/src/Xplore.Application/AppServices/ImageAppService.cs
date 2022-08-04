using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Xplore.AppServices
{
    [ApiExplorerSettings(GroupName = "Xplorer_Api", IgnoreApi = false)]
    public class
    ImageAppService
    :
    CrudAppService<Image, //The Book entity
        ImageDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateImageDto
    >, //Used to create/update a book
    IImageAppService //implement the IBookAppService
    {
        public ImageAppService(IRepository<Image, Guid> repository) :
            base(repository)
        {
        }
    }
}
