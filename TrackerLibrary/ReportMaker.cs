using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class ReportMaker
    {
        public static string FullFilePath(this string fileName) //PriceModel.csv
        {

            //C:\Raporlar\PriceModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\ {fileName}";


        }




    }
}
