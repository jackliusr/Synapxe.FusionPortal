using Google.Protobuf;
using Ihis.FhirEngine.Data.Models;

namespace Synapxe.FusionPortal.Data;

[CustomFhirResource]

[Hl7.Fhir.Introspection.FhirType("KtloActivity", "http://hl7.org/fhir/StructureDefinition/TestActivity", IsResource = true)]
public class TestActivityEntity: ResourceEntity
{
    public IdentifierEntity? Identifier { get; set; }

    public required string ActivityName { get; set; }

    public required string  ArtefactRequired { get; set; }
}
