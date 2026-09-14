using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Core
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class InGameText : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public static InGameText Instance
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x941680", Offset = "0x93FC80", VA = "0x180941680")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x941360", Offset = "0x93F960", VA = "0x180941360")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x941610", Offset = "0x93FC10", VA = "0x180941610")]
		private void Update()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x9415D0", Offset = "0x93FBD0", VA = "0x1809415D0")]
		public void TimeOver()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x941430", Offset = "0x93FA30", VA = "0x180941430")]
		public void ShowText(string text, float time, bool cover = false, float y = -400f)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x941260", Offset = "0x93F860", VA = "0x180941260")]
		public void DelayShow(string text, float time, int delay)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x9413B0", Offset = "0x93F9B0", VA = "0x1809413B0")]
		public static string RemoveRichTextTags(string input)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x9411D0", Offset = "0x93F7D0", VA = "0x1809411D0")]
		public void DebugWarning(string text)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public InGameText()
		{
		}

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		private static InGameText _instance;

		// Token: 0x04000016 RID: 22
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000016")]
		private bool used;

		// Token: 0x04000017 RID: 23
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000017")]
		private float timer;

		// Token: 0x04000018 RID: 24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000018")]
		public GameObject textHead;

		// Token: 0x04000019 RID: 25
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000019")]
		public TextMeshProUGUI textMesh;
	}
}
