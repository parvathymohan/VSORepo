using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTA.DataAccess.Utilities
{
    public static class Constants
    {
        public enum ErrorStatus
        {
            NoIssue=0,
            IssueExists = 20, //An issue detected in the record
            NoLicensePlateNumber=1,
            StateIssue=3,
            LicensePlateNumberContainsError=2,
            DeactivateLicensePlateNumberNotActiveErr = 4,//This lic plate is not active with this account and fleet file says to deactivate it
            LicensePlateAlreadyActiveWar = 5,//Lic plate XX-XXXXXX is already active with this account and fleet file says to activate it
            PredatedLicensePlateWar = 6,//Predated-*-Request to activate LP CA-93373D1 on this account on Date1(MM/DD/YYYY) but activated on Date2(MM/DD/YYYY)
            DeactivateLicensePlateNumberReturnStatusWar = 7,//Lic plate TX-DYM5654 is already in returned status with this account and fleet file says to deactivate it
            ReturnTagNotActiveWar = 8,//This tag is not active with this account id and plate pass file says return this tag for this account
            TagAlreadyActiveWar = 9,//This tag is already active with account <acct_id> on same lic plate OB77801
            
        }
        public static string Licplate = "Lic plate";
        public static string LicensePlatesActiveWar = "is already active with this account and fleet file says to activate it";
        public static string Predated = "Predated";
        public static string DeactivateLicensePlateNotActiveErr = "This lic plate is not active with this account and fleet file says to deactivate it";
        public static string DeactivateLicensePlateReturnStatusWar = "is already in returned status with this account and fleet file says to deactivate it";
        public static string ReturnTagNotActiveWar = "This tag is not active with this account id and plate pass file says return this tag for this account";
        public static string TagAlreadyActiveWar = "This tag is already active with account";
        public static string StateIssue = "parent key not found";
        public static int BarCgartRoundCurve=4;
    }
}
