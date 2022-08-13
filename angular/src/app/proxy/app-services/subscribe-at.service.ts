import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateSubscribeAtDto, SubscribeAtDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class SubscribeAtService {
  apiName = 'Default';

  create = (input: CreateUpdateSubscribeAtDto) =>
    this.restService.request<any, SubscribeAtDto>({
      method: 'POST',
      url: '/api/app/subscribe-at',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/subscribe-at/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SubscribeAtDto>({
      method: 'GET',
      url: `/api/app/subscribe-at/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<SubscribeAtDto>>({
      method: 'GET',
      url: '/api/app/subscribe-at',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSubscribeAtDto) =>
    this.restService.request<any, SubscribeAtDto>({
      method: 'PUT',
      url: `/api/app/subscribe-at/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
