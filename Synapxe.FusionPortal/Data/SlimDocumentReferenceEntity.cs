using Hl7.Fhir.Introspection;
using Ihis.FhirEngine.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Synapxe.FusionPortal.Data;

[FhirType("DocumentReference", "http://hl7.org/fhir/StructureDefinition/DocumentReference", IsResource = true)]
public class SlimDocumentReferenceEntity : IResourceEntity
{
    /// <summary>
    /// The resource ID.
    /// </summary>
    [StringLength(64)]
    [Column(TypeName = "varchar(64)")]
    [RegularExpression("[A-Za-z0-9\\-\\.]{1,64}")]
    public string Id { get; set; } = default!;

    public int? VersionId { get; set; }

    public bool IsHistory { get; set; }

    public SlimMetaEntity Meta { get; set; } = new SlimMetaEntity();

    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public DateTimeOffset? LastUpdated { get => Meta.LastUpdated; set => Meta.LastUpdated = value; }

    [Timestamp]
    public byte[] TimeStamp { get; set; }

    [FhirType("Meta", "http://hl7.org/fhir/StructureDefinition/Meta")]
    [Owned]
    public class SlimMetaEntity
    {
        public DateTimeOffset? LastUpdated { get; set; }

        public string Source { get; set; }
    }
}
