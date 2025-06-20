using System;

namespace dp2__factory_documents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            DocumentFactory pdfFactory = new PdfFactory();
            DocumentFactory excelFactory = new ExcelFactory();

            IDocument wordDoc = wordFactory.CreateDocument();
            IDocument pdfDoc = pdfFactory.CreateDocument();
            IDocument excelDoc = excelFactory.CreateDocument();

            wordDoc.Open();
            pdfDoc.Open();
            excelDoc.Open();
        }
    }
}
