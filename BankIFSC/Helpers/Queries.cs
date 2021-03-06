﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankIFSC.Helpers
{
    public static class Queries
    {
        public static string GETALLBRANCHES = "SELECT BB.ID, BB.NAME AS BRANCH, BB.IFSC, B.NAME AS BANKNAME, D.NAME AS DISTRICT, S.NAME AS STATE " +
                                        "FROM BANKBRANCHES BB JOIN BANKS B ON BB.BANKSID = B.ID " +
                                        "JOIN DISTRICTS D ON BB.DISTRICTID = D.ID " +
                                        "JOIN STATES S ON D.STATEID = S.ID ORDER BY BB.ID";

        public static string USEREXISTS = "SELECT * FROM USERS WHERE USERID = '{0}'";

        public static string AUTHENTICATEUSER = "SELECT * FROM USERS WHERE USERID = '{0}' AND PASSWORD = '{1}'";

        public static string GETALLDISTRICTSFORSTATE = "SELECT * FROM DISTRICTS WHERE STATEID = {0}";

        public static string ADDNEWBRANCH = "INSERT INTO BANKBRANCHES VALUES('{0}',{1},{2},{3})";

        public static string GETALLSTATES = "SELECT * FROM STATES";

        public static string DELETEBRANCH = "DELETE FROM BANKBRANCHES WHERE ID = {0}";

    }
}