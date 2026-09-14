using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F0 RID: 1776
[Token(Token = "0x20006F0")]
public class PortalPolevaulter : PolevaulterZombie
{
	// Token: 0x060022C7 RID: 8903 RVA: 0x000B6314 File Offset: 0x000B4514
	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x000B6324 File Offset: 0x000B4524
	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x5CC5B0", Offset = "0x5CABB0", VA = "0x1805CC5B0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x000B6364 File Offset: 0x000B4564
	[Token(Token = "0x60022C9")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x000B63A0 File Offset: 0x000B45A0
	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x5CC7D0", Offset = "0x5CADD0", VA = "0x1805CC7D0", Slot = "78")]
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

	// Token: 0x060022CB RID: 8907 RVA: 0x000B64A4 File Offset: 0x000B46A4
	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x5CC650", Offset = "0x5CAC50", VA = "0x1805CC650", Slot = "62")]
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

	// Token: 0x060022CC RID: 8908 RVA: 0x000B64F0 File Offset: 0x000B46F0
	[Token(Token = "0x60022CC")]
	[Address(RVA = "0x58B110", Offset = "0x589710", VA = "0x18058B110", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000B6500 File Offset: 0x000B4700
	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x5CAEC0", Offset = "0x5C94C0", VA = "0x1805CAEC0")]
	public PortalPolevaulter()
	{
		this.range = (ulong)1060320051L;
		this.range.y = 2f;
		base..ctor();
	}
}
