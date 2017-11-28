using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcDatePickerDemo.Models
{
    public class DummyModel
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FromDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ToDate { get; set; }
    }
}