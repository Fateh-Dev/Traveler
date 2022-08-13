import { mapEnumToOptions } from '@abp/ng.core';

export enum Difficulty {
  Easy = 0,
  Moderate = 1,
  Hard = 2,
}

export const difficultyOptions = mapEnumToOptions(Difficulty);
