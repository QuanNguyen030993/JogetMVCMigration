using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SurveyReportRE.Models.Migration.Base;

public class Quotation : BaseModel
{
    // =========================================================
    // System keys (optional) - user said exclude system keys, so not included.
    // =========================================================
    public string? Subject { get; set; } = "";
    // =========================================================
    // Ý 1 — Header/Request (rename)
    // =========================================================
    public string? RequestNo { get; set; } = "";                 // c_qrNum
    public string? RequestRefNo { get; set; } = "";              // c_refNum
    public string? QuotationCode { get; set; } = "";             // c_jogetQuoNum
    public string? QuotationParentCode { get; set; } = "";
    public DateTime? RequestedDate { get; set; }           // c_reqDate
    public DateTime? DueDate { get; set; }                 // c_dueDate

    public string? RequestType { get; set; } = "";    
    public long? RequestTypeId { get; set; } = 0;               // c_reqType
    public string? QuotationType { get; set; } = "";             // c_typeOfQT

    public string? BusinessChannelName { get; set; } = "";        // c_businessChannel
    public string? SourceOfBusinessName { get; set; } = "";       // c_sourceOfBusiness
    public string? BusinessChannelDisplayName { get; set; } = ""; // c_nameOfBizChannel
    public DateTime? InceptionDate { get ; set ; }
    [MaxLength(4000)]
    public string? LockedReferenceFields { get; set; } = "";
    // =========================================================
    // Ý 2 — PolicyHolder/Insured/Client
    // - Multi-language expandable (3rd language+) via JSON
    // =========================================================
    public string? PolicyHolderId { get; set; } = "";            // c_policyHolder
    public string? PolicyNo { get; set; } = "";

    public string? InsuredId { get; set; } = "";                 // c_ins
    public string? InsuredName { get; set; } = "";               // from c_insNameViet/c_insNameEng

    //public string? ClientCodePA { get; set; } = "";              // c_clientCodePA
    //public string? ClientCodeJG { get; set; } = "";              // c_clientCodeJG

    // Default display (prefer VI -> EN -> any)
    public string? PolicyHolderName { get; set; } = "";          // from c_phNameViet/c_policyHolderViet/c_phNameEng
    public long? ClientId { get; set; }                // from c_clientNameViet/c_clientNameEng
    public string? ClientName { get; set; } = "";                // from c_clientNameViet/c_clientNameEng
    public string? ClientCode { get; set; }
    public string? RegisteredAddress { get; set; } = "";         // from c_registeredAddressViet/c_registeredAddress
    public string? BusinessAddress { get; set; } = "";           // from c_businessAddressViet/c_businessAddressEng

    // Multi-language payload for PolicyHolder/Insured/Client + addresses
    public string? PartyMultiLangJson { get; set; } = "";        // JSON (vi/en/..)

    // =========================================================
    // Ý 3 — Product/Line/CFE (rename; TODO Master Data)
    // =========================================================
    // TODO: Move Product/Line/CFE to Master Data later.
    public string? ProductName { get; set; } = "";               // c_productName
    //public string? ProductDisplayName { get; set; } = "";        // c_productNameView
    //public string? ProductType { get; set; } = "";               // c_productType
    public string? LineName { get; set; } = "";                  // c_lineName
    //public string? SubLineName { get; set; } = "";               // c_lineName1
    public long? QuotationQuantity { get; set; }    


    public string? InsRegisteredAddress { get; set; } = "";
    public string BusinessOccupationName { get; set; } = "";
    public long? Occupation { get; set; } = 0;

    // =========================================================
    // Ý 7 — Workflow status/timeline/users/route (SKIPPED by user)
    // =========================================================

    // Build
    public string? StageDept {get;set;}= "";   
    public string? StageAccount {get;set;}= "";   
    public string? WorkflowStatus {get;set;}   = "";  
    public string? QuotationStatus {get;set;} = "";
    public long? StatusId {get;set;} = 0  ;
    [MaxLength(4000)]
    public string? PIC {get;set;} = "";
    [MaxLength(4000)]
    public string? LeaderPIC {get;set;} = "";
    [MaxLength(4000)]
    public string? HODPIC {get;set;} = "";   
    public long? ProductId { get; set; }
    public string? ProductCode { get; set; } = "";  
    public long? LineId { get; set; }
    public string? LineCode { get; set; } = "";
    public bool? SurveyNeeded { get; set; } =  false;
    public long? ReinsuranceId { get; set; }
    [MaxLength(4000)]
    public string? TurnAroundTimeAttributes { get; set; } = "";
    public long? ResId { get; set; }

    [MaxLength(1000)]
    public long? DocumentId { get; set; }
    public long? AttachmentId { get; set; }
    public long? BranchId { get; set; } 
    public string? BranchCode { get; set; }
    public bool? IsMakeOption { get; set; } = false;
    public string? OptionParentCode { get; set; }   


    
}
