using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class PolicyIssuance : BaseModel 
{
    // =========================
    // Ý 1 — Header / Request
    // =========================

    public string? RequestType { get; set; }             // c_reqType

    public DateTime? RequestDate { get; set; }           // c_reqDate
    public DateTime? DueDate { get; set; }               // c_dueDate
    public DateTime? InsuredDate { get; set; }           // c_dateInsured

    public string? QuotationCode { get; set; }           // c_jogetQuoNum
    public string? QuotationParentCode { get; set; }        // c_jogetQuoNum1
    public long? QuotationId { get; set; }             // c_quotationId 
    // =========================
    // Ý 2 — Policy / PolicyHolder / Product / Line
    // =========================
    public string? PolicyNo { get; set; }                // c_policyNo
    public string? PolicyHolderId { get; set; }          // c_policyHolder
    //Quotation refer
    //public string? ProductCode { get; set; }             // c_productName  (join Product/Line master)
    //public string? ProductType { get; set; }             // c_productType


    //public DateTime? PolicyPeriodStartDate { get; set; } // c_periodInsStart

    public int? PolicyQuantity { get; set; }             // c_quantityOfPolicy

    // =========================
    // Ý 3 — PIC / Assignee / Routing
    // =========================
    // REMOVED BY DESIGN (do not include in PI one-row model)

    // =========================
    // Ý 4 — Status / Timeline / SLA
    // =========================
    //public string? IssueStatusCode { get; set; }         // c_piStatus
    //public string? IssueStatusLabel { get; set; }        // c_piStatusLabel
    //public string? OverallStatusCode { get; set; }       // c_status


    // SLA: DROPPED (c_a1Days, c_a1DaysOver, c_a1_flag, c_quoNumFlag)

    // =========================
    // Ý 5 — Remarks / Notes / Follow-up
    // =========================
    public string? Subject { get; set; }                 // c_subject
    public string? Notes { get; set; }                   // c_notes
    public string? Reason { get; set; }                  // c_reason


    public string? FollowUpNote { get; set; }            // c_followUp

    // NOTE: c_piRemarks is TODO to review (merge into Notes/Remarks)

    //// =========================
    //// Ý 6 — RI / Co-insurance / Premium
    //// =========================
    //public string? RiScheme { get; set; }                // c_RIScheme
    //public string? RiClosings { get; set; }              // c_RIClosings
    //public string? ReinsuranceType { get; set; }         // c_reinsurrance

    //public string? CoInsuranceOutward { get; set; }      // c_coInsuranceOutward
    //public string? CoInsuranceNote { get; set; }         // c_noteForCoInsuranceOutward
    //public string? CoInsurerName { get; set; }           // c_NameCoInsurer

    //public decimal? FinalPremium { get; set; }           // c_finalPremium
    //public string? PremiumBreakdown { get; set; }        // c_premiumBreakdown

    //// TODO: RI & Premium attachments – move to Attachment module
    //// public string? RiSchemeAttachment { get; set; }    // c_RISchemeAtt
    //// public string? RiClosingsAttachment { get; set; }  // c_RIClosingsAtt
    //// public string? PremiumBreakdownAttachment { get; set; } // c_premiumBreakdownAtt
    //// public string? EmailInformRiAttachment { get; set; }    // c_emailInformRIAtt

    //// =========================
    //// Ý 7 — KYC / Compliance / Declaration
    //// =========================
    //public string? IsKycChecked { get; set; }            // c_KYCChecked (Checked/NULL/Yes/No...)
    //public string? DeclarationText { get; set; }         // c_declaration
    //public string? URF { get; set; }                     // c_URF  (keep name)
    //public string? IsBodApproved { get; set; }           // c_BODApproved
    //public string? HoldCoverType { get; set; }           // c_holdCover

    //// TODO: Compliance attachments – move to Attachment / Compliance module
    //// public string? KycCheckedAttachment { get; set; }  // c_KYCCheckedAtt
    //// public string? DeclarationAttachment { get; set; } // c_declarationAtt
    //// public string? URFAttachment { get; set; }         // c_URFAtt
    //// public string? BodApprovedAttachment { get; set; } // c_BODApprovedAtt
    //// public string? HoldCoverAttachment { get; set; }   // c_holdCoverAtt

    //// =========================
    //// Ý 8 — Asset / Property / Machinery Lists
    //// =========================
    //public string? MachineryList { get; set; }           // c_listOfMachineries
    //public string? PropertyTypeList { get; set; }        // c_typeOfPropertyList
    //public string? FactoryOperationYears { get; set; }   // c_operationYearofFactories
    //public string? ChassisEngineNumber { get; set; }     // c_chasisEngineNumber
    //public string? NewReplacementValue { get; set; }     // c_newReplacementValue
    //public string? SumInsuredBreakdown { get; set; }     // c_breakdownSI
    //public string? IsGlobalCover { get; set; }           // c_global (Both/Yes/No)
    //public string? PolicyLocation { get; set; }          // c_piLocation
    [MaxLength(4000)]
    public string? TurnAroundTimeAttributes { get; set; } = "";

    //Build
    public string? StageDept { get; set; } = "";
    public string? StageAccount { get; set; } = "";
    public string? WorkflowStatus { get; set; } = "";
    public string? PolicyIssuanceStatus { get; set; } = "";
    [MaxLength(4000)]
    public string? PIC { get; set; } = "";
    [MaxLength(4000)]
    public string? LeaderPIC { get; set; } = "";
    [MaxLength(4000)]
    public string? HODPIC { get; set; } = "";

    public long? ReinsuranceId { get; set; }
    [MaxLength(4000)]
    public string? PolicyIssuanceCode { get; set; }

    public long? ClientId { get; set; }
    [MaxLength(8000)]
    public string ClientName { get; set; }
    public long? DocumentId { get; set; }
    public long? AttachmentId { get; set; }
    public long? BranchId { get; set; }
    public string? BranchCode { get; set; }
    // TODO: Asset list attachments – move to Attachment module
    // public string? HardSoftCopy { get; set; }           // c_hardSoftCopy
}