using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E0 RID: 2016
[Token(Token = "0x20007E0")]
public class Weapon_sword_item : MonoBehaviour
{
	// Token: 0x060028F7 RID: 10487 RVA: 0x000DCFAC File Offset: 0x000DB1AC
	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x67CD70", Offset = "0x67B370", VA = "0x18067CD70")]
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

	// Token: 0x060028F8 RID: 10488 RVA: 0x000DCFF4 File Offset: 0x000DB1F4
	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Weapon_sword_item()
	{
	}

	// Token: 0x040016E7 RID: 5863
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016E7")]
	public Weapon_sword weapon_Sword;
}
