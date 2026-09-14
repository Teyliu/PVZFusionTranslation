using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000704 RID: 1796
[Token(Token = "0x2000704")]
public class SnowZombie : Zombie
{
	// Token: 0x0600235F RID: 9055 RVA: 0x000B8B14 File Offset: 0x000B6D14
	[Token(Token = "0x600235F")]
	[Address(RVA = "0x5BBCD0", Offset = "0x5BA2D0", VA = "0x1805BBCD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x000B8B40 File Offset: 0x000B6D40
	[Token(Token = "0x6002360")]
	[Address(RVA = "0x5D4A30", Offset = "0x5D3030", VA = "0x1805D4A30", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x000B8B68 File Offset: 0x000B6D68
	[Token(Token = "0x6002361")]
	[Address(RVA = "0x5D4AD0", Offset = "0x5D30D0", VA = "0x1805D4AD0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x000B8BA8 File Offset: 0x000B6DA8
	[Token(Token = "0x6002362")]
	[Address(RVA = "0x5D4B70", Offset = "0x5D3170", VA = "0x1805D4B70", Slot = "29")]
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

	// Token: 0x06002363 RID: 9059 RVA: 0x000B8C4C File Offset: 0x000B6E4C
	[Token(Token = "0x6002363")]
	[Address(RVA = "0x5D4E30", Offset = "0x5D3430", VA = "0x1805D4E30")]
	public SnowZombie()
	{
	}
}
