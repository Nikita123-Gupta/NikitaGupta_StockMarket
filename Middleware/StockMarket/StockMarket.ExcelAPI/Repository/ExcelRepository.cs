using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using System.Text;
using StockMarket.ExcelAPI.Models;
using StockMarket.ExcelAPI.DBAcess;

namespace StockMarket.ExcelAPI.Repository
{
    public class ExcelRepository : IExcelRepository
    {
        private ExcelDBContext db;
        
        private readonly IWebHostEnvironment he;

        
        public ExcelRepository(IWebHostEnvironment _he, ExcelDBContext _db )
        {
            db = _db;
            he = _he;
        }

       
        public void ExportData()
        {
            string rootFolder = he.WebRootPath;
            string fileName = @"ExportCustomers.xlsx";

            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {

                IList<StockPrice> stock = db.StockPrices.ToList();

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("StockPrice");
                int totalRows = stock.Count();

                worksheet.Cells[1, 1].Value = "RowId";
                worksheet.Cells[1, 2].Value = "CompanyCode";
                worksheet.Cells[1, 3].Value = "StockExchange";
                worksheet.Cells[1, 4].Value = "CurrentPrice";
                worksheet.Cells[1, 5].Value = "Date";
                worksheet.Cells[1, 6].Value = "Time";
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = stock[i].RowId;
                    worksheet.Cells[row, 2].Value = stock[i].CompanyCode;
                    worksheet.Cells[row, 3].Value = stock[i].StockExchange;
                    worksheet.Cells[row, 4].Value = stock[i].CurrentPrice;
                    worksheet.Cells[row, 4].Value = stock[i].Date;
                    worksheet.Cells[row, 4].Value = stock[i].Time;
                    i++;
                }

                package.Save();

            }
        }

        public void ImportData(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            string fileName = file.Name;
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];
                int totalRows = workSheet.Dimension.Rows;

                List<StockPrice> stockPrices = new List<StockPrice>();

                for (int i = 2; i <= totalRows; i++)
                {
                    stockPrices.Add(new StockPrice
                    {
                        CompanyCode = workSheet.Cells[i, 1].Value.ToString().Trim(),
                        StockExchange = workSheet.Cells[i, 2].Value.ToString().Trim(),
                        CurrentPrice = double.Parse(workSheet.Cells[i, 3].Value.ToString().Trim()),
                        Date = DateTime.Parse(workSheet.Cells[i, 4].Value.ToString().Trim()),
                        Time = workSheet.Cells[i, 5].Value.ToString(),
                    });
                }

                db.StockPrices.AddRange(stockPrices);
                db.SaveChanges();

            }
        }
    }
}

