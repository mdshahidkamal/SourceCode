using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
namespace HospitalManagementSystem.Helpers
{
    class WPFMessageBoxService : IMessageBoxService
    {
        public void ShowMessage(string text, string caption, MessageType messageType)
        {
            MessageBox.Show(text, caption); // messageBoxIcon is created based on MessageType // Removed windows forms dependency.
        }

    }
    interface IMessageBoxService
    {
        void ShowMessage(string text, string caption, MessageType messageType);
    }
}
