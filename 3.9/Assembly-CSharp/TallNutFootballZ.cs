using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000726 RID: 1830
[Token(Token = "0x2000726")]
public class TallNutFootballZ : BucketNutZ
{
	// Token: 0x06002420 RID: 9248 RVA: 0x000BC73C File Offset: 0x000BA93C
	[Token(Token = "0x6002420")]
	[Address(RVA = "0x5F7180", Offset = "0x5F5780", VA = "0x1805F7180", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[22];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[23];
		component2.sprite = sprite2;
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
	[Token(Token = "0x6002421")]
	[Address(RVA = "0x58B110", Offset = "0x589710", VA = "0x18058B110", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x000BC7C8 File Offset: 0x000BA9C8
	[Token(Token = "0x6002422")]
	[Address(RVA = "0x5F7010", Offset = "0x5F5610", VA = "0x1805F7010", Slot = "62")]
	public override GameObject DropArmor()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Items/Helmet");
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject2;
		return gameObject2;
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000BC810 File Offset: 0x000BAA10
	[Token(Token = "0x6002423")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000BC820 File Offset: 0x000BAA20
	[Token(Token = "0x6002424")]
	[Address(RVA = "0x5883F0", Offset = "0x5869F0", VA = "0x1805883F0")]
	public TallNutFootballZ()
	{
	}
}
