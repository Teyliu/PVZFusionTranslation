using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007DD RID: 2013
[Token(Token = "0x20007DD")]
public class Weapon_squash : PlayerWeapon
{
	// Token: 0x060028EB RID: 10475 RVA: 0x000DC9F0 File Offset: 0x000DABF0
	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x67B830", Offset = "0x679E30", VA = "0x18067B830", Slot = "10")]
	protected override void Shoot()
	{
		GameObject gameObject = Resources.Load<GameObject>("Items/LittleSquash/LittleSquash");
		Transform axis = this.player.axis;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = Board.Instance.transform;
		GameObject gameObject2;
		LittleSquash component = gameObject2.GetComponent<LittleSquash>();
		int attackDamage = base.AttackDamage;
		component.theDamage = attackDamage;
		component.maxCrashCount = (int)((ulong)9L);
		int row = this.player.Row;
		component.theRow = row;
		component.thePlantType = (PlantType)((ulong)13L);
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x000DCAFC File Offset: 0x000DACFC
	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_squash()
	{
	}
}
