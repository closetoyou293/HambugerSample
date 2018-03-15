using System;
using System.Collections.Generic;
using System.Text;

namespace HambugerSample.Core.Interfaces
{
    public interface IDialogService
    {
        void Alert(string message, string title, string okbtnText);
    }
}
