using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B7 RID: 951
[Token(Token = "0x20003B7")]
public class HypnoNut : WallNut
{
	// Token: 0x06001178 RID: 4472 RVA: 0x00062C98 File Offset: 0x00060E98
	[Token(Token = "0x6001178")]
	[Address(RVA = "0x48F9B0", Offset = "0x48DFB0", VA = "0x18048F9B0", Slot = "10")]
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

	// Token: 0x06001179 RID: 4473 RVA: 0x00062CDC File Offset: 0x00060EDC
	[Token(Token = "0x6001179")]
	[Address(RVA = "0x48F7F0", Offset = "0x48DDF0", VA = "0x18048F7F0", Slot = "39")]
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

	// Token: 0x0600117A RID: 4474 RVA: 0x00062D5C File Offset: 0x00060F5C
	[Token(Token = "0x600117A")]
	[Address(RVA = "0x48FA60", Offset = "0x48E060", VA = "0x18048FA60")]
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

	// Token: 0x0600117B RID: 4475 RVA: 0x00062E6C File Offset: 0x0006106C
	[Token(Token = "0x600117B")]
	[Address(RVA = "0x48FD70", Offset = "0x48E370", VA = "0x18048FD70")]
	public HypnoNut()
	{
		int[] array = new int[7];
		this.hyponos = array;
		base..ctor();
	}

	// Token: 0x04000C0D RID: 3085
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C0D")]
	private int[] hyponos;
}
