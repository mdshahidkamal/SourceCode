using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetterTrackingSystem.DataAccess
{
    interface IOService
    {
        string OpenFileDialog(string defaultPath);
    }
}
