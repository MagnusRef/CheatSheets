using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpCalcWinApp
{
    class ip
    {
        private string[] strArrIp;
        private string[] strArrSnm;
        private int[] arrIp;
        private int[] arrSnm;
        private int[] resultArr;
        private string strresult;

        public string getResult() { return this.strresult; }
        public ip(string ip, string snm)
        {
            this.strArrIp = ip.Split('.');
            this.strArrSnm = snm.Split('.');
        }
        public void convert()
        {
            for (int i = 0; i < strArrIp.Length; i++)
            {
                this.arrIp[i] = Convert.ToInt32(strArrIp[i]);
                this.arrSnm[i] = Convert.ToInt32(strArrSnm[i]);
            }
        }
        public void result()
        {
            for (int i = 0; i < arrIp.Length; i++)
            {
                this.resultArr[i] = arrIp[i] & arrSnm[i];
            }

        }
        public void convertback()
        {
            for (int i = 0; i < resultArr.Length; i++)
            {
                strresult +=Convert.ToInt32(resultArr[i]);
            }

        }
    }
}
