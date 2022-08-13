import { mapEnumToOptions } from '@abp/ng.core';

export enum PriceCategory {
  Adult = 0,
  kid = 1,
  Baby = 2,
}

export const priceCategoryOptions = mapEnumToOptions(PriceCategory);
