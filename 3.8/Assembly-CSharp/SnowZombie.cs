using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CC RID: 1740
[Token(Token = "0x20006CC")]
public class SnowZombie : Zombie
{
	// Token: 0x06002244 RID: 8772 RVA: 0x000B3D48 File Offset: 0x000B1F48
	[Token(Token = "0x6002244")]
	[Address(RVA = "0x557830", Offset = "0x555E30", VA = "0x180557830", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000B3D74 File Offset: 0x000B1F74
	[Token(Token = "0x6002245")]
	[Address(RVA = "0x571350", Offset = "0x56F950", VA = "0x180571350", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000B3D9C File Offset: 0x000B1F9C
	[Token(Token = "0x6002246")]
	[Address(RVA = "0x5713F0", Offset = "0x56F9F0", VA = "0x1805713F0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000B3DDC File Offset: 0x000B1FDC
	[Token(Token = "0x6002247")]
	[Address(RVA = "0x571490", Offset = "0x56FA90", VA = "0x180571490", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Board board = this.board;
		GameObject gameObject = Resources.Load<GameObject>("Items/SproutPotPrize/JigPrize");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform3 = gameObject2.transform;
		float boardMaxX = this.board.boardMaxX;
		Transform transform4 = gameObject2.transform;
		Vector3 vector3;
		if (this.board.boardMinY > vector3.y)
		{
		}
		Transform transform5 = gameObject2.transform;
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000B3E80 File Offset: 0x000B2080
	[Token(Token = "0x6002248")]
	[Address(RVA = "0x571750", Offset = "0x56FD50", VA = "0x180571750")]
	public SnowZombie()
	{
	}
}
