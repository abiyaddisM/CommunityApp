﻿using System;
using MainProject.MVVM.ViewModel;
using WpfApp1.Stores;

namespace WpfApp1.Services;

public class ParameterNavigationService<TParameter,TViewModel>
    where TViewModel : ViewModelBase

{
    private readonly NavigationStore _navigationStore;
    private readonly Func<TParameter,TViewModel> _createViewModel;
    
    public ParameterNavigationService(NavigationStore navigationStore, Func<TParameter,TViewModel> createViewModel)
    {
        _navigationStore = navigationStore;
        _createViewModel = createViewModel;
    }

    public void Navigate(TParameter parameter)
    {
        _navigationStore.CurrentViewModel = _createViewModel(parameter);

    }
    
}