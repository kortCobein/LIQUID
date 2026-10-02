import { Component, OnInit, signal } from '@angular/core';
import { ServicioEstadoBackend } from './servicio-estado-backend';

// Componente técnico: muestra únicamente la disponibilidad del backend.
@Component({
  selector: 'tienda-aplicacion',
  templateUrl: './componente-aplicacion.html',
})
export class ComponenteAplicacion implements OnInit {
  protected readonly estadoServidor = signal('Comprobando conexión...');
  private readonly servicioEstadoBackend: ServicioEstadoBackend;

  constructor(servicioEstadoBackend: ServicioEstadoBackend) {
    this.servicioEstadoBackend = servicioEstadoBackend;
  }

  ngOnInit(): void {
    this.servicioEstadoBackend.consultarEstado().subscribe({
      next: (respuesta) => this.estadoServidor.set(respuesta.estado),
      error: () => this.estadoServidor.set('Backend no disponible'),
    });
  }
}
