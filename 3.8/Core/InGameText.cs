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
			[Address(RVA = "0x8B18A0", Offset = "0x8AFEA0", VA = "0x1808B18A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x8B1680", Offset = "0x8AFC80", VA = "0x1808B1680")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x8B1830", Offset = "0x8AFE30", VA = "0x1808B1830")]
		private void Update()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x8B17F0", Offset = "0x8AFDF0", VA = "0x1808B17F0")]
		public void TimeOver()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x8B1750", Offset = "0x8AFD50", VA = "0x1808B1750")]
		public void ShowText(string text, float time, bool cover = false)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x8B16D0", Offset = "0x8AFCD0", VA = "0x1808B16D0")]
		public static string RemoveRichTextTags(string input)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x8B15C0", Offset = "0x8AFBC0", VA = "0x1808B15C0")]
		public void DebugWarning(string text)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
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
