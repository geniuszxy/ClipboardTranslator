using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace ClipboardTranslator
{
	/// <summary>
	/// 配置文件
	/// </summary>
	[Serializable]
	public class Config
	{
		#region Config

		/// <summary>
		/// 背景透明度
		/// </summary>
		public int Opacity = 90;
		/// <summary>
		/// 背景颜色
		/// </summary>
		public Colour BackgroundColor = Color.LightGray;
		/// <summary>
		/// 自动隐藏时间(毫秒)
		/// </summary>
		public int AutoHideDelay = 5000;
		/// <summary>
		/// 启动位置
		/// </summary>
		public Point StartPosition = Point.Empty;

		#endregion Config

		#region Misc

		/// <summary>
		/// 配置文件名称
		/// </summary>
		const string CONFIG_FILENAME = "app.config";

		/// <summary>
		/// 单例
		/// </summary>
		static Config _inst;

		/// <summary>
		/// 加载配置文件
		/// </summary>
		public static Config Load()
		{
			var inst = _inst;

			if (inst == null)
			{
				if (File.Exists(CONFIG_FILENAME))
					using (var fs = new FileStream(CONFIG_FILENAME, FileMode.Open))
						inst = (Config)(new XmlSerializer(typeof(Config))).Deserialize(fs);
				else
					inst = new Config();

				_inst = inst;
			}

			return inst;
		}

		/// <summary>
		/// 保存配置文件
		/// </summary>
		public static void Save()
		{
			if (_inst == null)
				return;

			using (var fs = new FileStream(CONFIG_FILENAME, FileMode.Create))
				new XmlSerializer(typeof(Config)).Serialize(fs, _inst);
		}

		#endregion Misc
	}

	/// <summary>
	/// 由于XML无法序列化Drawing下的Color所以用了这个结构
	/// </summary>
	[Serializable]
	public struct Colour
	{
		public Colour(Color c)
		{
			this.R = c.R;
			this.G = c.G;
			this.B = c.B;
		}

		public Colour(byte r, byte g, byte b)
		{
			this.R = r;
			this.G = g;
			this.B = b;
		}

		public static implicit operator Color(Colour c)
		{
			return Color.FromArgb(c.R, c.G, c.B);
		}

		public static implicit operator Colour(Color c)
		{
			return new Colour(c);
		}

		public byte R;
		public byte G;
		public byte B;
	}
}
