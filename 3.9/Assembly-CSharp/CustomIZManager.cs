using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200076F RID: 1903
[Token(Token = "0x200076F")]
public class CustomIZManager
{
	// Token: 0x060026C0 RID: 9920 RVA: 0x000CB268 File Offset: 0x000C9468
	[Token(Token = "0x60026C0")]
	[Address(RVA = "0x620EB0", Offset = "0x61F4B0", VA = "0x180620EB0")]
	public CustomIZManager(string path)
	{
		Dictionary<string, IZData> dictionary = new Dictionary();
		this.customIZDatas = dictionary;
		List<string> list = new List();
		this.levelNames = list;
		base..ctor();
		this.LoadLevelData(path);
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x000CB29C File Offset: 0x000C949C
	[Token(Token = "0x60026C1")]
	[Address(RVA = "0x620B90", Offset = "0x61F190", VA = "0x180620B90")]
	private void LoadLevelData(string path)
	{
		int num = 0;
		TextAsset[] array = Resources.LoadAll<TextAsset>(path);
		if (array != 0 && array.Length != num)
		{
			if (num >= array.Length)
			{
				return;
			}
			TextAsset textAsset = array[num];
			string name = textAsset.name;
			Match match = Regex.Match(name, "CustomIZ(.*)");
			if (match.Success)
			{
				string value = match.Groups[1].Value;
			}
			IZData izdata = JsonUtility.FromJson<IZData>(textAsset.text);
			this.customIZDatas.Add(name, izdata);
			List<string> list = this.levelNames;
			string name2 = textAsset.name;
			Debug.LogError(name2 + name2 + name2 + name2);
			num++;
		}
		Debug.LogError("在 Resources/" + path + "中没有文件");
	}

	// Token: 0x040013C4 RID: 5060
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013C4")]
	public readonly Dictionary<string, IZData> customIZDatas;

	// Token: 0x040013C5 RID: 5061
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013C5")]
	public List<string> levelNames;
}
