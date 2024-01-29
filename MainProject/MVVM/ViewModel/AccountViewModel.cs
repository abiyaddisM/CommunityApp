﻿using System.Collections.ObjectModel;
using System.Windows;
using MainProject.MVVM.Model;
using WpfApp1.Services;

namespace MainProject.MVVM.ViewModel;

public class AccountViewModel:ViewModelBase
{
    public string UserName { set; get; }
    public ObservableCollection<PostModel> PostModels { get; set; }
    private RetrieveAccountPostService RetrieveAccountPostService;
    private RetrieveUserInformationService _retrieveUserInformationService;
    public UserInformationModel userInformationModel { get; set; }
    public LoginModel loginModel { get; set; }
    public AccountViewModel(UserInformationModel userInformationModel,LoginModel loginModel)
    {
        UserName = $"@{loginModel.Username}";
        PostModels = new ObservableCollection<PostModel>();
        this.userInformationModel = userInformationModel;
        this.loginModel = loginModel;
        RetrieveAccountPostService = new RetrieveAccountPostService(loginModel.ID,PostModels);
        _retrieveUserInformationService = new RetrieveUserInformationService(loginModel.ID);
        RetrivePostInformation();
        RetriveUserInformation();
    }

    void RetrivePostInformation()
    {
        RetrieveAccountPostService.Execute();
    }

    void RetriveUserInformation()
    {
        userInformationModel = _retrieveUserInformationService.GetInformation();
    }
}