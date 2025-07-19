using System;
using System.Collections.Generic;

namespace Domain.Entities;


public partial class User
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string UserName { get; set; }

    public byte[] Password { get; set; }

    public bool? Admin { get; set; }

    public bool? Manager { get; set; }

    public bool? Qms { get; set; }

    public bool? Personals { get; set; }

    public bool? Customers { get; set; }

    public bool? Qmsmasterlist { get; set; }

    public bool? QmsdocManage { get; set; }

    public bool? QmscodeRequest { get; set; }

    public bool? QmsdeptManager { get; set; }

    public bool? QmscompManager { get; set; }

    public byte[] TimeStamp { get; set; }

    public bool? SurveyRequests { get; set; }

    public bool? SurveyRequestsEdit { get; set; }

    public bool? AccView { get; set; }

    public bool? AccEdit { get; set; }

    public bool? PersonalsView { get; set; }

    public bool? PersonalsEdit { get; set; }

    public bool? EducationsView { get; set; }

    public bool? EducationsEdit { get; set; }

    public bool? Bn { get; set; }

    public bool? Mn { get; set; }

    public bool? Bm { get; set; }

    public bool? Bt { get; set; }

    public bool? Mt { get; set; }

    public bool? Evm { get; set; }

    public bool? Evpm { get; set; }

    public bool? Nmp { get; set; }

    public bool? Dhow { get; set; }

    public bool? WebNews { get; set; }

    public bool? WebReports { get; set; }

    public bool? WebArticles { get; set; }

    public bool? WebUpdate { get; set; }

    public bool? ExistingSecretary { get; set; }

    public bool? IndManager { get; set; }

    public bool? IndSecretary { get; set; }

    public bool? IndSurveyor { get; set; }

    public bool? IndView { get; set; }

    public bool? ViewAllTabs { get; set; }

    public bool? ViewReportAllBranch { get; set; }

    public bool? WebTabView { get; set; }

    public bool? WebVesselView { get; set; }

    public int? GreenColor { get; set; }

    public bool Minute { get; set; }

    public bool EnglishMinute { get; set; }

    public bool MinuteToTabs { get; set; }

    public bool Tabs { get; set; }

    public bool EnglishTabs { get; set; }

    public bool TabToMinute { get; set; }

    public bool TabTransferToSv { get; set; }

    public bool ClientConfirm { get; set; }

    public bool SetClientForigner { get; set; }

    public bool ViewNotification { get; set; }

    public string ArtemisUserId { get; set; }

    public virtual Personal CodeNavigation { get; set; }
}
