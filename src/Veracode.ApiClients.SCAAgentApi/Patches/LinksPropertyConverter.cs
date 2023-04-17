using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Veracode.ApiClients.SCAAgent.Api.Models;

namespace Veracode.ApiClients.SCAAgent.Api.Patches;

public class LinksPropertyConverter : JsonConverter<IList<Link>>
{
	public override IList<Link> ReadJson(JsonReader reader, Type objectType, IList<Link> existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		var list = new List<Link>();

		switch (reader.TokenType)
		{
			case JsonToken.StartArray:
				return JArray.Load(reader).ToObject<IList<Link>>();
			case JsonToken.StartObject:
				var dict = JObject.Load(reader).ToObject<IDictionary<string, Link>>();
				list = dict?.Select(p =>
				{
					var link = p.Value;
					link.Type = p.Key;
					return link;
				}).ToList();
				break;
		}

		return list;
	}

	public override void WriteJson(JsonWriter writer, IList<Link> value, JsonSerializer serializer)
		=> throw new NotImplementedException();
}
