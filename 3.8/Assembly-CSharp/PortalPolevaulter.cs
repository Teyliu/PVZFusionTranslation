using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B8 RID: 1720
[Token(Token = "0x20006B8")]
public class PortalPolevaulter : PolevaulterZombie
{
	// Token: 0x060021AD RID: 8621 RVA: 0x000B160C File Offset: 0x000AF80C
	[Token(Token = "0x60021AD")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x000B161C File Offset: 0x000AF81C
	[Token(Token = "0x60021AE")]
	[Address(RVA = "0x568CF0", Offset = "0x5672F0", VA = "0x180568CF0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x000B165C File Offset: 0x000AF85C
	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x000B1698 File Offset: 0x000AF898
	[Token(Token = "0x60021B0")]
	[Address(RVA = "0x568F10", Offset = "0x567510", VA = "0x180568F10", Slot = "76")]
	public override void PlayJumpSound2()
	{
		GameAPP.PlaySound(51, 0.5f, 1f);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
		List<int> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int random = ListExtensions.GetRandom<int>(list);
		int num4 = 0;
		base.KnockBack(0.5f, (Zombie.KnockBackReason)num4);
		if (global::UnityEngine.Random.Range(0, 3) != 0)
		{
			int theZombieRow2 = this.theZombieRow;
			int avaliableRow = base.GetAvaliableRow(theZombieRow2);
			Transform axis2 = this.axis;
			this.theZombieRow = avaliableRow;
			Mouse instance2 = Mouse.Instance;
		}
		Transform axis3 = this.axis;
		ParticleManager instance3 = ParticleManager.Instance;
		int num5 = 0;
		int theZombieRow3 = this.theZombieRow;
		ulong num6;
		Particle particle2 = instance3.SetParticle((ParticleType)((uint)11), num5, theZombieRow3, num6 != 0UL, (float)num2);
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x000B179C File Offset: 0x000AF99C
	[Token(Token = "0x60021B1")]
	[Address(RVA = "0x568D90", Offset = "0x567390", VA = "0x180568D90", Slot = "60")]
	public override GameObject DropArmor()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Items/PortalHeart");
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x000B17E8 File Offset: 0x000AF9E8
	[Token(Token = "0x60021B2")]
	[Address(RVA = "0x534430", Offset = "0x532A30", VA = "0x180534430", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x000B17F8 File Offset: 0x000AF9F8
	[Token(Token = "0x60021B3")]
	[Address(RVA = "0x568270", Offset = "0x566870", VA = "0x180568270")]
	public PortalPolevaulter()
	{
		this.range = (ulong)1060320051L;
		this.range.y = 2f;
		base..ctor();
	}
}
