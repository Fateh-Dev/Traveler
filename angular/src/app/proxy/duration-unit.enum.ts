import { mapEnumToOptions } from '@abp/ng.core';

export enum DurationUnit {
  Day = 0,
  Hours = 1,
  Weeks = 2,
}

export const durationUnitOptions = mapEnumToOptions(DurationUnit);
