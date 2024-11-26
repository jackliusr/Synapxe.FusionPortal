using Ihis.FhirEngine.Data.Models;

namespace Synapxe.FusionPortal.Data;


[CustomFhirResource]
[Hl7.Fhir.Introspection.FhirType("Application", "http://hl7.org/fhir/StructureDefinition/Application", IsResource = true)]
public class ApplicationEntity: ResourceEntity
{
    public IdentifierEntity? Identifier { get; set; }

    public string Name { get; set; }

    public string OwnerCluster { get; set; }

    public string Domain { get; set; }

    public string Subdomain { get; set; }

    public string SystemId { get; set; }

    public string Criticality { get; set; }

    public bool InternetFacing { get; set; }


}
