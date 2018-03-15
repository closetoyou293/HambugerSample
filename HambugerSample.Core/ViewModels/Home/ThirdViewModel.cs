using System;
using System.Collections.Generic;
using System.Text;
using HambugerSample.Core.ViewModels.Base;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace HambugerSample.Core.ViewModels.Home
{
    public class ThirdViewModel : BaseViewModel
    {

        private MvxCommand saveAndCloseCommand;

        public MvxCommand SaveAndCloseCommand
        {
            get
            {
                saveAndCloseCommand = saveAndCloseCommand ?? new MvxCommand(DoSaveAndClose);
                return saveAndCloseCommand;
            }
        }

        private MvxPresentationHint popToRootHint;// = Mvx.Resolve<MvxPresentationHint>();

        public ThirdViewModel()
        {
            popToRootHint = Mvx.Resolve<MvxPresentationHint>();
        }

        private void DoSaveAndClose()
        {
            //do whatever work one would do to 'save', and send a message to pop to root               
            Close(this);
            //ChangePresentation(popToRootHint);
        }
    }
}
