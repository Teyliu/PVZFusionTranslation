using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200046D RID: 1133
[Token(Token = "0x200046D")]
public class SuperTorch : Plant
{
	// Token: 0x060014E6 RID: 5350 RVA: 0x00073A58 File Offset: 0x00071C58
	[Token(Token = "0x60014E6")]
	[Address(RVA = "0x4CD600", Offset = "0x4CBC00", VA = "0x1804CD600", Slot = "16")]
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

	// Token: 0x060014E7 RID: 5351 RVA: 0x00073A9C File Offset: 0x00071C9C
	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x4CCD50", Offset = "0x4CB350", VA = "0x1804CCD50")]
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

	// Token: 0x060014E8 RID: 5352 RVA: 0x00073B38 File Offset: 0x00071D38
	[Token(Token = "0x60014E8")]
	[Address(RVA = "0x4480A0", Offset = "0x4466A0", VA = "0x1804480A0", Slot = "51")]
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

	// Token: 0x060014E9 RID: 5353 RVA: 0x00073B80 File Offset: 0x00071D80
	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x4CD080", Offset = "0x4CB680", VA = "0x1804CD080")]
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

	// Token: 0x060014EA RID: 5354 RVA: 0x00073C60 File Offset: 0x00071E60
	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SuperTorch()
	{
	}

	// Token: 0x04000D4C RID: 3404
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D4C")]
	private float fireCountDown;
}
