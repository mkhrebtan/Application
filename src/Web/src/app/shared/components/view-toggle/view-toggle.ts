import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { ToggleOption } from '../../models/toggle-option';

@Component({
  selector: 'app-view-toggle',
  imports: [FaIconComponent],
  template: `
    <div class="flex gap-1 p-1 border border-gray-300 shadow-sm rounded-4xl">
      @for (option of options; track option) {
        <button
          [class.active]="value === option.value"
          (click)="selectOption(option)"
          class="px-3 pt-1 pb-1 transition-all duration-300 rounded-4xl cursor-pointer text-gray-500 hover:text-black [&.active]:text-black [&.active]:bg-gray-200"
        >
          @if (option.icon) {
            <fa-icon [icon]="option.icon" class="text-xl" />
          } @else {
            <span>{{ option.label }}</span>
          }
        </button>
      }
    </div>
  `,
  styles: ``,
})
export class ViewToggle<TEnum> {
  @Input() options!: ToggleOption<TEnum>[];

  @Input() value?: TEnum;
  @Output() valueChange = new EventEmitter<TEnum>();

  selectOption(option: ToggleOption<TEnum>) {
    if (option.value !== this.value) {
      this.valueChange.emit(option.value);
    }
  }
}
