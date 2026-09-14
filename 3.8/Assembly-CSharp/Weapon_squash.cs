using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A4 RID: 1956
[Token(Token = "0x20007A4")]
public class Weapon_squash : PlayerWeapon
{
	// Token: 0x060027BC RID: 10172 RVA: 0x000D7A34 File Offset: 0x000D5C34
	[Token(Token = "0x60027BC")]
	[Address(RVA = "0x617F90", Offset = "0x616590", VA = "0x180617F90", Slot = "10")]
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

	// Token: 0x060027BD RID: 10173 RVA: 0x000D7B40 File Offset: 0x000D5D40
	[Token(Token = "0x60027BD")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_squash()
	{
	}
}
