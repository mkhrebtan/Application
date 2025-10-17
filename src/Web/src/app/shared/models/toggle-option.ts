import { IconDefinition } from '@fortawesome/angular-fontawesome';

export interface ToggleOption<TEnum> {
  label: string;
  value: TEnum;
  icon?: IconDefinition;
}
