import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateTouristDto, TouristDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class TouristService {
  apiName = 'Default';

  create = (input: CreateUpdateTouristDto) =>
    this.restService.request<any, TouristDto>({
      method: 'POST',
      url: '/api/app/tourist',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/tourist/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, TouristDto>({
      method: 'GET',
      url: `/api/app/tourist/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<TouristDto>>({
      method: 'GET',
      url: '/api/app/tourist',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateTouristDto) =>
    this.restService.request<any, TouristDto>({
      method: 'PUT',
      url: `/api/app/tourist/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
