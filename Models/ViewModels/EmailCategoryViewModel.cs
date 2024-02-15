using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagePack.Formatters;

namespace ContactPro.Models.ViewModels
{
    public class EmailCategoryViewModel
    {
        public List<Contact>? Contacts { get; set; }
        public EmailData? EmailData { get; set; }
    }
}