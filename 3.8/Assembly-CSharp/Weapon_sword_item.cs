using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A7 RID: 1959
[Token(Token = "0x20007A7")]
public class Weapon_sword_item : MonoBehaviour
{
	// Token: 0x060027C8 RID: 10184 RVA: 0x000D7FF0 File Offset: 0x000D61F0
	[Token(Token = "0x60027C8")]
	[Address(RVA = "0x6194D0", Offset = "0x617AD0", VA = "0x1806194D0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int attackDamage = this.weapon_Sword.AttackDamage;
			float num = global::UnityEngine.Random.Range(1.3f, 1.8f);
			GameAPP.PlaySound(133, 0.5f, num);
		}
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x000D8038 File Offset: 0x000D6238
	[Token(Token = "0x60027C9")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Weapon_sword_item()
	{
	}

	// Token: 0x0400160B RID: 5643
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400160B")]
	public Weapon_sword weapon_Sword;
}
