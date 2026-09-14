using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BC RID: 956
[Token(Token = "0x20003BC")]
public class HypnoTorch : TorchWood
{
	// Token: 0x0600118C RID: 4492 RVA: 0x00063524 File Offset: 0x00061724
	[Token(Token = "0x600118C")]
	[Address(RVA = "0x491260", Offset = "0x48F860", VA = "0x180491260", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		int num = 0;
		zombie.SetMindControl(num);
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
		CreatePlant instance = CreatePlant.Instance;
		return true;
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00063554 File Offset: 0x00061754
	[Token(Token = "0x600118D")]
	[Address(RVA = "0x4915D0", Offset = "0x48FBD0", VA = "0x1804915D0", Slot = "68")]
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

	// Token: 0x0600118E RID: 4494 RVA: 0x000635A4 File Offset: 0x000617A4
	[Token(Token = "0x600118E")]
	[Address(RVA = "0x491350", Offset = "0x48F950", VA = "0x180491350")]
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

	// Token: 0x0600118F RID: 4495 RVA: 0x00063644 File Offset: 0x00061844
	[Token(Token = "0x600118F")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public HypnoTorch()
	{
	}
}
