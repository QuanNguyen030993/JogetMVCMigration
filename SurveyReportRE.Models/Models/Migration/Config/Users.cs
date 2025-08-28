using Microsoft.EntityFrameworkCore;
using SurveyReportRE.Models.Migration.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace SurveyReportRE.Models.Migration.Config
{

public class Users : BaseModel
{

    [MaxLength(8000)]
    public string name { get; set; }= "";
    [MaxLength(8000)]
    public string mail { get; set; }= "";
    [MaxLength(8000)]
    public string givenname { get; set; }= "";
    [MaxLength(8000)]
    public string sn { get; set; }= "";
    [MaxLength(8000)]
    public string userPrincipalName { get; set; }= "";
    [MaxLength(8000)]
    public string distinguishedName { get; set; }= "";
    [MaxLength(8000)]
    public string department {get;set;} = "";
    // {
    //     get
    //     {
    //         return distinguishedName.Split(',')[1].Remove(0, 3).Trim();
    //     }
    // }
    [MaxLength(8000)]
    public string branch {get;set;} = "";
    // {
    //     get
    //     {
 
    //         string branch = distinguishedName.Split(',')[2].Remove(0, 6).Trim();
    //         if (branch.Trim().ToUpper() == "SGN")
    //         {
    //             return "HCM";
    //         }
    //         return "HN";
    //     }
    // }
    [MaxLength(8000)]
    public string username {get;set;} = "";
    // {
    //     get
    //     {
    //         return userPrincipalName.Split('@')[0];
    //     }
    // }
}
}
