using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WS001_ART_InventarioRural.Models
{
    public class InventarioRural
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public string? CodVereda { get; set; }

        public string? NomDepartamento { get; set; }

        public string? NomMunicipio { get; set; }

        public string? NomVereda { get; set; }

        public string? TipoComunidadEncuestada { get; set; }

        public string? NomComunidadEncuestada { get; set; }

        public int? NumViviendas { get; set; }

        public int? NumHabitantes { get; set; }

        public string? TipoTomaAgua { get; set; }

        public string? TipoInfraestructuraAbAgua { get; set; }

        public string? NomRespAbastecimientoAgua { get; set; }

        public string? TelefonoResponsable { get; set; }

        public string? CorreoElectronicoResponsable { get; set; }

        public string? TipoPoblacionAbaAgua { get; set; }

        public string? TipoInfraestructuraAguasRes { get; set; }

        public string? NomResponsableAguasResiduales { get; set; }

        public string? TelefonoResponsableAguasRes { get; set; }

        public string? CorreoElectronicoResAguasRes { get; set; }

        public string? TipoManejoResiduosSolidos { get; set; }

        public string? NomCentroEducativoComunidad { get; set; }

        public string? NomCentroSaludComunidad { get; set; }

    }
}
