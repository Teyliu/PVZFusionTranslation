using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBPExample
{
	// Token: 0x02000D2E RID: 3374
	[Token(Token = "0x2000D2E")]
	public class ExampleInspectorButtonScriptableObject : ScriptableObject
	{
		// Token: 0x0600464E RID: 17998 RVA: 0x00162990 File Offset: 0x00160B90
		[Token(Token = "0x600464E")]
		[Address(RVA = "0x84A100", Offset = "0x848700", VA = "0x18084A100")]
		[ProButton]
		private float Add2Numbers(int a, int b)
		{
			return 0f;
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x001629A4 File Offset: 0x00160BA4
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x84A110", Offset = "0x848710", VA = "0x18084A110")]
		[ProPlayButton]
		private void LoadScene(int sceneIndex)
		{
			string text;
			Debug.Log("Loading Scene:" + text);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x001629C4 File Offset: 0x00160BC4
		[Token(Token = "0x6004650")]
		[Address(RVA = "0x849E50", Offset = "0x848450", VA = "0x180849E50")]
		public ExampleInspectorButtonScriptableObject()
		{
		}
	}
}
