using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBPExample
{
	// Token: 0x02000DFA RID: 3578
	[Token(Token = "0x2000DFA")]
	public class ExampleInspectorButtonScriptableObject : ScriptableObject
	{
		// Token: 0x060049FD RID: 18941 RVA: 0x0016D0A8 File Offset: 0x0016B2A8
		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x8CC560", Offset = "0x8CAB60", VA = "0x1808CC560")]
		[ProButton]
		private float Add2Numbers(int a, int b)
		{
			return 0f;
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x0016D0BC File Offset: 0x0016B2BC
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x8CC570", Offset = "0x8CAB70", VA = "0x1808CC570")]
		[ProPlayButton]
		private void LoadScene(int sceneIndex)
		{
			string text;
			Debug.Log("Loading Scene:" + text);
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x0016D0DC File Offset: 0x0016B2DC
		[Token(Token = "0x60049FF")]
		[Address(RVA = "0x8CA980", Offset = "0x8C8F80", VA = "0x1808CA980")]
		public ExampleInspectorButtonScriptableObject()
		{
		}
	}
}
