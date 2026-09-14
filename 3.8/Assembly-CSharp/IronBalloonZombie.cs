using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000684 RID: 1668
[Token(Token = "0x2000684")]
public class IronBalloonZombie : BalloonZombie
{
	// Token: 0x06002015 RID: 8213 RVA: 0x000AA15C File Offset: 0x000A835C
	[Token(Token = "0x6002015")]
	[Address(RVA = "0x5519A0", Offset = "0x54FFA0", VA = "0x1805519A0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000AA1A0 File Offset: 0x000A83A0
	[Token(Token = "0x6002016")]
	[Address(RVA = "0x5516D0", Offset = "0x54FCD0", VA = "0x1805516D0", Slot = "74")]
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

	// Token: 0x06002017 RID: 8215 RVA: 0x000AA220 File Offset: 0x000A8420
	[Token(Token = "0x6002017")]
	[Address(RVA = "0x551800", Offset = "0x54FE00", VA = "0x180551800", Slot = "61")]
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

	// Token: 0x06002018 RID: 8216 RVA: 0x000AA2A0 File Offset: 0x000A84A0
	[Token(Token = "0x6002018")]
	[Address(RVA = "0x534430", Offset = "0x532A30", VA = "0x180534430", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000AA2B0 File Offset: 0x000A84B0
	[Token(Token = "0x6002019")]
	[Address(RVA = "0x551560", Offset = "0x54FB60", VA = "0x180551560", Slot = "60")]
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

	// Token: 0x0600201A RID: 8218 RVA: 0x000AA2F8 File Offset: 0x000A84F8
	[Token(Token = "0x600201A")]
	[Address(RVA = "0x551550", Offset = "0x54FB50", VA = "0x180551550")]
	public IronBalloonZombie()
	{
	}

	// Token: 0x040010C2 RID: 4290
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010C2")]
	public GameObject bucketNut;

	// Token: 0x040010C3 RID: 4291
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40010C3")]
	public GameObject Petals1;

	// Token: 0x040010C4 RID: 4292
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40010C4")]
	public GameObject Petals2;
}
