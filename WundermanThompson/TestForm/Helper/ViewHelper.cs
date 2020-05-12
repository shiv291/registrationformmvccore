using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestForm.Helper
{
    public class ViewHelper
    {
        public List<KeyValueModel> GetOptions()
        {
            List<KeyValueModel> list = new List<KeyValueModel>();
            list.Add(new KeyValueModel() { Key = "Build a business case with the Microsoft Technology Centre", Value = "Build a business case with the Microsoft Technology Centre" });
            list.Add(new KeyValueModel() { Key = "Get hand-on with the Customer Immersion Experience", Value = "Get hand-on with the Customer Immersion Experience" });
            list.Add(new KeyValueModel() { Key = "Skill-up your IT team", Value = "Skill-up your IT team" });
            list.Add(new KeyValueModel() { Key = "Surface trial program", Value = "Surface trial program" });
            list.Add(new KeyValueModel() { Key = "Get customized avice and support for your team", Value = "Get customized avice and support for your team" });

            return list;
        }
    }

    public class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
