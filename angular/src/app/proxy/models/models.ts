import type { EnumType } from '../enum-type.enum';
import type { Gender } from '../gender.enum';
import type { Wilaya } from '../wilaya.enum';
import type { LocationType } from '../location-type.enum';
import type { PriceCategory } from '../price-category.enum';
import type { RatingType } from '../rating-type.enum';
import type { Difficulty } from '../difficulty.enum';
import type { DurationUnit } from '../duration-unit.enum';
import type { AuditedAggregateRoot, FullAuditedAggregateRoot } from '../volo/abp/domain/entities/auditing/models';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateEnumerationDto {
  code: string;
  value: string;
  type: EnumType;
  displayEn?: string;
  displayAn?: string;
  displayFr?: string;
}

export interface CreateUpdateGuideDto {
  firstname: string;
  lastname: string;
  username?: string;
  email?: string;
  profilePic: number[];
  birthday?: string;
  description?: string;
  languages?: string;
  picture?: string;
  gender: Gender;
  phoneNumber?: string;
  country?: string;
  wilaya: Wilaya;
  city?: string;
  zipCode: number;
  address?: string;
  address2?: string;
  activities?: string;
  facebook?: string;
  instagram?: string;
  twitter?: string;
  youtube?: string;
}

export interface CreateUpdateImageDto {
  tripId: string;
  data: number[];
  description?: string;
}

export interface CreateUpdateLocationDto {
  description: string;
  gpsLocation: string;
  tripId: string;
  type: LocationType;
  order?: number;
}

export interface CreateUpdatePriceDto {
  category: PriceCategory;
  value?: number;
  scheduledTripId?: string;
}

export interface CreateUpdateRatingDto {
  value: number;
  type: RatingType;
  reviewId?: string;
}

export interface CreateUpdateReviewDto {
  touristId?: string;
  comment?: string;
  rating: number;
  scheduledTripId?: string;
}

export interface CreateUpdateScheduledTripDto {
  date?: string;
  description?: string;
  tripId?: string;
}

export interface CreateUpdateSubscribeAtDto {
  scheduledTripId?: string;
  touristId?: string;
}

export interface CreateUpdateTouristDto {
  firstname?: string;
  lastname?: string;
  username?: string;
  birthday?: string;
  email?: string;
  description?: string;
  languages?: string;
  picture?: string;
  gender: Gender;
  phoneNumber?: string;
  country?: string;
  wilaya: Wilaya;
  city?: string;
  zipCode: number;
  address?: string;
  address2?: string;
}

export interface CreateUpdateTripDto {
  title: string;
  description: string;
  rating: number;
  duration: number;
  glanguages?: string;
  thumbnail: number[];
  difficulty: Difficulty;
  tripSize?: number;
  guideId?: string;
  durationUnit: DurationUnit;
  date?: string;
  startingTime?: string;
  agency?: string;
  idAchived: boolean;
  isValidated: boolean;
  activities?: string;
  risks?: string;
  notAllowedStuff?: string;
  requiredStuff?: string;
  notSuitableFor?: string;
  includedStuff?: string;
  loging?: string;
}

export interface CreateUpdateWishListDto {
  idTrip?: string;
  idTourist?: string;
}

export interface Enumeration extends FullAuditedAggregateRoot<string> {
  code?: string;
  value?: string;
  displayEn?: string;
  displayAn?: string;
  displayFr?: string;
  type: EnumType;
}

export interface EnumerationDto extends AuditedEntityDto<string> {
  code?: string;
  value?: string;
  displayEn?: string;
  displayAn?: string;
  displayFr?: string;
  type: EnumType;
}

export interface Guide extends FullAuditedAggregateRoot<string> {
  firstname?: string;
  lastname?: string;
  username?: string;
  email?: string;
  birthday?: string;
  description?: string;
  languages?: string;
  picture?: string;
  gender: Gender;
  phoneNumber?: string;
  country?: string;
  wilaya: Wilaya;
  city?: string;
  zipCode: number;
  address?: string;
  address2?: string;
  activities?: string;
  facebook?: string;
  instagram?: string;
  twitter?: string;
  youtube?: string;
  trips: Trip[];
}

export interface GuideDto extends AuditedEntityDto<string> {
  firstname?: string;
  lastname?: string;
  username?: string;
  email?: string;
  profilePic: number[];
  birthday?: string;
  description?: string;
  languages?: string;
  picture?: string;
  gender: Gender;
  phoneNumber?: string;
  country?: string;
  wilaya: Wilaya;
  city?: string;
  zipCode: number;
  address?: string;
  address2?: string;
  activities?: string;
  facebook?: string;
  instagram?: string;
  twitter?: string;
  youtube?: string;
  trips: TripMiniDto[];
}

export interface Image extends AuditedAggregateRoot<string> {
  url?: string;
  description?: string;
  tripId?: string;
  trip: Trip;
}

export interface ImageDto extends AuditedEntityDto<string> {
  data: number[];
  description?: string;
  tripId?: string;
}

export interface Location extends FullAuditedAggregateRoot<string> {
  description?: string;
  gpsLocation?: string;
  tripId?: string;
  trip: Trip;
  type: LocationType;
  order?: number;
}

export interface LocationDto extends AuditedEntityDto<string> {
  description?: string;
  gpsLocation?: string;
  tripId?: string;
  type: LocationType;
  order?: number;
}

export interface Price extends FullAuditedAggregateRoot<string> {
  category: PriceCategory;
  value?: number;
  scheduledTripId?: string;
  scheduledTrip: ScheduledTrip;
}

export interface PriceDto extends AuditedEntityDto<string> {
  category: PriceCategory;
  value?: number;
  scheduledTripId?: string;
  scheduledTrip: ScheduledTripDto;
}

export interface Rating extends FullAuditedAggregateRoot<string> {
  value: number;
  type: RatingType;
  reviewId?: string;
  review: Review;
}

export interface RatingDto extends AuditedEntityDto<string> {
  value: number;
  type: RatingType;
  reviewId?: string;
  review: ReviewDto;
}

export interface Review extends FullAuditedAggregateRoot<string> {
  touristId?: string;
  tourist: Tourist;
  comment?: string;
  rating: number;
  scheduledTripId?: string;
  scheduledTrip: ScheduledTrip;
  ratings: Rating[];
}

export interface ReviewDto extends AuditedEntityDto<string> {
  touristId?: string;
  tourist: TouristDto;
  comment?: string;
  rating: number;
  scheduledTripId?: string;
  scheduledTrip: ScheduledTripDto;
  ratings: RatingDto[];
}

export interface ScheduledTrip extends FullAuditedAggregateRoot<string> {
  date?: string;
  description?: string;
  tripId?: string;
  trip: Trip;
  prices: Price[];
  reviews: Review[];
  subscribedTourists: SubscribeAt[];
}

export interface ScheduledTripDto extends AuditedEntityDto<string> {
  date?: string;
  description?: string;
  tripId?: string;
  trip: TripDto;
  prices: PriceDto[];
  reviews: ReviewDto[];
  subscribedTourists: SubscribeAtDto[];
}

export interface SubscribeAt extends FullAuditedAggregateRoot<string> {
  scheduledTripId?: string;
  scheduledTrip: ScheduledTrip;
  touristId?: string;
  tourist: Tourist;
}

export interface SubscribeAtDto extends AuditedEntityDto<string> {
  scheduledTripId?: string;
  scheduledTrip: ScheduledTripDto;
  touristId?: string;
  tourist: TouristDto;
}

export interface Tourist extends FullAuditedAggregateRoot<string> {
  firstname?: string;
  lastname?: string;
  username?: string;
  birthday?: string;
  email?: string;
  description?: string;
  languages?: string;
  picture?: string;
  gender: Gender;
  phoneNumber?: string;
  country?: string;
  wilaya?: string;
  city?: string;
  zipCode: number;
  address?: string;
  address2?: string;
  reviews: Review[];
  wishLists: WishList[];
  subscribedTrips: SubscribeAt[];
}

export interface TouristDto extends AuditedEntityDto<string> {
  firstname?: string;
  lastname?: string;
  username?: string;
  birthday?: string;
  email?: string;
  description?: string;
  languages?: string;
  picture?: string;
  gender: Gender;
  phoneNumber?: string;
  country?: string;
  wilaya: Wilaya;
  city?: string;
  zipCode: number;
  address?: string;
  address2?: string;
  reviews: ReviewDto[];
  wishLists: WishListDto[];
  subscribedTrips: SubscribeAtDto[];
}

export interface Trip extends FullAuditedAggregateRoot<string> {
  title?: string;
  description?: string;
  rating: number;
  duration: number;
  glanguages?: string;
  thumbnailPic?: string;
  tripSize?: number;
  durationUnit: DurationUnit;
  difficulty: Difficulty;
  date?: string;
  startingTime?: string;
  agency?: string;
  idAchived?: string;
  activities?: string;
  risks?: string;
  notAllowedStuff?: string;
  requiredStuff?: string;
  notSuitableFor?: string;
  includedStuff?: string;
  loging?: string;
  guideId?: string;
  guide: Guide;
  locations: Location[];
  images: Image[];
  scheduledTrips: ScheduledTrip[];
  potentialClients: WishList[];
}

export interface TripDto extends AuditedEntityDto<string> {
  title?: string;
  description?: string;
  thumbnail: number[];
  rating: number;
  duration: number;
  glanguages?: string;
  tripSize?: number;
  durationUnit: DurationUnit;
  difficulty: Difficulty;
  date?: string;
  startingTime?: string;
  agency?: string;
  idAchived?: string;
  activities?: string;
  risks?: string;
  notAllowedStuff?: string;
  requiredStuff?: string;
  notSuitableFor?: string;
  includedStuff?: string;
  loging?: string;
  guideId?: string;
  guide: GuideDto;
  thumbnailImage: number[];
  locations: LocationDto[];
  images: ImageDto[];
  scheduledTrips: ScheduledTripDto[];
  potentialClients: WishListDto[];
}

export interface TripFilter {
  maxResult: number;
  pageSkip: number;
  start?: Date;
  end?: Date;
  title?: string;
  rating?: number;
  duration?: number;
  tripSize?: number;
  durationUnit?: DurationUnit;
  difficulty?: Difficulty;
  date?: string;
  isValidated?: boolean;
  activity?: string;
  risk?: string;
  notAllowed?: string;
  required?: string;
  notSuitable?: string;
  includedStuff?: string;
  loging?: string;
}

export interface TripMiniDto extends AuditedEntityDto<string> {
  title?: string;
  thumbnail: number[];
  description?: string;
  agency?: string;
  rating: number;
  duration: number;
  tripSize?: number;
  durationUnit: DurationUnit;
  difficulty: Difficulty;
  date?: string;
  activities?: string;
  loging?: string;
  thumbnailImage: number[];
}

export interface TripWithDetailsDto {
  title?: string;
  thumbnail: number[];
  description?: string;
  rating: number;
  duration: number;
  tripSize?: number;
  durationUnit: DurationUnit;
  difficulty: Difficulty;
  date?: string;
  startingTime?: string;
  activitiesList: string[];
  logingList: string[];
  thumbnailImage: number[];
  risksList: string[];
  notAllowedStuffList: string[];
  requiredStuffList: string[];
  notSuitableForList: string[];
  includedStuffList: string[];
}

export interface WishList extends FullAuditedAggregateRoot<string> {
  tripId?: string;
  trip: Trip;
  touristId?: string;
  tourist: Tourist;
}

export interface WishListDto extends AuditedEntityDto<string> {
  idTrip?: string;
  trip: TripDto;
  idTourist?: string;
  tourist: TouristDto;
}
