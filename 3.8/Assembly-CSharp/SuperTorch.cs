using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044D RID: 1101
[Token(Token = "0x200044D")]
public class SuperTorch : Plant
{
	// Token: 0x06001456 RID: 5206 RVA: 0x00071718 File Offset: 0x0006F918
	[Token(Token = "0x6001456")]
	[Address(RVA = "0x475D50", Offset = "0x474350", VA = "0x180475D50", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.fireCountDown;
		int num2 = 0;
		if (num <= (float)num2)
		{
			this.fireCountDown = 1.5f;
			this.ReadyToFire();
			return;
		}
		float deltaTime = Time.deltaTime;
		this.fireCountDown = num;
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x0007175C File Offset: 0x0006F95C
	[Token(Token = "0x6001457")]
	[Address(RVA = "0x4754A0", Offset = "0x473AA0", VA = "0x1804754A0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		for (;;)
		{
			int num = 0;
			flag = collision.TryGetComponent<Bullet>(num);
			if (!flag || collision == this)
			{
				return;
			}
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int thePlantRow = this.thePlantRow;
			if (collision <= (ulong)15L)
			{
				goto IL_0071;
			}
			if (collision <= (ulong)153L)
			{
				goto IL_0063;
			}
			if (collision == (ulong)175L)
			{
				goto Block_4;
			}
		}
		IL_0082:
		while (collision != (ulong)1L)
		{
		}
		throw new NullReferenceException();
		Block_4:
		if (this.board.boardAction == (ulong)204L)
		{
			BoardAction boardAction = this.board.boardAction;
		}
		return;
		IL_0063:
		if (flag <= true)
		{
			goto IL_0082;
		}
		while (collision != (ulong)153L)
		{
		}
		IL_0071:
		if (collision > (ulong)1L)
		{
			while (collision != (ulong)15L)
			{
			}
		}
		if (collision == 0)
		{
			goto IL_0082;
		}
		goto IL_0082;
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x000717F8 File Offset: 0x0006F9F8
	[Token(Token = "0x6001458")]
	[Address(RVA = "0x403E70", Offset = "0x402470", VA = "0x180403E70", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, 1800, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00071840 File Offset: 0x0006FA40
	[Token(Token = "0x6001459")]
	[Address(RVA = "0x4757D0", Offset = "0x473DD0", VA = "0x1804757D0")]
	private void ReadyToFire()
	{
		int num;
		PlantType thePlantType;
		do
		{
			num = 0;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = this.zombieLayer;
			int num3 = 0;
			List<Zombie> list = new List();
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
				}
				num++;
			}
			if (num3 == 0)
			{
				return;
			}
			bool flag2;
			if (flag2)
			{
				if (num < 3)
				{
					GameObject gameObject = GameAPP.particlePrefab[35];
					Quaternion identityQuaternion = Quaternion.identityQuaternion;
					Transform transform = this.board.transform;
					GameObject gameObject2;
					SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
					int thePlantRow2 = this.thePlantRow;
					string text = string.Format("particle{0}", component);
					component.sortingLayerName = text;
					num++;
				}
				num++;
				thePlantType = this.thePlantType;
			}
		}
		while (num != 0);
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x00071920 File Offset: 0x0006FB20
	[Token(Token = "0x600145A")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SuperTorch()
	{
	}

	// Token: 0x04000CC0 RID: 3264
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CC0")]
	private float fireCountDown;
}
