﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Ihis.FhirEngine.Data.Models;

#nullable enable

namespace Synapxe.FusionPortal.Data;

[CustomFhirResource]
[Hl7.Fhir.Introspection.FhirType("Inventory", "http://hl7.org/fhir/StructureDefinition/Inventory", IsResource = true)]
public class InventoryEntity : ResourceEntity
{


    public List<IdentifierEntity> Identifier { get; set; } = new List<IdentifierEntity>();

    public bool? Active { get; set; }

    public ResourceReferenceEntity? Sender { get; set; }

    public ResourceReferenceEntity? Receiver { get; set; }

}
