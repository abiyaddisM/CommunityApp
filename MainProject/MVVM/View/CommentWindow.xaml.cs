﻿using System.Windows;
using MainProject.MVVM.ViewModel;

namespace MainProject.MVVM.View;

public partial class CommentWindow : Window
{
    
    
    public CommentWindow()
    {
        InitializeComponent();
        
    }

    private void CloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.Hide();
    }
}