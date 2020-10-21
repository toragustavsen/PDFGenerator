namespace PDFGenerator.Services
{
    public class PDFServiceConfig
    {
        public static string SectionName => "PDFServiceConfig";
        public string ChromiumVersionUrl { get; set; }
        public string PaperWidth { get; set; }
        public string PaperHeight { get; set; }
        public string MarginTop { get; set; }
        public string MarginRight { get; set; }
        public string MarginBottom { get; set; }
        public string MarginLeft { get; set; }
    }
}
