using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Web.Mvc;

namespace ChaMPSMVC.Models
{

    public class Schedule
    {

        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public global::System.Int32 schKey { get; set; }
        public global::System.String schName { get; set; }
        public global::System.String schDescription { get; set; }
        public global::System.Int32 schPlant { get; set; }
        public global::System.Int16 schActive { get; set; }
        public global::System.Int16 schShutDown { get; set; }
        public global::System.Int16 schLockType { get; set; }
        public Nullable<global::System.DateTime> schLastScheduledDT { get; set; }
        public Nullable<global::System.DateTime> schLastCompleteDT { get; set; }
        public global::System.Int16 schSinceLastScheduledInd { get; set; }
        public global::System.Int32 schLastScheduledFreq { get; set; }
        public global::System.Int16 schSinceLastCompleteInd { get; set; }
        public global::System.Int32 schLastCompletedFreq { get; set; }
        public global::System.Int32 schEarlyDays { get; set; }
        public global::System.Int32 schAssignedTo { get; set; }
        public global::System.Int16 schValidMon { get; set; }
        public global::System.Int16 schValidTue { get; set; }
        public global::System.Int16 schValidWed { get; set; }
        public global::System.Int16 schValidThru { get; set; }
        public global::System.Int16 schValidFri { get; set; }
        public global::System.Int16 schValidSat { get; set; }
        public global::System.Int16 schValidSun { get; set; }
        public global::System.Int32 schUptId { get; set; }
        public global::System.DateTime schUptDT { get; set; }
    }

}