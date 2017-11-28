using System;
using System.Globalization;
using System.Web.Mvc;

namespace AspNetMvcDatePickerDemo
{
    public class DateTimeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (value == null)
                return null;
            if (string.IsNullOrEmpty(value.AttemptedValue))
                return null;

            try
            {
                var date = value.ConvertTo(typeof(DateTime), CultureInfo.GetCultureInfo("et-ee"));
                return date;
            }
            catch
            {
                var dateValue = value.AttemptedValue;
                var formats = new[] { "dd.MM.yyyy", "dd.MM.yyyy H:mm.ss", "yyyy-MM-dd", "yyyy-MM-dd HH:mm:ss" };
                DateTime date;

                if (!DateTime.TryParseExact(dateValue, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    throw;
                }

                return date;
            }
        }
    }

}