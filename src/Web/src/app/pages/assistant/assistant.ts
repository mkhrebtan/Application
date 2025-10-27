import { Component, inject } from '@angular/core';
import { InputText } from 'primeng/inputtext';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { AiService } from '../../core/ai-service/ai-service';
import { CommonModule } from '@angular/common';
import { InputGroup } from 'primeng/inputgroup';
import { Button } from 'primeng/button';
import { ScrollPanel } from 'primeng/scrollpanel';

interface Message {
  text: string;
  isUser: boolean;
}

@Component({
  selector: 'app-assistant',
  imports: [InputText, ReactiveFormsModule, CommonModule, InputGroup, Button, ScrollPanel],
  templateUrl: './assistant.html',
  styles: [],
})
export class Assistant {
  protected userQuery = new FormControl('');
  protected aiService = inject(AiService);

  processQuery() {
    const prompt = this.userQuery.value;
    if (!prompt) {
      return;
    }

    this.userQuery.reset();
    this.aiService.processQuery(prompt);
  }
}
