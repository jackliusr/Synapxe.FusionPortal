using Hl7.Fhir.Model;
using Ihis.FhirEngine.Data.Models;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace Synapxe.FusionPortal.Data;

[CustomFhirResource]

[Hl7.Fhir.Introspection.FhirType("KtloTask", "http://hl7.org/fhir/StructureDefinition/KtloTask", IsResource = true)]
public class KtloTaskEntity: ResourceEntity
{

    public IdentifierEntity? Identifier { get; set; }

    public string? TaskId { get; set; }
    public string? AppName { get; set; }

    public string? Activity { get; set; }

    public string? Frequency { get; set; }

    public string? TaskStatus { get; set; }

    public DateTimeOffset PlannedStartDate { get; set; }

    public DateTimeOffset PlannedEndDate { get; set; }

    // Notice: PlannedStartMonth and PlannedEndMonth 

    public DateTimeOffset ActualStartDate { get; set; } 
    public DateTimeOffset ActualEndDate { get; set; }

    // Notice: ActualStartMonth and ActualEndMonth

    public string? TaskRemark { get; set; }
    public string? KivReason { get; set; }
    public string? KivReasonRemark  { get; set; }

    public string? OverdueReason { get; set; }
    public string? OverdueReasonRemark { get; set; }

    public decimal RefundMd { get; set; }
    public string? RefundStatus { get; set; }
    public string? RefundReason { get; set; }

    public string? PlannedToBePerformedAt { get; set; }

    public string? PerformedByPrimaryFa { get; set; }

    public string? PrimaryFaTaskMd { get; set; }

    public decimal EffortWeightageByPrimaryFa { get; set; }

    public string? PrimaryStaffLocatedAt { get; set; }

    public int EstimatedEffortSpentByPrimaryFa { get; set; }

    public string? PerformedBySecondaryFa { get; set; }

    public decimal SecondaryFaTaskMd { get; set; }

    public string? SecondaryFaTaskStatus { get; set; }

    public decimal EffortWeightageBySecondaryFa { get; set; }

    public string? SecondaryStaffLocatedAt { get; set; }

    public int EstimatedEffortSpentBySecondaryFa { get; set; }

    public decimal EffortByOthers { get; set; }

    public decimal OtherFaTaskMd { get; set; }

    public string? OtherStaffLocatedAt { get; set; }

    public int EstimatedEffortSpentByOtherFa { get; set; }

    public string? StaffContribution { get; set; }

    public string? UserUamMilestones { get; set; }
    public string? ServerUamMilestones { get; set; }
    public string? UamCycle { get; set; }

    public string? UamRemark { get; set; }

    public string? AppPenTestMileStones { get; set; }

    public string? Manager { get; set; }

    public string? ServiceLead  { get; set; }

    public string? Cluster { get; set; }

    public string? Domain { get; set; }

    public string? Subdomain { get; set; }

    public string? TaskEffortIndicator { get; set; }

    public string? TaskExperience { get; set; }

    public string? UseOfOperationsManual  { get; set; }

    public string? ManagerAssigned { get; set; }

    public string? FaSupportRating { get; set; }

    public string? ManagerReviewMonth { get; set; }

    public string? ReviewedByManager { get; set; }

    public string? ManagerReviewRating { get; set; }

    public string? ServiceLeadReviewMonth { get; set; }

    public string? ReviewedByServiceLead { get; set; }

    public string? ServiceLeadReviewRating { get; set; }

    public string? AopgReviewRating { get; set; }

    public string? QualityReviewComment { get; set; }

    public string? FaNameAccuracy  { get; set; }

    public string? TaskUpdates { get; set; }
    public string? SystemCriticality { get; set; }

    public bool InternetFacing { get; set; }

    public bool MobileApp { get; set; }

    public string? SystemId { get; set; }
    public string? DemandId { get; set; }

    public string? KtloType { get; set; }


    public string? TaskType { get; set; }

    public decimal KtloMd { get; set; }

    public decimal CustomTaskMd { get; set; }

    public decimal TaskMd { get; set; }

    public  string? BillingStatus { get; set; }

    public string? BillingTrigger { get; set; }

    public string? JgRate { get; set; }

    public string? KtloHc { get; set; }
    public decimal KtloMdCost { get; set; }

    public decimal KtloTaskCost { get; set; }

    public decimal KtloHeadcount { get; set; }

    public string? ArtefactRequired { get; set; }

    public bool ArtefactProvided { get; set; }

    public string? AopgSpoc { get; set; }

    public string? MissingDates { get; set; }

    public string? InvalidDates { get; set; }

    public string? IncompleteData { get; set; }

}
