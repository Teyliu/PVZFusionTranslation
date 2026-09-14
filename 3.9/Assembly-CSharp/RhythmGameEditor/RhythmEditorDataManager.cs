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
	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x2000A4F")]
	public class RhythmEditorDataManager : MonoBehaviour
	{
		// Token: 0x0600362E RID: 13870 RVA: 0x001204E8 File Offset: 0x0011E6E8
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x79EE70", Offset = "0x79D470", VA = "0x18079EE70")]
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
					return;
				}
			}
			InGameText instance2 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x0012062C File Offset: 0x0011E82C
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x79EBD0", Offset = "0x79D1D0", VA = "0x18079EBD0")]
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
				}
				InGameText instance2 = InGameText.Instance;
			}
			InGameText instance3 = InGameText.Instance;
			string text2 = "文件不存在: " + path;
			throw new NullReferenceException();
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x001206CC File Offset: 0x0011E8CC
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x79EAF0", Offset = "0x79D0F0", VA = "0x18079EAF0")]
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

		// Token: 0x06003631 RID: 13873 RVA: 0x00120708 File Offset: 0x0011E908
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x79E5E0", Offset = "0x79CBE0", VA = "0x18079E5E0")]
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

		// Token: 0x06003632 RID: 13874 RVA: 0x00120894 File Offset: 0x0011EA94
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x79E540", Offset = "0x79CB40", VA = "0x18079E540")]
		public void CopyToClipboard(string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				GUIUtility.systemCopyBuffer = text;
				Debug.Log("\ud83d\udccb 已复制到剪贴板");
				return;
			}
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x001208BC File Offset: 0x0011EABC
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public RhythmEditorDataManager()
		{
		}
	}
}
