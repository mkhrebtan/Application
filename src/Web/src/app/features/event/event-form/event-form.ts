import {
  Component,
  computed,
  EventEmitter,
  Input,
  Output,
  Signal,
  signal,
  WritableSignal,
} from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { IEventTag } from '../models/event-tag';
import { InputText } from 'primeng/inputtext';
import { Message } from 'primeng/message';
import { Textarea } from 'primeng/textarea';
import { DatePicker } from 'primeng/datepicker';
import { InputNumber } from 'primeng/inputnumber';
import { RadioButton } from 'primeng/radiobutton';
import { Button } from 'primeng/button';
import { MultiSelect } from 'primeng/multiselect';

@Component({
  selector: 'app-event-form',
  imports: [
    ReactiveFormsModule,
    InputText,
    Message,
    Textarea,
    DatePicker,
    InputNumber,
    RadioButton,
    Button,
    MultiSelect,
  ],
  templateUrl: './event-form.html',
  styles: ``,
})
export class EventForm {
  @Input() submitButtonText: string = 'Submit';
  @Input() formGroup!: FormGroup;
  @Input() tagsOptions: IEventTag[] = [];
  @Output() formSubmit = new EventEmitter<void>();
  protected userTags: WritableSignal<IEventTag[]> = signal([]);
  protected customTagInput = new FormControl('', [Validators.maxLength(30)]);
  protected allTags: Signal<IEventTag[]>;

  constructor() {
    this.allTags = computed(() => [...this.tagsOptions, ...this.userTags()]);
  }

  get title() {
    return this.formGroup.get('title');
  }

  get description() {
    return this.formGroup.get('description');
  }

  get date() {
    return this.formGroup.get('date');
  }

  get location() {
    return this.formGroup.get('location');
  }

  get capacity() {
    return this.formGroup.get('capacity');
  }

  get visibility() {
    return this.formGroup.get('visibility');
  }

  get tags() {
    return this.formGroup.get('tags');
  }

  onSubmit() {
    this.formSubmit.emit();
  }

  isInvalidAndTouched(controlName: string): boolean {
    const control = this.formGroup.get(controlName);
    return !!(control && control.invalid && (control.dirty || control.touched));
  }

  addCustomTag() {
    const tagName = this.toTitleCase(this.customTagInput.value?.trim());
    if (!tagName) {
      return;
    }

    const existingTagIndex = this.tagsOptions.findIndex((tag: IEventTag) => tag.name === tagName);
    console.log(existingTagIndex);
    if (existingTagIndex !== -1) {
      if (!this.tags?.value?.some((tag: IEventTag) => tag.name === tagName)) {
        this.tags?.setValue([...(this.tags?.value || []), this.tagsOptions[existingTagIndex]]);
      }
      this.customTagInput.setValue('');
      return;
    }

    const newTag: IEventTag = {
      id: '1-1-1-1-1',
      name: tagName,
    };
    this.userTags.set([...this.userTags(), newTag]);
    this.tags?.setValue([...(this.tags?.value || []), newTag]);
    this.customTagInput.setValue('');
  }

  private toTitleCase(str: any) {
    return str
      .toLowerCase()
      .split(' ')
      .map((word: any) => {
        return word.charAt(0).toUpperCase() + word.slice(1);
      })
      .join(' ');
  }
}
