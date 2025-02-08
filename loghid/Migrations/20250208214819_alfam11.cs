using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Precios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sistema = table.Column<string>(type: "TEXT", nullable: false),
                    RangoPrecio = table.Column<string>(type: "TEXT", nullable: false),
                    PrecioBase = table.Column<double>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SprinterLabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vehiculo = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Mercedes-Benz Sprinter"),
                    TipoConversion = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadCarga = table.Column<double>(type: "REAL", nullable: false),
                    EspacioInterior = table.Column<double>(type: "REAL", nullable: false),
                    ModeloEquipo = table.Column<string>(type: "TEXT", nullable: false),
                    NormaHidrogeno = table.Column<string>(type: "TEXT", nullable: false),
                    NormaPureza = table.Column<string>(type: "TEXT", nullable: false),
                    PurezaMinima = table.Column<double>(type: "REAL", nullable: false),
                    PurezaOptima = table.Column<double>(type: "REAL", nullable: false),
                    DetectorHidrogeno = table.Column<string>(type: "TEXT", nullable: false),
                    DetectorHidrocarburos = table.Column<string>(type: "TEXT", nullable: false),
                    DetectorOxigenoOtros = table.Column<string>(type: "TEXT", nullable: false),
                    DetectorAzufre = table.Column<string>(type: "TEXT", nullable: false),
                    FiltroMinimoMicrones = table.Column<int>(type: "INTEGER", nullable: false),
                    FiltroMaximoMicrones = table.Column<int>(type: "INTEGER", nullable: false),
                    MetodoTomaMuestra = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadFraccionMolar = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadContenidoAgua = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadImpurezas = table.Column<string>(type: "TEXT", nullable: false),
                    MetodoCalibracion = table.Column<string>(type: "TEXT", nullable: false),
                    NormaCalibracion = table.Column<string>(type: "TEXT", nullable: false),
                    EnsayoPresion = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    EnsayoFugas = table.Column<bool>(type: "INTEGER", nullable: false),
                    EnsayoCalidadHidrogeno = table.Column<bool>(type: "INTEGER", nullable: false),
                    CarrierGas = table.Column<string>(type: "TEXT", nullable: false),
                    CarrierAlternativo = table.Column<string>(type: "TEXT", nullable: false),
                    SensibilidadMinima = table.Column<double>(type: "REAL", nullable: false, defaultValue: 0.10000000000000001),
                    SistemaAislamientoVibraciones = table.Column<bool>(type: "INTEGER", nullable: false),
                    SistemaClimatizacionControlada = table.Column<bool>(type: "INTEGER", nullable: false),
                    SistemaEnergiaIndependiente = table.Column<bool>(type: "INTEGER", nullable: false),
                    PrecioVehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioTipoConversionId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioModeloEquipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioNormaHidrogenoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioNormaPurezaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioDetectorHidrogenoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioDetectorHidrocarburosId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioDetectorOxigenoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioDetectorAzufreId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioFiltradoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioMetodoTomaMuestraId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioUnidadFraccionMolarId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioUnidadContenidoAguaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioUnidadImpurezasId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioMetodoCalibracionId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioNormaCalibracionId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioEnsayoPresionId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioEnsayoFugasId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioEnsayoCalidadHidrogenoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioCarrierGasId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioCarrierAlternativoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioSensibilidadMinimaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioSistemaAislamientoVibracionesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioSistemaClimatizacionControladaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioSistemaEnergiaIndependienteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprinterLabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioCarrierAlternativoId",
                        column: x => x.PrecioCarrierAlternativoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioCarrierGasId",
                        column: x => x.PrecioCarrierGasId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioDetectorAzufreId",
                        column: x => x.PrecioDetectorAzufreId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioDetectorHidrocarburosId",
                        column: x => x.PrecioDetectorHidrocarburosId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioDetectorHidrogenoId",
                        column: x => x.PrecioDetectorHidrogenoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioDetectorOxigenoId",
                        column: x => x.PrecioDetectorOxigenoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioEnsayoCalidadHidrogenoId",
                        column: x => x.PrecioEnsayoCalidadHidrogenoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioEnsayoFugasId",
                        column: x => x.PrecioEnsayoFugasId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioEnsayoPresionId",
                        column: x => x.PrecioEnsayoPresionId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioFiltradoId",
                        column: x => x.PrecioFiltradoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioMetodoCalibracionId",
                        column: x => x.PrecioMetodoCalibracionId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioMetodoTomaMuestraId",
                        column: x => x.PrecioMetodoTomaMuestraId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioModeloEquipoId",
                        column: x => x.PrecioModeloEquipoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioNormaCalibracionId",
                        column: x => x.PrecioNormaCalibracionId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioNormaHidrogenoId",
                        column: x => x.PrecioNormaHidrogenoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioNormaPurezaId",
                        column: x => x.PrecioNormaPurezaId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioSensibilidadMinimaId",
                        column: x => x.PrecioSensibilidadMinimaId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioSistemaAislamientoVibracionesId",
                        column: x => x.PrecioSistemaAislamientoVibracionesId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioSistemaClimatizacionControladaId",
                        column: x => x.PrecioSistemaClimatizacionControladaId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioSistemaEnergiaIndependienteId",
                        column: x => x.PrecioSistemaEnergiaIndependienteId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioTipoConversionId",
                        column: x => x.PrecioTipoConversionId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioUnidadContenidoAguaId",
                        column: x => x.PrecioUnidadContenidoAguaId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioUnidadFraccionMolarId",
                        column: x => x.PrecioUnidadFraccionMolarId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioUnidadImpurezasId",
                        column: x => x.PrecioUnidadImpurezasId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SprinterLabs_Precios_PrecioVehiculoId",
                        column: x => x.PrecioVehiculoId,
                        principalTable: "Precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_ModeloEquipo",
                table: "SprinterLabs",
                column: "ModeloEquipo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_NormaHidrogeno",
                table: "SprinterLabs",
                column: "NormaHidrogeno");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioCarrierAlternativoId",
                table: "SprinterLabs",
                column: "PrecioCarrierAlternativoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioCarrierGasId",
                table: "SprinterLabs",
                column: "PrecioCarrierGasId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioDetectorAzufreId",
                table: "SprinterLabs",
                column: "PrecioDetectorAzufreId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioDetectorHidrocarburosId",
                table: "SprinterLabs",
                column: "PrecioDetectorHidrocarburosId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioDetectorHidrogenoId",
                table: "SprinterLabs",
                column: "PrecioDetectorHidrogenoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioDetectorOxigenoId",
                table: "SprinterLabs",
                column: "PrecioDetectorOxigenoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioEnsayoCalidadHidrogenoId",
                table: "SprinterLabs",
                column: "PrecioEnsayoCalidadHidrogenoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioEnsayoFugasId",
                table: "SprinterLabs",
                column: "PrecioEnsayoFugasId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioEnsayoPresionId",
                table: "SprinterLabs",
                column: "PrecioEnsayoPresionId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioFiltradoId",
                table: "SprinterLabs",
                column: "PrecioFiltradoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioMetodoCalibracionId",
                table: "SprinterLabs",
                column: "PrecioMetodoCalibracionId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioMetodoTomaMuestraId",
                table: "SprinterLabs",
                column: "PrecioMetodoTomaMuestraId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioModeloEquipoId",
                table: "SprinterLabs",
                column: "PrecioModeloEquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioNormaCalibracionId",
                table: "SprinterLabs",
                column: "PrecioNormaCalibracionId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioNormaHidrogenoId",
                table: "SprinterLabs",
                column: "PrecioNormaHidrogenoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioNormaPurezaId",
                table: "SprinterLabs",
                column: "PrecioNormaPurezaId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioSensibilidadMinimaId",
                table: "SprinterLabs",
                column: "PrecioSensibilidadMinimaId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioSistemaAislamientoVibracionesId",
                table: "SprinterLabs",
                column: "PrecioSistemaAislamientoVibracionesId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioSistemaClimatizacionControladaId",
                table: "SprinterLabs",
                column: "PrecioSistemaClimatizacionControladaId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioSistemaEnergiaIndependienteId",
                table: "SprinterLabs",
                column: "PrecioSistemaEnergiaIndependienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioTipoConversionId",
                table: "SprinterLabs",
                column: "PrecioTipoConversionId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioUnidadContenidoAguaId",
                table: "SprinterLabs",
                column: "PrecioUnidadContenidoAguaId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioUnidadFraccionMolarId",
                table: "SprinterLabs",
                column: "PrecioUnidadFraccionMolarId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioUnidadImpurezasId",
                table: "SprinterLabs",
                column: "PrecioUnidadImpurezasId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PrecioVehiculoId",
                table: "SprinterLabs",
                column: "PrecioVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PurezaOptima",
                table: "SprinterLabs",
                column: "PurezaOptima");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SprinterLabs");

            migrationBuilder.DropTable(
                name: "Precios");
        }
    }
}
