using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRegistration.Application.Models
{
    public class EmailSettings
    {

        private string _apiKey;
        public string ApiKey
        {
            get
            {
                return _apiKey;
            }
            set
            {
                _apiKey = "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";
            }
        }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
}
