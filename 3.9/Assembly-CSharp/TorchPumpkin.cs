using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047E RID: 1150
[Token(Token = "0x200047E")]
public class TorchPumpkin : Pumpkin
{
	// Token: 0x0600152E RID: 5422 RVA: 0x00074FEC File Offset: 0x000731EC
	[Token(Token = "0x600152E")]
	[Address(RVA = "0x4D22E0", Offset = "0x4D08E0", VA = "0x1804D22E0")]
	protected void OnTriggerEnter2D(Collider2D collision)
	{
		int num;
		Team <Team>k__BackingField;
		do
		{
			num = 0;
			bool flag;
			if (!collision.TryGetComponent<Bullet>(num) || flag)
			{
				return;
			}
			<Team>k__BackingField = this.<Team>k__BackingField;
			if (<Team>k__BackingField > (Team)5)
			{
			}
		}
		while (<Team>k__BackingField == (Team)(-3));
		Board board;
		if (this.thePlantRow == 0)
		{
			board = this.board;
			BoardAction boardAction = board.boardAction;
		}
		if (board == (ulong)15L)
		{
			BoardAction boardAction2 = this.board.boardAction;
			int num2 = 0;
			ulong num3;
			Bullet bullet = boardAction2.FirePeas(num, this, num2, (BulletType)num, num3 != 0UL);
			int num4 = this.fireTimes;
			num4++;
			this.fireTimes = num4;
			if (num4 > 50)
			{
				uint num5;
				bool flag2 = this.SummonPlant((int)num5);
			}
		}
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x0007508C File Offset: 0x0007328C
	[Token(Token = "0x600152F")]
	[Address(RVA = "0x4D24A0", Offset = "0x4D0AA0", VA = "0x1804D24A0", Slot = "69")]
	protected virtual bool SummonPlant(int dmg = 300)
	{
		int num;
		int num5;
		Plant plant;
		do
		{
			num = 0;
			CreatePlant instance = CreatePlant.Instance;
			int num2 = this.thePlantColumn;
			uint num3;
			num2 += (int)num3;
			Board board = this.board;
			int num4 = this.thePlantColumn;
			int columnNum = board.columnNum;
			num4 += (int)num3;
			num3 += (uint)1;
			num5 = 0;
		}
		while (plant == num5);
		int num6 = 0;
		bool flag = plant != num6;
		if (!flag)
		{
			return flag;
		}
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[11];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		this.fireTimes = num;
		throw new NullReferenceException();
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x00075138 File Offset: 0x00073338
	[Token(Token = "0x6001530")]
	[Address(RVA = "0x4D2210", Offset = "0x4D0810", VA = "0x1804D2210")]
	private bool CheckFire(Bullet bullet)
	{
		if (!(bullet.torchWood == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (bullet.<Team>k__BackingField == <Team>k__BackingField)
			{
				BulletMoveWay moveWay = bullet._moveWay;
				if (moveWay > BulletMoveWay.Free)
				{
				}
				if (moveWay != (BulletMoveWay)(-3))
				{
					int thePlantRow = this.thePlantRow;
					if (bullet.theBulletRow == thePlantRow)
					{
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00075190 File Offset: 0x00073390
	[Token(Token = "0x6001531")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public TorchPumpkin()
	{
	}

	// Token: 0x04000D5A RID: 3418
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D5A")]
	protected int fireTimes;
}
