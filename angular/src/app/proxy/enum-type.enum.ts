import { mapEnumToOptions } from '@abp/ng.core';

export enum EnumType {
  Activity = 0,
  Risk = 1,
  NotAllowedStuff = 2,
  RequiredStuff = 3,
  NotSuitableFor = 4,
  IncludedStuff = 5,
  Loging = 6,
}

export const enumTypeOptions = mapEnumToOptions(EnumType);
