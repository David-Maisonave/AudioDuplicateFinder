﻿using System.Windows.Controls;

using AudioDuplicateFinder.Contracts.Views;
using AudioDuplicateFinder.ViewModels;
using AudioDuplicateFinder.Properties;

using MahApps.Metro.Controls;

namespace AudioDuplicateFinder.Views;

public partial class ShellWindow : MetroWindow, IShellWindow
{
    public ShellWindow(ShellViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        SaveWindowPosition = true;
    }


    public Frame GetNavigationFrame()
        => shellFrame;

    public Frame GetRightPaneFrame()
        => rightPaneFrame;

    public void ShowWindow()
        => Show();

    public void CloseWindow() => Close();

    public SplitView GetSplitView()
        => splitView;
}
