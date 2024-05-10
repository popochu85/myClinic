using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClinic.Model
{
    internal class CaseHistory
    {

        //病歷


        /// <summary>
        /// 病歷號碼
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 病歷編號
        /// </summary>
        public string caseHistoryId { get; set; }
        /// <summary>
        /// 診斷
        /// </summary>
        public string dx { get; set; }
        /// <summary>
        /// 主訴
        /// </summary>
        public string cc { get; set; }
        /// <summary>
        /// 看診醫師
        /// </summary>
        public string empNo { get; set; }
        /// <summary>
        /// 看診日期
        /// </summary>
        public string dxDate { get; set; }

        //藥單

        /// <summary>
        /// 藥品順序(在藥單上)
        /// </summary>
        public string MedSN { get; set; }
        /// <summary>
        /// 藥品編號
        /// </summary>
        public string MedId { get; set; }
        /// <summary>
        /// 藥品劑量
        /// </summary>
        public string MedDose { get; set; }
        /// <summary>
        /// 藥品使用頻次
        /// </summary>
        public string MedFreq { get; set; }


    }
}
