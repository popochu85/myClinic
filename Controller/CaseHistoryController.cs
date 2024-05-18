using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClinic.Model;

namespace myClinic.Controller
{
    internal class CaseHistoryController
    {
        CaseHistory caseHistory=new CaseHistory();
        public string addNewHx(CaseHistory Hx)
        {

            string msg = "";
            try
            {
                if (Hx.cc.Equals(""))
                {
                    return "主訴欄位請勿為空!!";
                }
                if (Hx.dx.Equals(""))
                {
                    return "診斷欄位請勿為空!!";
                }


                caseHistory.addNewHx(Hx);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;

        }
        public bool addMed(CaseHistory caseHx)
        {
            bool result=false;
            if (caseHistory.addMed(caseHx))
            {
                result = true;
            }
            return result;
        }




    }
}
