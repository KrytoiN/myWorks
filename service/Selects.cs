using System;

namespace service
{
    public class Selects
    {
        public Selects()
        {

        }

        public string selectTable(string nameTable)
        {
            return "select * from " + nameTable;
        }

        public string selectInstalSoft(string numPC)
        {
            return "select pc.name, pc.ipAddress, pc.macAddress, software.descript from pc inner join applications using(numberPC) inner join software using(numberSoft) where applications.status = true and numberPC = " + numPC;
        }

        public string selectAppControl(bool status)
        {
            return "select numberApp, numberPC, numberSoft, dateApp, executor, dateComplete from applications where status = " + Convert.ToString(status);
        }

        public string selectDistinct(string name, string table)
        {
            return "select distinct " + name + " from " + table;
        }

        public string selectExecutor(string executor)
        {
            return "select numberApp, numberPC, numberSoft, dateApp, status, dateComplete from applications where executor = " + "'" + executor + "'";
        }

        public string selectStatusExecutors(bool status, string executor)
        {
            return "select numberApp, numberPC, numberSoft, dateApp, dateComplete from applications where (executor = " + "'" + executor + "'" + " and status = " + Convert.ToString(status) + ")";
        }

        public string selectStatusPC(string status)
        {
            return "select numberPC, ipAddress, macAddress, name, procModel, amountRAM, hdModel, typeVideoc, catSoft, typePC, modelPC, netStatus, audience, typeRoom, invNum, addInfo, login, password from PC where statusPC = '" + status + "'";
        }

        private string replace(string x)
        {
            DateTime a = Convert.ToDateTime(x);
            return a.ToString("yyyy-MM-dd");
        }

        public string selectDate2(string date1)
        {
            string output = replace(date1);
            return "select dateEnd from software where dateBuy = " + "'" + output + "'";
        }

        public string selectAllSoft(string date1, string date2, string type, string cat)
        {
            return "select numberSoft, statLic, validLic, numLic, ver, descript, val, division, needUpd, invNum, requirem, useLic, licNumber, pass, lang, leftLic from Software where typeLic = '" + type + "' and dateBuy = '" + replace(date1) + "' and dateEnd = '" + replace(date2) + "' and category = '" + cat + "'";
        }

        public string selectDateSoft(string date1, string date2)
        {
            return "select numberSoft, typeLic, statLic, validLic, numLic, ver, category, descript, val, division, needUpd, invNum, requirem, useLic, licNumber, pass, lang, leftLic from Software where dateBuy = '" + replace(date1) + "' and dateEnd = '" + replace(date2) + "'";
        }

        public string selectTypeSoft(string type)
        {
            return "select numberSoft, statLic, dateBuy, dateEnd, validLic, numLic, ver, category, descript, val, division, needUpd, invNum, requirem, useLic, licNumber, pass, lang, leftLic from Software where typeLic = '" + type + "'";
        }

        public string selectCatSoft(string cat)
        {
            return "select numberSoft, typeLic, statLic, dateBuy, dateEnd, validLic, numLic, ver, descript, val, division, needUpd, invNum, requirem, useLic, licNumber, pass, lang, leftLic from Software where category = '" + cat + "'";
        }

    }
}
