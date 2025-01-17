﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace Insurance_Project.Converters
{
    public class DateConverter : JsonConverter<DateTime>
    {
        private string DateTimeFormat = "yyyy-MM-dd";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(reader.GetString(), DateTimeFormat, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(DateTimeFormat));
        }
    }
}
