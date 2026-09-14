using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000736 RID: 1846
[Token(Token = "0x2000736")]
public class CustomIZManager
{
	// Token: 0x0600259B RID: 9627 RVA: 0x000C6384 File Offset: 0x000C4584
	[Token(Token = "0x600259B")]
	[Address(RVA = "0x5C0330", Offset = "0x5BE930", VA = "0x1805C0330")]
	public CustomIZManager(string path)
	{
		Dictionary<string, IZData> dictionary = new Dictionary();
		this.customIZDatas = dictionary;
		List<string> list = new List();
		this.levelNames = list;
		base..ctor();
		this.LoadLevelData(path);
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x000C63B8 File Offset: 0x000C45B8
	[Token(Token = "0x600259C")]
	[Address(RVA = "0x5C0010", Offset = "0x5BE610", VA = "0x1805C0010")]
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

	// Token: 0x040012EE RID: 4846
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012EE")]
	public readonly Dictionary<string, IZData> customIZDatas;

	// Token: 0x040012EF RID: 4847
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012EF")]
	public List<string> levelNames;
}
