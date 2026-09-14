using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000634 RID: 1588
[Token(Token = "0x2000634")]
public class BucketNutZ : WallNutZombie
{
	// Token: 0x06001E1A RID: 7706 RVA: 0x000A0E4C File Offset: 0x0009F04C
	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0x5342A0", Offset = "0x5328A0", VA = "0x1805342A0", Slot = "61")]
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

	// Token: 0x06001E1B RID: 7707 RVA: 0x000A0EC8 File Offset: 0x0009F0C8
	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x534430", Offset = "0x532A30", VA = "0x180534430", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x000A0ED8 File Offset: 0x0009F0D8
	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x534130", Offset = "0x532730", VA = "0x180534130", Slot = "60")]
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

	// Token: 0x06001E1D RID: 7709 RVA: 0x000A0F20 File Offset: 0x0009F120
	[Token(Token = "0x6001E1D")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public BucketNutZ()
	{
	}
}
