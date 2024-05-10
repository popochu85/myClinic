﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClinic.Model;

namespace myClinic.Controller
{
    internal class PatientController
    {
        public Patient patient { get; set; }
        public PatientController()
        {
            this.patient = new Patient();
        }

        public List<Patient> getPatients()
        {
            
            return patient.getPatients();
        }
        public string insertPat(Patient pat)
        {

            string msg = "";
            try
            {
                if (pat.patientId.Equals(""))
                {
                    return "病歷號請勿為空!!";
                }

                if (pat.patientName.Equals(""))
                {
                    return "病人姓名請勿為空!!";
                }
                if (pat.allergy.Equals(""))
                {
                    return "過敏史請勿為空!!若沒有過敏史請填無。";
                }
                if (pat.disease.Equals(""))
                {
                    return "疾病史請勿為空!!若沒有疾病史請填無。";
                }
                if (pat.patientAddress.Equals(""))
                {
                    return "地址請勿為空!!";
                }
                if (pat.patientPhone.Equals(""))
                {
                    return "聯絡電話請勿為空!!";
                }


                patient.insertPat(pat);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public string updatePat(Patient pat)
        {

            string msg = "";
            try
            {
                if (pat.patientId.Equals(""))
                {
                    return "病歷號請勿為空!!";
                }

                if (pat.patientName.Equals(""))
                {
                    return "病人姓名請勿為空!!";
                }
                if (pat.allergy.Equals(""))
                {
                    return "過敏史請勿為空!!若沒有過敏史請填無。";
                }
                if (pat.disease.Equals(""))
                {
                    return "疾病史請勿為空!!若沒有疾病史請填無。";
                }
                if (pat.patientAddress.Equals(""))
                {
                    return "地址請勿為空!!";
                }
                if (pat.patientPhone.Equals(""))
                {
                    return "聯絡電話請勿為空!!";
                }


                patient.updatePat(pat);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }
        /// <summary>
        /// 關鍵字搜尋病人
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="empName"></param>
        /// <returns></returns>
        public List<Patient> GetPatients(string patId, string patName,string patientPhone,string patientAddress)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            if (!patId.Equals(""))
            {
                pairs.Add("patientId", patId);
            }
            if (!patName.Equals(""))
            {
                pairs.Add("patientName", patName);
            }
            if (!patientPhone.Equals(""))
            {
                pairs.Add("patientPhone", patientPhone);
            }
            if (!patientAddress.Equals(""))
            {
                pairs.Add("patientId", patientAddress);
            }
            return patient.GetPatients(pairs);
        }
        /// <summary>
        /// 掛號!!
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        public bool regPat(Patient pat)
        {
            bool result=false;
            return result;
        }
    }

}

