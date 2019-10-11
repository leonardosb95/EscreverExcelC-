using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscreverNoExcel.Controllers
{
    public class FormataExcelCtrl
    {

        public static void formatarPlanilha()
        {

            FileInfo caminhoNomeArquivo = new FileInfo(@"C:\Users\lbispo\Desktop\Usuario.xlsx");
            ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets["Usuario"];
            planilha.Cells[1,1,1,4].AutoFitColumns();

        }
    }
}
