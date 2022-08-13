import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdateReviewDto, ReviewDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class ReviewService {
  apiName = 'Default';

  create = (input: CreateUpdateReviewDto) =>
    this.restService.request<any, ReviewDto>({
      method: 'POST',
      url: '/api/app/review',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/review/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ReviewDto>({
      method: 'GET',
      url: `/api/app/review/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ReviewDto>>({
      method: 'GET',
      url: '/api/app/review',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getReviewWithDetails = (id: string) =>
    this.restService.request<any, ReviewDto>({
      method: 'GET',
      url: `/api/app/getReviewWithDetails/${id}`,
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateReviewDto) =>
    this.restService.request<any, ReviewDto>({
      method: 'PUT',
      url: `/api/app/review/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
