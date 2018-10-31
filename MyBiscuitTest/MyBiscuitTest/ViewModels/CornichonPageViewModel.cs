using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using MyBiscuitTest.Services;

namespace MyBiscuitTest.ViewModels
{
	public class CornichonPageViewModel : ViewModelBase
	{
	    private readonly IPlatformInfo _platformInfo;
	    private string _text;

	    public string Text
	    {
	        get => _text;
	        set => SetProperty(ref _text, value);
	    }
        public CornichonPageViewModel(INavigationService navigationService, IPlatformInfo platformInfo) : base(navigationService)
        {
            _platformInfo = platformInfo;
        }

	    public override void OnNavigatedTo(INavigationParameters parameters)
	    {
	        base.OnNavigatedTo(parameters);
	        //if (parameters.ContainsKey("text"))
	        //{
	        //    Text = (string)parameters["text"];
	        //}

	        Text = _platformInfo.AndroidVersion();

	    }
	}
}
