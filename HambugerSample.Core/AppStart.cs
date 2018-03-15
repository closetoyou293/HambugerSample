using System;
using System.Collections.Generic;
using System.Text;
using HambugerSample.Core.Interfaces;
using HambugerSample.Core.ViewModels.Base;
using HambugerSample.Core.ViewModels.Login;
using MvvmCross.Core.ViewModels;

namespace HambugerSample.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        /// <summary>
        /// The login service.
        /// </summary>
        private readonly ILoginService _loginService;

        public AppStart(ILoginService loginService)
        {
            _loginService = loginService;
        }

        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public void Start(object hint = null)
        {
            // If your application uses a secure API this first call attempts to log the user into the application
            // using any credentials stored from a previous session.  If there are
            // none stored we should present the login screen, else go straight into the app
            if (_loginService.Login())
            {
                ShowViewModel<MainViewModel>();
            }
            else
            {
                ShowViewModel<LoginViewModel>();
            }
        }
    }
}
