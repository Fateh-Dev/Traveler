using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Xplore.Models;

namespace Xplore
{
    

    public interface
    IEnumerationAppService
    :
    ICrudAppService<//Defines CRUD methods
        EnumerationDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEnumerationDto
    > //Used to create/update a book
    { }

    public interface
    IGuideAppService
    :
    ICrudAppService<//Defines CRUD methods
        GuideDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateGuideDto
    > //Used to create/update a book
    { }

    public interface
    IImageAppService
    :
    ICrudAppService<//Defines CRUD methods
        ImageDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateImageDto
    > //Used to create/update a book
    { }

    public interface
    ILocationAppService
    :
    ICrudAppService<//Defines CRUD methods
        LocationDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateLocationDto
    > //Used to create/update a book
    { }

    public interface
    IPriceAppService
    :
    ICrudAppService<//Defines CRUD methods
        PriceDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePriceDto
    > //Used to create/update a book
    { }

    public interface
    IRatingAppService
    :
    ICrudAppService<//Defines CRUD methods
        RatingDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateRatingDto
    > //Used to create/update a book
    { }

    public interface
    IReviewAppService
    :
    ICrudAppService<//Defines CRUD methods
        ReviewDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateReviewDto
    > //Used to create/update a book
    { }

    public interface
    IScheduleAppService
    :
    ICrudAppService<//Defines CRUD methods
        ScheduledTripDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateScheduledTripDto
    > //Used to create/update a book
    { }

    public interface
    ISubscribeAtAppService
    :
    ICrudAppService<//Defines CRUD methods
        SubscribeAtDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSubscribeAtDto
    > //Used to create/update a book
    { }

    public interface
    ITouristAppService
    :
    ICrudAppService<//Defines CRUD methods
        TouristDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateTouristDto
    > //Used to create/update a book
    { }

    public interface
    ITripAppService
    :
    ICrudAppService<//Defines CRUD methods
        TripDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateTripDto
    > //Used to create/update a book
    { }

    public interface
    IWishListAppService
    :
    ICrudAppService<//Defines CRUD methods
        WishListDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateWishListDto
    > //Used to create/update a book
    { }
}
