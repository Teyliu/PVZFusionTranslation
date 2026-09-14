using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045E RID: 1118
[Token(Token = "0x200045E")]
public class TorchPumpkin : Pumpkin
{
	// Token: 0x0600149E RID: 5278 RVA: 0x00072C90 File Offset: 0x00070E90
	[Token(Token = "0x600149E")]
	[Address(RVA = "0x47AA40", Offset = "0x479040", VA = "0x18047AA40")]
	protected void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag;
		if (collision.TryGetComponent<Bullet>(num) && !flag)
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (typeof(global::UnityEngine.Object).TypeHandle != (ulong)2L && typeof(global::UnityEngine.Object).TypeHandle != (ulong)6L)
			{
				if (<Team>k__BackingField <= (Team)5)
				{
				}
				int thePlantRow = this.thePlantRow;
			}
			Board board;
			if (<Team>k__BackingField == Team.Player)
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
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00072D44 File Offset: 0x00070F44
	[Token(Token = "0x600149F")]
	[Address(RVA = "0x47AC30", Offset = "0x479230", VA = "0x18047AC30", Slot = "70")]
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

	// Token: 0x060014A0 RID: 5280 RVA: 0x00072DF0 File Offset: 0x00070FF0
	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x47A950", Offset = "0x478F50", VA = "0x18047A950")]
	private bool CheckFire(Bullet bullet)
	{
		if (!(bullet.torchWood == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (bullet.<Team>k__BackingField == <Team>k__BackingField)
			{
				BulletMoveWay moveWay = bullet._moveWay;
				if (moveWay != BulletMoveWay.Free && moveWay != BulletMoveWay.Track)
				{
					if (<Team>k__BackingField <= (Team)5)
					{
					}
					int thePlantRow = this.thePlantRow;
					if (bullet.theBulletRow == thePlantRow)
					{
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00072E4C File Offset: 0x0007104C
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public TorchPumpkin()
	{
	}

	// Token: 0x04000CCE RID: 3278
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CCE")]
	protected int fireTimes;
}
