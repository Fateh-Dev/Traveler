import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateImageDto, ImageDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class ImageService {
  apiName = 'Default';

  create = (input: CreateUpdateImageDto) =>
    this.restService.request<any, ImageDto>({
      method: 'POST',
      url: '/api/app/image',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/image/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ImageDto>({
      method: 'GET',
      url: `/api/app/image/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ImageDto>>({
      method: 'GET',
      url: '/api/app/image',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateImageDto) =>
    this.restService.request<any, ImageDto>({
      method: 'PUT',
      url: `/api/app/image/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
