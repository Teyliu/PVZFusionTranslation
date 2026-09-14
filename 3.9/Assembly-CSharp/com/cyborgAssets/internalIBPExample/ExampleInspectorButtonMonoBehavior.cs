using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.internalIBPExample
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	public class ExampleInspectorButtonMonoBehavior : MonoBehaviour
	{
		// Token: 0x060049F8 RID: 18936 RVA: 0x0016CFC4 File Offset: 0x0016B1C4
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x8CC400", Offset = "0x8CAA00", VA = "0x1808CC400")]
		[ProButton]
		private string GetGameObjectName()
		{
			return base.gameObject.name;
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x0016CFE4 File Offset: 0x0016B1E4
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x8CC4E0", Offset = "0x8CAAE0", VA = "0x1808CC4E0")]
		[ProButton]
		private void SpecialAttack(float attackPower)
		{
			string text;
			Debug.Log("perfromed special attack with attackPower = " + text);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x0016D004 File Offset: 0x0016B204
		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x8CC430", Offset = "0x8CAA30", VA = "0x1808CC430")]
		[ProPlayButton]
		private static void LoadScene(int sceneIndex)
		{
			string text;
			Debug.Log("Loading Scene:" + text);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x0016D024 File Offset: 0x0016B224
		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x8CC2C0", Offset = "0x8CA8C0", VA = "0x1808CC2C0")]
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

		// Token: 0x060049FC RID: 18940 RVA: 0x0016D094 File Offset: 0x0016B294
		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public ExampleInspectorButtonMonoBehavior()
		{
		}

		// Token: 0x0400346B RID: 13419
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400346B")]
		public GameObject[] targets;
	}
}
