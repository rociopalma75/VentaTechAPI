-- DEPARTAMENTOS

SET IDENTITY_INSERT [dbo].[TBL_DEPARTAMENTOS] ON;

INSERT INTO [dbo].[TBL_DEPARTAMENTOS] 
([ID], [DESCRIPCION], [NOMBRE_DEPTO])
VALUES
(1,'Se encarga de la gestión del talento humano y recursos', 'RRHH'),
(2,'Responsable de las finanzas y la contabilidad de la empresa', 'Finanzas'),
(3,'Administra las tecnologías de la información y sistemas', 'Sistemas'),
(4,'Planifica y ejecuta estrategias de marketing y publicidad', 'Marketing'),
(5,'Gestiona las relaciones con los clientes y ventas', 'Ventas');

SET IDENTITY_INSERT [dbo].[TBL_DEPARTAMENTOS] OFF;

-- DETALLES RANKINGS

SET IDENTITY_INSERT [dbo].[TBL_DETALLES_RANKINGS] ON;

INSERT INTO [dbo].[TBL_DETALLES_RANKINGS] (ID, DESCRIPCION, CALIFICACION) VALUES
(1, 'Entrega puntual y en perfectas condiciones', 5),
(2, 'Entrega puntual pero con algunos defectos', 4),
(3, 'Retraso en la entrega pero calidad aceptable', 3),
(4, 'Retraso significativo y calidad baja', 2),
(5, 'Incumplimiento en la entrega', 1);
SET IDENTITY_INSERT [dbo].[TBL_DETALLES_RANKINGS] OFF;

-- ESTADOS

SET IDENTITY_INSERT [dbo].[TBL_ESTADOS] ON;

INSERT INTO [dbo].[TBL_ESTADOS] (ID, NOMBRE_ESTADO, DESCRIPCION) VALUES
(1, 'En Planificación', 'El proyecto está en etapa de planificación inicial.'),
(2, 'En Desarrollo', 'El desarrollo del software está en curso.'),
(3, 'En Pruebas', 'El software está siendo sometido a pruebas y depuración.'),
(4, 'Finalizado', 'El desarrollo del software se ha completado.'),
(5, 'En Mantenimiento', 'El software está en uso y recibe actualizaciones o correcciones.');

SET IDENTITY_INSERT [dbo].[TBL_ESTADOS] OFF;

-- TIPOS INTERACCIONES

SET IDENTITY_INSERT [dbo].[TBL_TIPOS_INTERACCION] ON;

INSERT INTO [dbo].[TBL_TIPOS_INTERACCION] (ID, DESCRIPCION) VALUES
(1, 'Llamada'),
(2, 'Correo Electrónico'),
(3, 'Presencial');

SET IDENTITY_INSERT [dbo].[TBL_TIPOS_INTERACCION] OFF;

-- TIPOS ROLES

SET IDENTITY_INSERT [dbo].[TBL_TIPOS_ROL] ON;

INSERT INTO [dbo].[TBL_TIPOS_ROL] (ID, DESCRIPCION, NOMBRE_ROL) VALUES
(1, 'Solo tiene permisos para Gestion de RRHH', 'Administrador'),
(2, 'Tiene permisos para Gestion de Ventas, Proveedores y Clientes', 'Operador');

SET IDENTITY_INSERT [dbo].[TBL_TIPOS_ROL] OFF;