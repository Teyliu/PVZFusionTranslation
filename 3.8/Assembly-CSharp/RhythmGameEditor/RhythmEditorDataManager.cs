using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;

namespace RhythmGameEditor
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	public class RhythmEditorDataManager : MonoBehaviour
	{
		// Token: 0x060034ED RID: 13549 RVA: 0x0011B32C File Offset: 0x0011952C
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x7383E0", Offset = "0x7369E0", VA = "0x1807383E0")]
		public void SaveAsJSON(List<NoteData> notes, string songName, float bpm, float audioOffset, MusicType musicType)
		{
			while (notes != 0)
			{
				string text = Path.Combine(Application.persistentDataPath, "RhythmCharts");
				if (!Directory.Exists(text))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				}
				string text2 = songName + ".json";
				string text3 = Path.Combine(text, text2);
				RhythmLevelData rhythmLevelData = new RhythmLevelData();
				rhythmLevelData.musicName = songName;
				rhythmLevelData.musicType = MusicType.MainMenu;
				rhythmLevelData.bpm = bpm;
				rhythmLevelData.audioOffset = (float)0;
				List<NoteData> list = new List();
				rhythmLevelData.notes = list;
				bool flag;
				ulong num;
				if (flag)
				{
					List<NoteData> notes2 = rhythmLevelData.notes;
					NoteData noteData = new NoteData();
					noteData.time = (float)num;
					noteData.track = noteData;
					noteData.type = noteData;
					noteData.endTime = noteData;
					int size = notes2._size;
					notes2._size = noteData;
					noteData.endTime = noteData;
				}
				if (num == (ulong)0L)
				{
					string text4 = JsonUtility.ToJson(rhythmLevelData, true);
					File.WriteAllText(text3, text4);
					InGameText instance = InGameText.Instance;
					int num2;
					string text5 = string.Format("音符数据已保存到:\n{0}\n共 {1} 个音符", text3, num2);
					int num3 = 0;
					instance.ShowText(text5, 7f, num3 != 0);
					return;
				}
			}
			InGameText instance2 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x0011B484 File Offset: 0x00119684
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x738180", Offset = "0x736780", VA = "0x180738180")]
		public RhythmLevelData LoadFromJSON(string path)
		{
			if (File.Exists(path))
			{
				RhythmLevelData rhythmLevelData = JsonUtility.FromJson<RhythmLevelData>(File.ReadAllText(path));
				InGameText instance = InGameText.Instance;
				if (rhythmLevelData != 0)
				{
					string musicName = rhythmLevelData.musicName;
					float bpm = rhythmLevelData.bpm;
					int size = rhythmLevelData.notes._size;
					string text = string.Format("成功加载: {0}\nBPM: {1}\n音符数量: {2}", musicName, instance, instance);
					int num = 0;
					instance.ShowText(text, 7f, num != 0);
				}
				int num2 = 0;
				instance.ShowText("无法解析JSON文件！", 5f, num2 != 0);
				InGameText instance2 = InGameText.Instance;
				int num3 = 0;
				string text2;
				instance2.ShowText(text2, 10f, num3 != 0);
			}
			InGameText instance3 = InGameText.Instance;
			string text3 = "文件不存在: " + path;
			int num4 = 0;
			instance3.ShowText(text3, 5f, num4 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x0011B574 File Offset: 0x00119774
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x7380A0", Offset = "0x7366A0", VA = "0x1807380A0")]
		public string[] GetSavedCharts()
		{
			string text = Path.Combine(Application.persistentDataPath, "RhythmCharts");
			if (Directory.Exists(text))
			{
				return Directory.GetFiles(text, "*.json");
			}
			DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
			return null;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x0011B5B0 File Offset: 0x001197B0
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x737B90", Offset = "0x736190", VA = "0x180737B90")]
		public string GenerateCSharpCode(List<NoteData> notes, string songName, float bpm)
		{
			while (notes != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilder stringBuilder2 = stringBuilder.AppendLine("// 音符数据 - 由踩点编辑器生成");
				string text = "// 歌曲: " + songName;
				StringBuilder stringBuilder3 = stringBuilder.AppendLine(text);
				string text2 = string.Format("// BPM: {0}", stringBuilder3);
				StringBuilder stringBuilder4 = stringBuilder.AppendLine(text2);
				int size = notes._size;
				string text3 = string.Format("// 音符数量: {0}", size);
				StringBuilder stringBuilder5 = stringBuilder.AppendLine(text3);
				DateTime now = DateTime.Now;
				string text4 = string.Format("// 生成时间: {0:yyyy-MM-dd HH:mm:ss}", now);
				StringBuilder stringBuilder6 = stringBuilder.AppendLine(text4);
				StringBuilder stringBuilder7 = stringBuilder.AppendLine();
				StringBuilder stringBuilder8 = stringBuilder.AppendLine("public List<NoteData> notes = new List<NoteData>");
				StringBuilder stringBuilder9 = stringBuilder.AppendLine("{");
				bool flag;
				if (flag)
				{
					StringBuilder stringBuilder10 = stringBuilder.AppendLine("    new NoteData");
					StringBuilder stringBuilder11 = stringBuilder.AppendLine("    {");
					string text6;
					string text5 = "        time = " + text6 + ",";
					StringBuilder stringBuilder12 = stringBuilder.AppendLine(text5);
					string text8;
					string text7 = "        track = " + text8 + ",";
					StringBuilder stringBuilder13 = stringBuilder.AppendLine(text7);
					StringBuilder stringBuilder14 = stringBuilder.AppendLine("        type = NoteType.Normal,");
					StringBuilder stringBuilder15 = stringBuilder.AppendLine("        spawned = false,");
					string text10;
					string text9 = "        endTime = " + text10 + "  // Hold音符结束时间";
					StringBuilder stringBuilder16 = stringBuilder.AppendLine(text9);
					StringBuilder stringBuilder17 = stringBuilder.AppendLine("    },");
				}
				ulong num;
				if (num == (ulong)0L)
				{
					StringBuilder stringBuilder18 = stringBuilder.AppendLine("};");
					string text11 = stringBuilder.ToString();
					break;
				}
			}
			return "// 没有音符数据";
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x0011B73C File Offset: 0x0011993C
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x737AF0", Offset = "0x7360F0", VA = "0x180737AF0")]
		public void CopyToClipboard(string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				GUIUtility.systemCopyBuffer = text;
				Debug.Log("\ud83d\udccb 已复制到剪贴板");
				return;
			}
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x0011B764 File Offset: 0x00119964
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public RhythmEditorDataManager()
		{
		}
	}
}
