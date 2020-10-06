﻿using System;
using System.Collections.Generic;

namespace qs_telemetry_dashboard.Models.TelemetryMetadata
{
	[Serializable]
	internal class App
	{
		internal string Name { get; set; }

		internal Guid AppOwnerID { get; set; }

		internal bool Published { get; set; }

		internal DateTime PublishedDateTime { get; set; }

		internal Guid StreamID { get; set; }

		internal string StreamName { get; set; }

		internal IDictionary<Guid, Sheet> Sheets { get; set; }

		internal App(string name, Guid appOwnerId, bool published)
		{
			this.Name = name;
			this.AppOwnerID = appOwnerId;
			this.Published = published;
			this.Sheets = new Dictionary<Guid, Sheet>();
		}

		internal App(string name, Guid appOwnerId, bool published, DateTime publishedDate, Guid streamID, string streamName) : this(name, appOwnerId, published)
		{
			this.PublishedDateTime = publishedDate;
			this.StreamID = streamID;
			this.StreamName = streamName;
		}
	}
}
