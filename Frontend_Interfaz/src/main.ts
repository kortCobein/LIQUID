import { bootstrapApplication } from '@angular/platform-browser';
import { configuracionAplicacion } from './app/configuracion-aplicacion';
import { ComponenteAplicacion } from './app/componente-aplicacion';

bootstrapApplication(ComponenteAplicacion, configuracionAplicacion)
  .catch((error) => console.error(error));
