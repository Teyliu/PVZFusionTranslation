using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BA RID: 1722
[Token(Token = "0x20006BA")]
public class IronBalloonZombie : BalloonZombie
{
	// Token: 0x06002117 RID: 8471 RVA: 0x000AEA60 File Offset: 0x000ACC60
	[Token(Token = "0x6002117")]
	[Address(RVA = "0x5B5530", Offset = "0x5B3B30", VA = "0x1805B5530", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000AEAA4 File Offset: 0x000ACCA4
	[Token(Token = "0x6002118")]
	[Address(RVA = "0x5B5260", Offset = "0x5B3860", VA = "0x1805B5260", Slot = "76")]
	public override void Fall()
	{
		this.fall = true;
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		GameAPP.PlaySound(77, 0.5f, 1f);
		if (base.BoxType != BoxType.Water)
		{
			GameObject gameObject = this.bucketNut;
			this.theFirstArmor = gameObject;
			this.theFirstArmorHealth = (int)((ulong)2200L);
			this.theFirstArmorMaxHealth = (int)((ulong)2200L);
			this.theFirstArmorType = (Zombie.FirstArmorType)((ulong)8L);
			this.anim.SetTrigger("fall");
		}
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000AEB24 File Offset: 0x000ACD24
	[Token(Token = "0x6002119")]
	[Address(RVA = "0x5B5390", Offset = "0x5B3990", VA = "0x1805B5390", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[14];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[15];
		component2.sprite = sprite2;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000AEBA4 File Offset: 0x000ACDA4
	[Token(Token = "0x600211A")]
	[Address(RVA = "0x58B110", Offset = "0x589710", VA = "0x18058B110", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000AEBB4 File Offset: 0x000ACDB4
	[Token(Token = "0x600211B")]
	[Address(RVA = "0x5B50F0", Offset = "0x5B36F0", VA = "0x1805B50F0", Slot = "62")]
	public override GameObject DropArmor()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Items/Bucket");
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000AEBFC File Offset: 0x000ACDFC
	[Token(Token = "0x600211C")]
	[Address(RVA = "0x5B50E0", Offset = "0x5B36E0", VA = "0x1805B50E0")]
	public IronBalloonZombie()
	{
	}

	// Token: 0x0400118F RID: 4495
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400118F")]
	public GameObject bucketNut;

	// Token: 0x04001190 RID: 4496
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001190")]
	public GameObject Petals1;

	// Token: 0x04001191 RID: 4497
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001191")]
	public GameObject Petals2;
}
