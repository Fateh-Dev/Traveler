import { mapEnumToOptions } from '@abp/ng.core';

export enum LocationType {
  Destination = 0,
  PickUp = 1,
  DropOff = 2,
  Stop = 3,
}

export const locationTypeOptions = mapEnumToOptions(LocationType);
