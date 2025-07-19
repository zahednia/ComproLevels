using System;
using System.Collections.Generic;

namespace Domain.Entities;


public partial class Personal
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string Name { get; set; }

    public string Family { get; set; }

    public string FatherSName { get; set; }

    public string NationalIc { get; set; }

    public string CityIssued { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string CityBorn { get; set; }

    public string Address { get; set; }

    public string Telephone { get; set; }

    public bool Taahhol { get; set; }

    public string Picture { get; set; }

    public int? PictureFileId { get; set; }

    public string PictureFileTable { get; set; }

    public string NameE { get; set; }

    public string FamilyE { get; set; }

    public int? ResumeFileId { get; set; }

    public string ResumeFileTable { get; set; }

    public string ResumeFileName { get; set; }

    public int? BranchId { get; set; }

    public int? DepartmentId { get; set; }

    public int? Ext { get; set; }

    public int? PositionId { get; set; }

    public DateTime? ExpireCard { get; set; }

    public string Bday { get; set; }

    public string Dobf { get; set; }

    public string FullName { get; set; }

    public string FullNameE { get; set; }

    public DateTime? RecruitmentDateE { get; set; }

    public string RecruitmentDateF { get; set; }

    public int? RecruitmentStatus { get; set; }

    public string Sign { get; set; }

    public int? PictureSignFileId { get; set; }

    public string PictureSignFileTable { get; set; }

    public string JobPositionE { get; set; }

    public string JobPositionF { get; set; }

    public virtual User User { get; set; }
}
