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
    WishListAppService
    :
    CrudAppService<WishList, //The Book entity
        WishListDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateWishListDto
    >, //Used to create/update a book
    IWishListAppService //implement the IBookAppService
    {
        public WishListAppService(IRepository<WishList, Guid> repository) :
            base(repository)
        {
        }
    }
}
