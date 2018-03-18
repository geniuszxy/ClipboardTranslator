using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardTranslator
{
	public interface IPlugin
	{
		/// <summary>
		/// 翻译给定的词汇
		/// </summary>
		int Translate(string word, out string explain);

		/// <summary>
		/// 插件名称
		/// </summary>
		string Name { get; }

		/// <summary>
		/// 插件描述
		/// </summary>
		string Description { get; }

		/// <summary>
		/// 插件是否包含配置窗口
		/// </summary>
		bool HasConfigWindow { get; }

		/// <summary>
		/// 打开插件配置窗口
		/// </summary>
		void OpenConfigWindow();
	}
}
