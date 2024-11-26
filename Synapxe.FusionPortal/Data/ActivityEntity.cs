using Hl7.Fhir.ElementModel.Types;
using Hl7.Fhir.Model;
using Ihis.FhirEngine.Data.Models;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace Synapxe.FusionPortal.Data;

[CustomFhirResource]

[Hl7.Fhir.Introspection.FhirType("Activity", "http://hl7.org/fhir/StructureDefinition/Activity", IsResource = true)]
public class ActivityEntity: ResourceEntity
{


    public IdentifierEntity? Identifier { get; set; }

    public ResourceReferenceEntity Application { get; set; }

    // Activity Type: 
    public string Type { get; set; }

    public string TaskType { get; set; }

    public string  KtloType { get; set; } 

    public string Frequency { get; set; }

    public string Status { get; set; }

    public PeriodEntity OriginalPlannedPeriod { get; set; }

    public PeriodEntity PlannedPeriod { get; set; }

    public PeriodEntity ActualPeriod { get; set; }

    public string Remark { get; set; }


    public string DemandId { get; set; }

    // KtloManday
    public decimal? PlannedManday { get; set; }
    public decimal OriginalPlannedTaskManday { get; set; }

    public string  PlannedJobGrade { get; set; }

    public int HeadCount { get; set; }


    public decimal? KtloMandayCost { get; set; }

    public string AopgSpoc { get; set; }


    public partial class AssignedResourceComponent : BackboneEntity
    {
        // primaryFA, secondaryFA, otherFA, responsibleManager, managerAssigned, servieLead
        public string Role { get; set; }
        public string UserId { get; set; }
        public string? Location { get; set; }
        public int? EstimatedEffort  { get; set; }

        public decimal? EffortWeightagePercentage { get; set; }

    }

    // role: primaryFA, secondaryFA, otherFA, responsibleManager, managerAssigned, servieLead
    public List<AssignedResourceComponent> AssignedResource { get; set; }




    public decimal? RefundManday { get; set; }
    public string? RefundStatus { get; set; }

    public string? RefundReason { get; set; }

    public string BillingTrigger { get; set; }
    public string BillingStatus { get; set; }

    public bool RequireSupportingArtefacts { get; set; }


    public string KivReason { get; set; }
    public string KivReasonRemark { get; set; }
    public string OverdueReason { get; set; }
    public string OverdueRemark { get; set; }

    // plannedToBePerformedAt
    public string PlannedStaffLocation { get; set; }

    public string  TaskExperience { get; set; }

    public string UseOfOperationManual { get; set; }


    // 01-Yes, 02-No-With PD Approval, 03-No-Without PD Approval(Not acceptable)
    public string UsingSignOffTemplate { get; set; }


    public bool LockStatus { get; set; }


  
    public partial class ArtefactComponent: BackboneEntity
    {
        public int Version { get; set; }
        public string Rating { get; set; }

        public List<AttachmentEntity> Attachment { get; set; }
    }

    public List<ArtefactComponent> Artefacts { get; set; }
}
