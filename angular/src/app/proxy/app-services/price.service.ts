import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdatePriceDto, PriceDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class PriceService {
  apiName = 'Default';

  create = (input: CreateUpdatePriceDto) =>
    this.restService.request<any, PriceDto>({
      method: 'POST',
      url: '/api/app/price',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/price/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PriceDto>({
      method: 'GET',
      url: `/api/app/price/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PriceDto>>({
      method: 'GET',
      url: '/api/app/price',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdatePriceDto) =>
    this.restService.request<any, PriceDto>({
      method: 'PUT',
      url: `/api/app/price/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
