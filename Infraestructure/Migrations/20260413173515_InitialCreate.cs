using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_CLIENTES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    APELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DIRECCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CUIL_CUIT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TELEFONO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CLIENTES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DEPARTAMENTOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRE_DEPTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DEPARTAMENTOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DETALLES_RANKINGS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CALIFICACION = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DETALLES_RANKINGS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ESTADOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE_ESTADO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ESTADOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_HISTORIAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FECHA_HORA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_HISTORIAL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TIPOS_INTERACCION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TIPOS_INTERACCION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TIPOS_ROL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRE_ROL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TIPOS_ROL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PROVEEDORES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAZON_SOCIAL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CUIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TELEFONO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DIRECCION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ID_RANKING = table.Column<int>(type: "int", nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PROVEEDORES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_PROVEEDORES_TBL_DETALLES_RANKINGS_ID_RANKING",
                        column: x => x.ID_RANKING,
                        principalTable: "TBL_DETALLES_RANKINGS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PRODUCTOS_SOFTWARE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PRECIO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NOMBRE_PRODUCTO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PRODUCTOS_SOFTWARE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_PRODUCTOS_SOFTWARE_TBL_CLIENTES_ID_CLIENTE",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TBL_CLIENTES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_PRODUCTOS_SOFTWARE_TBL_ESTADOS_ID_ESTADO",
                        column: x => x.ID_ESTADO,
                        principalTable: "TBL_ESTADOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_EMPLEADOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TIPO_ROL = table.Column<int>(type: "int", nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    APELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHA_NACIMIENTO = table.Column<DateOnly>(type: "date", nullable: false),
                    CUIL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DIRECCION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA_CONTRATACION = table.Column<DateOnly>(type: "date", nullable: false),
                    ID_DEPTO = table.Column<int>(type: "int", nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    USUARIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CORREO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HASH_CLAVE = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_EMPLEADOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_EMPLEADOS_TBL_DEPARTAMENTOS_ID_DEPTO",
                        column: x => x.ID_DEPTO,
                        principalTable: "TBL_DEPARTAMENTOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_EMPLEADOS_TBL_TIPOS_ROL_ID_TIPO_ROL",
                        column: x => x.ID_TIPO_ROL,
                        principalTable: "TBL_TIPOS_ROL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PRODUCTOS_SERVICIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ID_PROVEEDOR = table.Column<int>(type: "int", nullable: false),
                    PRECIO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PRODUCTOS_SERVICIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_PRODUCTOS_SERVICIOS_TBL_PROVEEDORES_ID_PROVEEDOR",
                        column: x => x.ID_PROVEEDOR,
                        principalTable: "TBL_PROVEEDORES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_INTERACCIONES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_EMPLEADO = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_INTERACCION = table.Column<int>(type: "int", nullable: false),
                    MOTIVO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    FECHA_HORA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_INTERACCIONES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_INTERACCIONES_TBL_CLIENTES_ID_CLIENTE",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TBL_CLIENTES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_INTERACCIONES_TBL_EMPLEADOS_ID_EMPLEADO",
                        column: x => x.ID_EMPLEADO,
                        principalTable: "TBL_EMPLEADOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_INTERACCIONES_TBL_TIPOS_INTERACCION_ID_TIPO_INTERACCION",
                        column: x => x.ID_TIPO_INTERACCION,
                        principalTable: "TBL_TIPOS_INTERACCION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_VENTAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PRODUCTO_SOFTWARE = table.Column<int>(type: "int", nullable: false),
                    ID_EMPLEADO_REALIZA = table.Column<int>(type: "int", nullable: false),
                    ID_EMPLEADO_INSTALA = table.Column<int>(type: "int", nullable: true),
                    FECHA_HORA_INICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FECHA_HORA_ENTREGA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    TOTAL = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_VENTAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_VENTAS_TBL_EMPLEADOS_ID_EMPLEADO_INSTALA",
                        column: x => x.ID_EMPLEADO_INSTALA,
                        principalTable: "TBL_EMPLEADOS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TBL_VENTAS_TBL_EMPLEADOS_ID_EMPLEADO_REALIZA",
                        column: x => x.ID_EMPLEADO_REALIZA,
                        principalTable: "TBL_EMPLEADOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_VENTAS_TBL_PRODUCTOS_SOFTWARE_ID_PRODUCTO_SOFTWARE",
                        column: x => x.ID_PRODUCTO_SOFTWARE,
                        principalTable: "TBL_PRODUCTOS_SOFTWARE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_REGISTROS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_EMPLEADO = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUCTO_SERVICIO = table.Column<int>(type: "int", nullable: false),
                    ESTADO_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    FECHA_HORA = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_REGISTROS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_REGISTROS_TBL_EMPLEADOS_ID_EMPLEADO",
                        column: x => x.ID_EMPLEADO,
                        principalTable: "TBL_EMPLEADOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_REGISTROS_TBL_PRODUCTOS_SERVICIOS_ID_PRODUCTO_SERVICIO",
                        column: x => x.ID_PRODUCTO_SERVICIO,
                        principalTable: "TBL_PRODUCTOS_SERVICIOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_EMPLEADOS_ID_DEPTO",
                table: "TBL_EMPLEADOS",
                column: "ID_DEPTO");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_EMPLEADOS_ID_TIPO_ROL",
                table: "TBL_EMPLEADOS",
                column: "ID_TIPO_ROL");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_INTERACCIONES_ID_CLIENTE",
                table: "TBL_INTERACCIONES",
                column: "ID_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_INTERACCIONES_ID_EMPLEADO",
                table: "TBL_INTERACCIONES",
                column: "ID_EMPLEADO");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_INTERACCIONES_ID_TIPO_INTERACCION",
                table: "TBL_INTERACCIONES",
                column: "ID_TIPO_INTERACCION");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PRODUCTOS_SERVICIOS_ID_PROVEEDOR",
                table: "TBL_PRODUCTOS_SERVICIOS",
                column: "ID_PROVEEDOR");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PRODUCTOS_SOFTWARE_ID_CLIENTE",
                table: "TBL_PRODUCTOS_SOFTWARE",
                column: "ID_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PRODUCTOS_SOFTWARE_ID_ESTADO",
                table: "TBL_PRODUCTOS_SOFTWARE",
                column: "ID_ESTADO");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROVEEDORES_ID_RANKING",
                table: "TBL_PROVEEDORES",
                column: "ID_RANKING");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_REGISTROS_ID_EMPLEADO",
                table: "TBL_REGISTROS",
                column: "ID_EMPLEADO");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_REGISTROS_ID_PRODUCTO_SERVICIO",
                table: "TBL_REGISTROS",
                column: "ID_PRODUCTO_SERVICIO");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VENTAS_ID_EMPLEADO_INSTALA",
                table: "TBL_VENTAS",
                column: "ID_EMPLEADO_INSTALA");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VENTAS_ID_EMPLEADO_REALIZA",
                table: "TBL_VENTAS",
                column: "ID_EMPLEADO_REALIZA");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VENTAS_ID_PRODUCTO_SOFTWARE",
                table: "TBL_VENTAS",
                column: "ID_PRODUCTO_SOFTWARE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_HISTORIAL");

            migrationBuilder.DropTable(
                name: "TBL_INTERACCIONES");

            migrationBuilder.DropTable(
                name: "TBL_REGISTROS");

            migrationBuilder.DropTable(
                name: "TBL_VENTAS");

            migrationBuilder.DropTable(
                name: "TBL_TIPOS_INTERACCION");

            migrationBuilder.DropTable(
                name: "TBL_PRODUCTOS_SERVICIOS");

            migrationBuilder.DropTable(
                name: "TBL_EMPLEADOS");

            migrationBuilder.DropTable(
                name: "TBL_PRODUCTOS_SOFTWARE");

            migrationBuilder.DropTable(
                name: "TBL_PROVEEDORES");

            migrationBuilder.DropTable(
                name: "TBL_DEPARTAMENTOS");

            migrationBuilder.DropTable(
                name: "TBL_TIPOS_ROL");

            migrationBuilder.DropTable(
                name: "TBL_CLIENTES");

            migrationBuilder.DropTable(
                name: "TBL_ESTADOS");

            migrationBuilder.DropTable(
                name: "TBL_DETALLES_RANKINGS");
        }
    }
}
