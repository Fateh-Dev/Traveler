using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    TripAppService
    :
    CrudAppService<Trip, //The Book entity
        TripDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateTripDto
    >, //Used to create/update a book
    ITripAppService //implement the IBookAppService
    {
        public TripAppService(IRepository<Trip, Guid> repository) :
            base(repository)
        {
        }
    }
}
