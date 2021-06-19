using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace XF.MasterDetailPage.Prism.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string BackImage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Date { get; set; }

        public string FormatedDate 
        {
            get => Date.ToString("Y", CultureInfo.InvariantCulture);
        }

    }
}
