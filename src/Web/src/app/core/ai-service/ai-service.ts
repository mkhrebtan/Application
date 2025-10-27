import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, finalize } from 'rxjs';

export interface Message {
  text: string;
  isUser: boolean;
}

@Injectable({
  providedIn: 'root',
})
export class AiService {
  private messagesSubject = new BehaviorSubject<Message[]>([]);
  messages$ = this.messagesSubject.asObservable();
  private loadingSubject = new BehaviorSubject<boolean>(false);
  loading$ = this.loadingSubject.asObservable();
  private apiUrl: string = 'https://localhost:5001';
  private http = inject(HttpClient);

  processQuery(prompt: string) {
    this.messagesSubject.next([...this.messagesSubject.getValue(), { text: prompt, isUser: true }]);
    this.loadingSubject.next(true);

    this.generateResponse(prompt)
      .pipe(finalize(() => this.loadingSubject.next(false)))
      .subscribe({
        next: (response) => {
          this.messagesSubject.next([
            ...this.messagesSubject.getValue(),
            { text: response, isUser: false },
          ]);
        },
        error: () => {
          this.messagesSubject.next([
            ...this.messagesSubject.getValue(),
            { text: 'Error: Unable to get response from AI service.', isUser: false },
          ]);
        },
      });
  }

  private generateResponse(prompt: string) {
    const url = `${this.apiUrl}/ai/ask`;
    return this.http.post<string>(url, { prompt: prompt });
  }
}
