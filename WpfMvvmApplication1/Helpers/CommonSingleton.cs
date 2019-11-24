using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Helpers
{
    using System;

    public sealed class CommonSingleTon
    {
        private static volatile CommonSingleTon instance;
        private static object syncRoot = new Object();

        public readonly string Schoolid = string.Empty;
        public readonly string SchoolName = string.Empty;
        public readonly string SchoolAddress = string.Empty;
        public readonly string AcademicYear = string.Empty;
        public readonly string AcademicYearID = string.Empty;



        private CommonSingleTon()
        {

        }

        public static CommonSingleTon Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CommonSingleTon();
                    }
                }

                return instance;
            }
        }
    }

}
