using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ClipboardTranslator
{
	[Serializable]
	class Config
	{
		static Config _inst;

		static Config()
		{
			const string CONFIG_FILENAME = "app.config";
			if(!File.Exists(CONFIG_FILENAME))
				return;

			using(var fs = new FileStream(CONFIG_FILENAME, FileMode.Open))
			{
				var serializer = new XmlSerializer(typeof(Config));
				_inst = (Config)serializer.Deserialize(fs);
			}
		}
	}
}
