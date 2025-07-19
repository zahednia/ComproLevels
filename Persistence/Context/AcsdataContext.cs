using Application.DataBase;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Persistence.Context;

public partial class AcsdataContext : DbContext , IAcsdataContext
{
    public AcsdataContext()
    {
    }

    public AcsdataContext(DbContextOptions<AcsdataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GeneralUserAccessLevel> GeneralUserAccessLevel { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ACSData;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Persian_100_CI_AS");

        modelBuilder.Entity<GeneralUserAccessLevel>(entity =>
        {
            entity.ToTable("GeneralUserAccessLevel");

            entity.Property(e => e.AccessDelete).HasComment("حذف رکورد جاری");
            entity.Property(e => e.AccessEdit).HasComment("ویرایش رکورد جاری");
            entity.Property(e => e.AccessFirstConfirm).HasComment("سطح دسترسی خاص شماره 1");
            entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevel_Id");
            entity.Property(e => e.AccessNew).HasComment("ایجاد رکورد جدید");
            entity.Property(e => e.AccessPrint).HasComment("چاپ");
            entity.Property(e => e.AccessSecondConfirm).HasComment("سطح دسترسی خاص شماره 2");
            entity.Property(e => e.AccessView).HasComment("مشاهده فرم");
            entity.Property(e => e.UserId).HasColumnName("User_Id");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_Personals").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Bday)
                .HasMaxLength(5)
                .HasComputedColumnSql("(substring([dbo].[PersianDate]([DateOfBirth]),(6),(5)))", false)
                .HasColumnName("BDay");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CityBorn).HasMaxLength(50);
            entity.Property(e => e.CityIssued).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dobf)
                .HasMaxLength(10)
                .HasComputedColumnSql("([dbo].[PersianDate]([DateOfBirth]))", false)
                .HasColumnName("DOBF");
            entity.Property(e => e.ExpireCard).HasColumnType("datetime");
            entity.Property(e => e.Ext).HasDefaultValue(0);
            entity.Property(e => e.Family).HasMaxLength(50);
            entity.Property(e => e.FamilyE).HasMaxLength(50);
            entity.Property(e => e.FatherSName)
                .HasMaxLength(50)
                .HasColumnName("Father's Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(101)
                .HasComputedColumnSql("(([Name]+' ')+[Family])", false);
            entity.Property(e => e.FullNameE)
                .HasMaxLength(101)
                .HasComputedColumnSql("(([NameE]+' ')+[FamilyE])", false);
            entity.Property(e => e.JobPositionE).HasMaxLength(100);
            entity.Property(e => e.JobPositionF).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NameE).HasMaxLength(50);
            entity.Property(e => e.NationalIc)
                .HasMaxLength(50)
                .HasColumnName("National IC");
            entity.Property(e => e.Picture).HasMaxLength(255);
            entity.Property(e => e.PictureFileId).HasColumnName("PictureFileID");
            entity.Property(e => e.PictureFileTable).HasMaxLength(10);
            entity.Property(e => e.PictureSignFileId).HasColumnName("PictureSignFileID");
            entity.Property(e => e.PictureSignFileTable).HasMaxLength(10);
            entity.Property(e => e.PositionId).HasColumnName("Position_ID");
            entity.Property(e => e.RecruitmentDateE)
                .HasComputedColumnSql("([dbo].[PersonnelRecruitmentDate]([ID]))", false)
                .HasColumnType("datetime");
            entity.Property(e => e.RecruitmentDateF)
                .HasMaxLength(10)
                .HasComputedColumnSql("([dbo].[PersianDate]([dbo].[PersonnelRecruitmentDate]([ID])))", false);
            entity.Property(e => e.RecruitmentStatus).HasComputedColumnSql("([dbo].[PersonnelRecruitmentStatus]([ID]))", false);
            entity.Property(e => e.ResumeFileId).HasColumnName("ResumeFileID");
            entity.Property(e => e.ResumeFileName).HasMaxLength(200);
            entity.Property(e => e.ResumeFileTable).HasMaxLength(50);
            entity.Property(e => e.Sign).HasMaxLength(255);
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.UserName, "IX_Users").IsUnique();

            entity.HasIndex(e => e.Code, "IX_Users_1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArtemisUserId).HasMaxLength(450);
            entity.Property(e => e.Bm).HasColumnName("BM");
            entity.Property(e => e.Bn).HasColumnName("BN");
            entity.Property(e => e.Bt).HasColumnName("BT");
            entity.Property(e => e.Evm).HasColumnName("EVM");
            entity.Property(e => e.Evpm).HasColumnName("EVPM");
            entity.Property(e => e.ExistingSecretary).HasDefaultValue(false);
            entity.Property(e => e.IndManager).HasDefaultValue(false);
            entity.Property(e => e.IndSecretary).HasDefaultValue(false);
            entity.Property(e => e.IndSurveyor).HasDefaultValue(false);
            entity.Property(e => e.IndView).HasDefaultValue(false);
            entity.Property(e => e.Mn).HasColumnName("MN");
            entity.Property(e => e.Mt).HasColumnName("MT");
            entity.Property(e => e.Nmp).HasColumnName("NMP");
            entity.Property(e => e.Password).HasMaxLength(500);
            entity.Property(e => e.Qms).HasColumnName("QMS");
            entity.Property(e => e.QmscodeRequest).HasColumnName("QMSCodeRequest");
            entity.Property(e => e.QmscompManager).HasColumnName("QMSCompManager");
            entity.Property(e => e.QmsdeptManager).HasColumnName("QMSDeptManager");
            entity.Property(e => e.QmsdocManage).HasColumnName("QMSDocManage");
            entity.Property(e => e.Qmsmasterlist).HasColumnName("QMSMasterlist");
            entity.Property(e => e.SurveyRequests).HasDefaultValue(false);
            entity.Property(e => e.SurveyRequestsEdit).HasDefaultValue(false);
            entity.Property(e => e.TabTransferToSv).HasColumnName("TabTransferToSV");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1256_CI_AS");
            entity.Property(e => e.WebArticles).HasDefaultValue(false);
            entity.Property(e => e.WebNews).HasDefaultValue(false);
            entity.Property(e => e.WebReports).HasDefaultValue(false);
            entity.Property(e => e.WebUpdate).HasDefaultValue(false);

            entity.HasOne(d => d.CodeNavigation).WithOne(p => p.User)
                .HasPrincipalKey<Personal>(p => p.Code)
                .HasForeignKey<User>(d => d.Code)
                .HasConstraintName("FK_Users_Personals");
        });
        modelBuilder.HasSequence<int>("TabIdSequence").StartsAt(625L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
