import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateScheduledTripDto, ScheduledTripDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class ScheduledTripService {
  apiName = 'Default';

  create = (input: CreateUpdateScheduledTripDto) =>
    this.restService.request<any, ScheduledTripDto>({
      method: 'POST',
      url: '/api/app/scheduled-trip',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/scheduled-trip/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ScheduledTripDto>({
      method: 'GET',
      url: `/api/app/scheduled-trip/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ScheduledTripDto>>({
      method: 'GET',
      url: '/api/app/scheduled-trip',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getscheduledtripWithDetails = (id: string) =>
    this.restService.request<any, ScheduledTripDto>({
      method: 'GET',
      url: `/api/app/getScheduledTripWithDetails/${id}`,
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateScheduledTripDto) =>
    this.restService.request<any, ScheduledTripDto>({
      method: 'PUT',
      url: `/api/app/scheduled-trip/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
