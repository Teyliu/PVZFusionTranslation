using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A3 RID: 931
[Token(Token = "0x20003A3")]
public class HypnoNut : WallNut
{
	// Token: 0x0600111C RID: 4380 RVA: 0x00061640 File Offset: 0x0005F840
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x43C160", Offset = "0x43A760", VA = "0x18043C160", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 45f;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)15), (MissionResult)((uint)2)))
		{
			base.AttributeCountdown = 40f;
			return;
		}
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00061684 File Offset: 0x0005F884
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x43BFA0", Offset = "0x43A5A0", VA = "0x18043BFA0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		Board board = this.board;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, thePlantRow) != BoxType.Water)
		{
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
		}
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		base.AttributeCountdown = 45f;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)15), (MissionResult)((uint)2)))
		{
			base.AttributeCountdown = 40f;
		}
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00061704 File Offset: 0x0005F904
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x43C210", Offset = "0x43A810", VA = "0x18043C210")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			base.FlashOnce();
			int num = 0;
			ulong num2;
			ulong num3;
			base.Recover(100f, (DamageType)num, num2 != 0UL, num3 != 0UL);
			int[] array = this.hyponos;
			int[] array2 = this.hyponos;
			if ("{il2cpp array field local11->}" > (ulong)3L)
			{
			}
			int[] array3 = this.hyponos;
			int num4 = 0;
			int num5 = 0;
			int length = array3.Length;
			int[] array4 = this.hyponos;
			uint num6;
			if (num5 < length)
			{
				num4++;
				num6 += (uint)4;
			}
			ulong num7;
			if (num7 != (ulong)0L)
			{
				int num8 = 0;
				int num9 = 0;
				if (num9 < array4.Length)
				{
					num8++;
					int[] array5 = this.hyponos;
					num6 += (uint)4;
				}
				Board board = this.board;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				if (board.GetBoxType(thePlantColumn, thePlantRow) != BoxType.Water)
				{
					Transform axis = this.axis;
					CreateZombie instance = CreateZombie.Instance;
				}
				Transform axis2 = this.axis;
				CreateZombie instance2 = CreateZombie.Instance;
				int num10 = 0;
				ulong num11;
				ulong num12;
				base.Recover(100f, (DamageType)num10, num11 != 0UL, num12 != 0UL);
			}
		}
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00061814 File Offset: 0x0005FA14
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x43C520", Offset = "0x43AB20", VA = "0x18043C520")]
	public HypnoNut()
	{
		int[] array = new int[7];
		this.hyponos = array;
		base..ctor();
	}

	// Token: 0x04000BA7 RID: 2983
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA7")]
	private int[] hyponos;
}
