using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClinic.Model;

namespace myClinic.Controller
{
    public class MedicineController
    {

        public Medicine med { get; set; }
        public MedicineController()
        {
            this.med = new Medicine(); // 實例化
        }

        /// <summary>
        /// 取得全部的藥品
        /// </summary>
        /// <returns></returns>
        public List<Medicine> GetMeds()
        {
            return med.GetMeds();
        }

       
        /// <summary>
        /// 新增員工
        /// </summary>
        /// <param name="emp">定義好的員工傳進來</param>
        /// <returns></returns>
        //public string insertMed(Medecine med)
        //{
        //    string msg = "";
        //    try
        //    {
        //        if (med.MedId.Equals(""))
        //        {
        //            return "員工編號請勿為空!!";
        //        }

        //        if (med.MedName.Equals(""))
        //        {
        //            return "員工姓名請勿為空!!";
        //        }

        //        if (med.MedEf.Equals(""))
        //        {
        //            return "性別請勿為空!!";
        //        }

        //        if (med.MedSe.Equals(""))
        //        {
        //            return "性別請勿為空!!";
        //        }
        //        if (med.MedNotice.Equals(""))
        //        {
        //            return "性別請勿為空!!";
        //        }


        //        Medecine.insertMed(med);
        //    }
        //    catch (Exception ex)
        //    {
        //        msg = ex.Message;
        //    }
        //    return msg;
        //}

        public bool updateEmp(Employee emp)
        {
            return true;// 修改成功
        }

        public bool deleteEmp(Employee emp)
        {
            return true;// 刪除成功
        }
    }
}
