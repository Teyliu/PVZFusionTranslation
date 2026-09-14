using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBPExample
{
	// Token: 0x02000D2D RID: 3373
	[Token(Token = "0x2000D2D")]
	public class ExampleInspectorButtonMonoBehavior : MonoBehaviour
	{
		// Token: 0x06004649 RID: 17993 RVA: 0x001628AC File Offset: 0x00160AAC
		[Token(Token = "0x6004649")]
		[Address(RVA = "0x849FA0", Offset = "0x8485A0", VA = "0x180849FA0")]
		[ProButton]
		private string GetGameObjectName()
		{
			return base.gameObject.name;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x001628CC File Offset: 0x00160ACC
		[Token(Token = "0x600464A")]
		[Address(RVA = "0x84A080", Offset = "0x848680", VA = "0x18084A080")]
		[ProButton]
		private void SpecialAttack(float attackPower)
		{
			string text;
			Debug.Log("perfromed special attack with attackPower = " + text);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x001628EC File Offset: 0x00160AEC
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x849FD0", Offset = "0x8485D0", VA = "0x180849FD0")]
		[ProPlayButton]
		private static void LoadScene(int sceneIndex)
		{
			string text;
			Debug.Log("Loading Scene:" + text);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x0016290C File Offset: 0x00160B0C
		[Token(Token = "0x600464C")]
		[Address(RVA = "0x849E60", Offset = "0x848460", VA = "0x180849E60")]
		[ProPlayButton]
		private void DestroyAllEnemies()
		{
			GameObject[] array = this.targets;
			int num = 0;
			int length = array.Length;
			string text;
			Debug.Log("Destroying " + text + " enemies");
			GameObject[] array2 = this.targets;
			if (num < array2.Length)
			{
				GameObject[] array3 = this.targets;
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
				GameObject[] array4 = this.targets;
				num++;
				uint num2;
				num2 += (uint)8;
			}
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x0016297C File Offset: 0x00160B7C
		[Token(Token = "0x600464D")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public ExampleInspectorButtonMonoBehavior()
		{
		}

		// Token: 0x0400324C RID: 12876
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400324C")]
		public GameObject[] targets;
	}
}
