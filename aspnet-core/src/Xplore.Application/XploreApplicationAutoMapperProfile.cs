using System.Collections.Generic;
using AutoMapper;
using Xplore.Models;

namespace Xplore;

public class XploreApplicationAutoMapperProfile : Profile
{
    public XploreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */ 
         CreateMap<Enumeration, EnumerationDto>(); 
         CreateMap<CreateUpdateEnumerationDto, Enumeration>();
         CreateMap<Guide, GuideDto>();
         CreateMap<CreateUpdateGuideDto, Guide>();
         CreateMap<Image, ImageDto>();
         CreateMap<CreateUpdateImageDto, Image>();
         CreateMap<Location, LocationDto>();
         CreateMap<CreateUpdateLocationDto, Location>();
         CreateMap<Price, PriceDto>();
         CreateMap<CreateUpdatePriceDto, Price>();
         CreateMap<Rating, RatingDto>();
         CreateMap<CreateUpdateRatingDto, Rating>();
         CreateMap<Review, ReviewDto>();
         CreateMap<CreateUpdateReviewDto, Review>();
         CreateMap<ScheduledTrip, ScheduledTripDto>(); 
         CreateMap<CreateUpdateScheduledTripDto, ScheduledTrip>();
         CreateMap<SubscribeAt, SubscribeAtDto>();
         CreateMap<CreateUpdateSubscribeAtDto, SubscribeAt>();
         CreateMap<Tourist, TouristDto>();
         CreateMap<CreateUpdateTouristDto, Tourist>();
         CreateMap<Trip, TripDto>();
         CreateMap<Trip, TripMiniDto>();
         CreateMap<Trip, TripMiniDto>();
         CreateMap<CreateUpdateTripDto, Trip>();
         CreateMap<WishList, WishListDto>();
         CreateMap<CreateUpdateWishListDto, WishList>();
    }
}
