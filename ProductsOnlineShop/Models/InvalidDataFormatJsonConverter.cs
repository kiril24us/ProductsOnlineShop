using Newtonsoft.Json;
using System;

namespace ProductsOnlineShop.Models
{
    internal class InvalidDataFormatJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // implement in case you're serializing it back
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var dataString = (string)reader.Value;
            DateTime date = ParseStringToDate(dataString);
            return date;
        }

        private DateTime ParseStringToDate(string dataString)
        {
            return Convert.ToDateTime(dataString);
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}