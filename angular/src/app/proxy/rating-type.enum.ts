import { mapEnumToOptions } from '@abp/ng.core';

export enum RatingType {
  Guide = 0,
  Service = 1,
  Organisation = 2,
  Price = 3,
  Transportation = 4,
  Safety = 5,
}

export const ratingTypeOptions = mapEnumToOptions(RatingType);
