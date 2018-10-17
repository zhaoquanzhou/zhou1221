using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug特性作业
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    class GameBugAttribute : Attribute
    {
        public string correctTime;
        public string correctPerson;
        public string correctRecord;
        public string bugDetails;
        public GameBugAttribute(string _correctTime, string _correctPerson, string _correctRecord, string _bugDetails)
        {
            this.correctTime = _correctTime;
            this.correctPerson = _correctPerson;
            this.correctRecord = _correctRecord;
            this.bugDetails = _bugDetails;
        }
    }
}
