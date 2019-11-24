using HospitalManagementSystem.Helpers;
using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace HospitalManagementSystem.ViewModels
{
    public class DocumentViewModel : BaseViewModel
    {
        private string _DocumentID;
        public string DocumentID
        {
            get { return _DocumentID; }
            set
            {
                if (value != _DocumentID)
                {
                    _DocumentID = value;
                    RaisePropertyChanged(() => DocumentID);
                }
            }
        }
        private string _DocumentType;
        public string DocumentType
        {
            get { return _DocumentType; }
            set
            {
                if (value != _DocumentType)
                {
                    _DocumentType = value;
                    RaisePropertyChanged(() => DocumentType);
                }
            }
        }
        private string _DocumentPath;
        public string DocumentPath
        {
            get { return _DocumentPath; }
            set
            {
                if (value != _DocumentPath)
                {
                    _DocumentPath = value;
                    RaisePropertyChanged(() => DocumentPath);
                }
            }
        }
        private string _EnrollmentNo;
        public string EnrollmentNo
        {
            get { return _EnrollmentNo; }
            set
            {
                if (value != _EnrollmentNo)
                {
                    _EnrollmentNo = value;
                    RaisePropertyChanged(() => EnrollmentNo);
                }
            }
        }
        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
            set
            {
                if (value != _FileName)
                {
                    _FileName = value;
                    RaisePropertyChanged(() => FileName);
                }
            }
        }
        private string _FullFileName;
        public string FullFileName
        {
            get { return _FullFileName; }
            set
            {
                if (value != _FullFileName)
                {
                    _FullFileName = value;
                    RaisePropertyChanged(() => FullFileName);
                }
            }
        }


        private bool _isBusy;
        public bool isBusy
        {
            get { return _isBusy; }
            set
            {
                if (value != _isBusy)
                {
                    _isBusy = value;
                    RaisePropertyChanged(() => isBusy);
                }
            }
        }


        private bool _IsSelected;
        public bool IsSelected
        {
            get { return _IsSelected; }
            set
            {
                if (value != _IsSelected)
                {
                    _IsSelected = value;
                    RaisePropertyChanged(() => IsSelected);
                }
            }
        }
        private BitmapFrame _DocumentImageSource;
        public BitmapFrame DocumentImageSource
        {
            get { return _DocumentImageSource; }
            set
            {
                if (value != _DocumentImageSource)
                {
                    _DocumentImageSource = value;
                    RaisePropertyChanged(() => DocumentImageSource);
                }
            }
        }
        public object Parameter { get; set; }
        public ICommand Command { get; set; }

        private int _SRNo;
        public int SRNo
        {
            get { return _SRNo; }
            set
            {
                if (value != _SRNo)
                {
                    _SRNo = value;
                    RaisePropertyChanged(() => SRNo);
                }
            }
        }
        private int _ProgressPercentage;
        public int ProgressPercentage
        {
            get { return _ProgressPercentage; }
            set
            {
                if (value != _ProgressPercentage)
                {
                    _ProgressPercentage = value;
                    RaisePropertyChanged(() => ProgressPercentage);
                }
            }
        }
        public virtual void RemoveDocument(object o)
        {

        }


    }
    public class DocumentModel : DocumentViewModel
    {
        public ICommand cmdDone { get { return new DelegateCommand(Done, canDone); } }

        private bool canDone()
        {
            return true;
            
        }

        private void Done()
        {
           // UploadToBlob();
        }
       

        public DocumentModel()
        {
          lstDocuments_ = new ObservableCollection<DocumentViewModel>();
        }
        private ObservableCollection<DocumentViewModel> _lstDocuments;
        public  ObservableCollection<DocumentViewModel> lstDocuments_
        {
            get { return _lstDocuments; }
            set
            {
                if (value != _lstDocuments)
                {
                    _lstDocuments = value;
                    RaisePropertyChanged(() => lstDocuments_);
                }
            }
        }
        public override void RemoveDocument(object o)
        {
            DocumentViewModel s = o as DocumentViewModel;
            lstDocuments_.Remove(s);
            //s.SRNo = SRNo--;
            //counter--;
        }


    }
}
