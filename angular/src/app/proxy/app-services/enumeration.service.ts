import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { EnumType } from '../enum-type.enum';
import type { CreateUpdateEnumerationDto, Enumeration, EnumerationDto } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class EnumerationService {
  apiName = 'Default';

  create = (input: CreateUpdateEnumerationDto) =>
    this.restService.request<any, EnumerationDto>({
      method: 'POST',
      url: '/api/app/enumeration',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/enumeration/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, EnumerationDto>({
      method: 'GET',
      url: `/api/app/enumeration/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<EnumerationDto>>({
      method: 'GET',
      url: '/api/app/enumeration',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getscheduledtripWithDetails = (type: EnumType) =>
    this.restService.request<any, Enumeration[]>({
      method: 'GET',
      url: `/api/app/getEnumByType/${type}`,
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateEnumerationDto) =>
    this.restService.request<any, EnumerationDto>({
      method: 'PUT',
      url: `/api/app/enumeration/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
