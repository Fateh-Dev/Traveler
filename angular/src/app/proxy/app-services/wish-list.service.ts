import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateWishListDto, WishListDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class WishListService {
  apiName = 'Default';

  create = (input: CreateUpdateWishListDto) =>
    this.restService.request<any, WishListDto>({
      method: 'POST',
      url: '/api/app/wish-list',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/wish-list/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, WishListDto>({
      method: 'GET',
      url: `/api/app/wish-list/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<WishListDto>>({
      method: 'GET',
      url: '/api/app/wish-list',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateWishListDto) =>
    this.restService.request<any, WishListDto>({
      method: 'PUT',
      url: `/api/app/wish-list/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
