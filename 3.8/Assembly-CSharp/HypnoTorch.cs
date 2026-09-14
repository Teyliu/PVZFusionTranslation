using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A8 RID: 936
[Token(Token = "0x20003A8")]
public class HypnoTorch : TorchWood
{
	// Token: 0x06001130 RID: 4400 RVA: 0x00061EC8 File Offset: 0x000600C8
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x43DA00", Offset = "0x43C000", VA = "0x18043DA00", Slot = "64")]
	public override bool OnEat(Zombie zombie)
	{
		int num = 0;
		zombie.SetMindControl(num);
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
		CreatePlant instance = CreatePlant.Instance;
		return true;
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00061EF8 File Offset: 0x000600F8
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x43DD70", Offset = "0x43C370", VA = "0x18043DD70", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag)
		{
			bool flag2 = base.CheckFire(num);
			if (flag2)
			{
				if (flag2)
				{
					if (flag)
					{
					}
					while (!flag)
					{
					}
					throw new NullReferenceException();
				}
				BoardAction boardAction = this.board.boardAction;
				this.OnFirePea(1);
			}
		}
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00061F48 File Offset: 0x00060148
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x43DAF0", Offset = "0x43C0F0", VA = "0x18043DAF0")]
	private void OnFirePea(int count)
	{
		int num = this.attributeCount;
		int num2 = 0;
		num += count;
		this.attributeCount = num;
		if (num > 60)
		{
			Board board = this.board;
			this.attributeCount = num2;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			if (board.GetBoxType(thePlantColumn, thePlantRow) != BoxType.Water)
			{
				Transform axis = this.axis;
				CreateZombie instance = CreateZombie.Instance;
			}
			Transform axis2 = this.axis;
			CreateZombie instance2 = CreateZombie.Instance;
			int num3 = 0;
			Zombie zombie;
			if (zombie != num3)
			{
				Transform axis3 = this.axis;
				ParticleManager instance3 = ParticleManager.Instance;
				Vector3 vector;
				float z = vector.z;
			}
		}
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x00061FE8 File Offset: 0x000601E8
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public HypnoTorch()
	{
	}
}
