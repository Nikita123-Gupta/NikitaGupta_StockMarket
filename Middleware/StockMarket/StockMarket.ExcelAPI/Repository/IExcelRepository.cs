using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ExcelAPI.Repository
{
    public interface IExcelRepository
    {
        public void ImportData(string FilePath);

        public void ExportData();
    }
}
