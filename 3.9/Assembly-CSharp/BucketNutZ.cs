using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200066A RID: 1642
[Token(Token = "0x200066A")]
public class BucketNutZ : WallNutZombie
{
	// Token: 0x06001F1C RID: 7964 RVA: 0x000A559C File Offset: 0x000A379C
	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x58AF80", Offset = "0x589580", VA = "0x18058AF80", Slot = "63")]
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

	// Token: 0x06001F1D RID: 7965 RVA: 0x000A5618 File Offset: 0x000A3818
	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x58B110", Offset = "0x589710", VA = "0x18058B110", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x000A5628 File Offset: 0x000A3828
	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x58AE10", Offset = "0x589410", VA = "0x18058AE10", Slot = "62")]
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

	// Token: 0x06001F1F RID: 7967 RVA: 0x000A5670 File Offset: 0x000A3870
	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public BucketNutZ()
	{
	}
}
