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

        public Medicine medicine { get; set; }
        public MedicineController()
        {
            this.medicine = new Medicine(); // 實例化
        }

        /// <summary>
        /// 取得全部的藥品
        /// </summary>
        /// <returns></returns>
        public List<Medicine> GetMeds()
        {
            return medicine.GetMeds();
        }
        /// <summary>
        /// 搜尋藥物
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="empName"></param>
        /// <returns></returns>
        public List<Medicine> GetMedicines(string medId, string medName,string medEf,string medSe)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            if (!medId.Equals(""))
            {
                pairs.Add("medId", medId);
            }
            if (!medName.Equals(""))
            {
                pairs.Add("medName", medName);
            }
            if (!medEf.Equals(""))
            {
                pairs.Add("medEf", medEf);
            }
            if (!medSe.Equals(""))
            {
                pairs.Add("medSe", medSe);
            }
            return medicine.GetMedicines(pairs);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="medId"></param>
        /// <param name="medName"></param>
        /// <param name="medEf"></param>
        /// <param name="medSe"></param>
        /// <returns></returns>
        public List<Medicine> GetMedicines(string medName)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            
            if (!medName.Equals(""))
            {
                pairs.Add("medName", medName);
            }
            return medicine.GetMedicines(pairs);
        }
        /// <summary>
        /// 新增藥物
        /// </summary>
        /// <param name="med"></param>
        /// <returns></returns>
        public string InsertMed(Medicine med)
        {

            string msg = "";
            try
            {
                if (med.MedId.Equals(""))
                {
                    return "藥品編號請勿為空!!";
                }

                if (med.MedName.Equals(""))
                {
                    return "藥品名稱請勿為空!!";
                }
                if (med.MedEf.Equals(""))
                {
                    return "藥品作用請勿為空!!";
                }
                if (med.MedSe.Equals(""))
                {
                    return "藥品副作用請勿為空!!";
                }
                if (med.MedNotice.Equals(""))
                {
                    return "藥品注意事項請勿為空!!";
                }


                medicine.insertMed(med);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public string updateMed(Medicine med)
        {
            string msg = "";
            try
            {
                if (med.MedId.Equals(""))
                {
                    return "藥品編號請勿為空!!";
                }

                if (med.MedName.Equals(""))
                {
                    return "藥品名稱請勿為空!!";
                }
                if (med.MedEf.Equals(""))
                {
                    return "藥品作用請勿為空!!";
                }
                if (med.MedSe.Equals(""))
                {
                    return "藥品副作用請勿為空!!";
                }
                if (med.MedNotice.Equals(""))
                {
                    return "藥品注意事項請勿為空!!";
                }


                medicine.updateMed(med);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;// 修改成功
        }

        public bool deleteMed(Medicine med)
        {
                return med.deleteMed(med);
        }
    }
}
