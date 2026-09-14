using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006EE RID: 1774
[Token(Token = "0x20006EE")]
public class TallNutFootballZ : BucketNutZ
{
	// Token: 0x06002304 RID: 8964 RVA: 0x000B78F8 File Offset: 0x000B5AF8
	[Token(Token = "0x6002304")]
	[Address(RVA = "0x57CBA0", Offset = "0x57B1A0", VA = "0x18057CBA0", Slot = "61")]
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

	// Token: 0x06002305 RID: 8965 RVA: 0x000B7974 File Offset: 0x000B5B74
	[Token(Token = "0x6002305")]
	[Address(RVA = "0x534430", Offset = "0x532A30", VA = "0x180534430", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000B7984 File Offset: 0x000B5B84
	[Token(Token = "0x6002306")]
	[Address(RVA = "0x57CA30", Offset = "0x57B030", VA = "0x18057CA30", Slot = "60")]
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

	// Token: 0x06002307 RID: 8967 RVA: 0x000B79CC File Offset: 0x000B5BCC
	[Token(Token = "0x6002307")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x000B79DC File Offset: 0x000B5BDC
	[Token(Token = "0x6002308")]
	[Address(RVA = "0x5318A0", Offset = "0x52FEA0", VA = "0x1805318A0")]
	public TallNutFootballZ()
	{
	}
}
