using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Reflection;

namespace Veracode.ApiClients.SCAAgent.Api.Patches
{
	public class EmbeddedPropertyConverter : JsonConverter
	{
		private static readonly string PropertyName = "_embedded";

		public override bool CanConvert(Type objectType)
		{
			var properties = objectType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
			return properties.Any(p => p.Name == PropertyName);
		}

		public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			var obj = Activator.CreateInstance(objectType)!;
			var jObj = JObject.Load(reader);

			foreach (var property in objectType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
			{
				var jProperty = jObj.Property(property.Name);

				if (property.Name == PropertyName)
				{
					var array = (jProperty?.Value as JObject)?.Properties().FirstOrDefault()?.Value as JArray;
					property.SetValue(obj, array?.ToObject(property.PropertyType, serializer), null);
				}
				else
				{
					var value = jProperty?.ToObject(property.PropertyType, serializer);
					property.SetValue(obj, value, null);
				}
			}

			return obj;
		}

		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
			=> serializer.Serialize(writer, value);
	}
}
