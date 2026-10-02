import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface InterfazRespuestaEstadoBackend {
  estado: string;
}

// Servicio técnico: consulta la única ruta consumida por este frontend.
@Injectable({ providedIn: 'root' })
export class ServicioEstadoBackend {
  private readonly urlBackend = 'http://localhost:5080';
  private readonly clienteHttp: HttpClient;

  constructor(clienteHttp: HttpClient) {
    this.clienteHttp = clienteHttp;
  }

  consultarEstado(): Observable<InterfazRespuestaEstadoBackend> {
    return this.clienteHttp.get<InterfazRespuestaEstadoBackend>(`${this.urlBackend}/api/estado`);
  }
}
