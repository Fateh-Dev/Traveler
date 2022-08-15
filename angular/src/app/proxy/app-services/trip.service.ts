import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateTripDto, TripDto, TripFilter, TripMiniDto, TripWithDetailsDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class TripService {
  apiName = 'Default';

  create = (input: CreateUpdateTripDto) =>
    this.restService.request<any, TripDto>({
      method: 'POST',
      url: '/api/app/trip',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/trip/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, TripDto>({
      method: 'GET',
      url: `/api/app/trip/${id}`,
    },
    { apiName: this.apiName });

  getHomeList = (Filter: TripFilter) =>
    this.restService.request<any, TripMiniDto[]>({
      method: 'GET',
      url: '/api/app/GetHomeListAsync',
      params: { maxResult: Filter.maxResult, pageSkip: Filter.pageSkip, title: Filter.title, rating: Filter.rating, duration: Filter.duration, tripSize: Filter.tripSize, durationUnit: Filter.durationUnit, difficulty: Filter.difficulty, date: Filter.date, isValidated: Filter.isValidated, activity: Filter.activity, risk: Filter.risk, notAllowed: Filter.notAllowed, required: Filter.required, notSuitable: Filter.notSuitable, includedStuff: Filter.includedStuff, loging: Filter.loging },
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<TripDto>>({
      method: 'GET',
      url: '/api/app/trip',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getTripWithDetails = (id: string) =>
    this.restService.request<any, TripWithDetailsDto>({
      method: 'GET',
      url: `/api/app/getTripWithDetails/${id}`,
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateTripDto) =>
    this.restService.request<any, TripDto>({
      method: 'PUT',
      url: `/api/app/trip/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
