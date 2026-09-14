using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000472 RID: 1138
[Token(Token = "0x2000472")]
public class ThornsAloes : Thrower
{
	// Token: 0x060014F5 RID: 5365 RVA: 0x00074024 File Offset: 0x00072224
	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x4CE0E0", Offset = "0x4CC6E0", VA = "0x1804CE0E0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot");
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x0007406C File Offset: 0x0007226C
	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x4CE190", Offset = "0x4CC790", VA = "0x1804CE190", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num2;
		Bullet bullet;
		do
		{
			uint num;
			if (global::UnityEngine.Random.Range(0, (int)num) != 0)
			{
			}
			bool flag = base.DetactiveEnermy();
			num2 = 0;
			bool flag2 = !flag;
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			CreateBullet instance = CreateBullet.Instance;
			if (!flag2)
			{
				Zombie zombie = base.ThrowerSearchZombie();
				int num3 = 0;
				Plant plant;
				if (!(plant != num3))
				{
					int num4 = 0;
					if (zombie != num4)
					{
						Collider2D col = this.targetZombie.col;
						int num5 = 0;
						if (col != num5)
						{
						}
					}
					Board board = this.board;
					GridSystem gridSystem = board.gridSystem;
					int rowNum = board.rowNum;
					int thePlantRow = this.thePlantRow;
					BoardGrid grid = gridSystem.GetGrid(rowNum, thePlantRow);
					Vector2 position = grid.Position;
					float flightTime = this.flightTime;
				}
				int attackDamage = this.attackDamage;
				bullet.Damage = attackDamage;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
			}
			base.UpdateText();
			int thePlantRow2 = this.thePlantRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, thePlantRow2);
			Func<Plant, bool> func = delegate(Plant a)
			{
				int thePlantColumn = this.thePlantColumn;
				return a.thePlantColumn > thePlantColumn;
			};
			IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(plantsByRow, func);
			Func<Plant, int> func2;
			if (ThornsAloes.<>c.<>9__2_1 == 0)
			{
				ThornsAloes.<>c.<>9__2_1 = func2;
			}
			IEnumerable enumerable2 = Enumerable.GroupBy<Plant, int>(enumerable, func2);
			Func<IGrouping<int, Plant>, int> func3;
			if (ThornsAloes.<>c.<>9__2_2 == 0)
			{
				ThornsAloes.<>c.<>9__2_2 = func3;
			}
			uint num6;
			IEnumerable<IGrouping<int, Plant>> enumerable3 = Enumerable.Take<IGrouping<int, Plant>>(Enumerable.OrderByDescending<IGrouping<int, Plant>, int>(enumerable2, func3), (int)num6);
			Func<IGrouping<int, Plant>, IEnumerable<Plant>> func4;
			if (ThornsAloes.<>c.<>9__2_3 == 0)
			{
				ThornsAloes.<>c.<>9__2_3 = func4;
			}
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.SelectMany<IGrouping<int, Plant>, Plant>(enumerable3, func4));
			bool flag3;
			if (flag3)
			{
				Transform shoot2 = this.shoot;
				CreateBullet instance2 = CreateBullet.Instance;
				Transform shoot3 = this.shoot;
				int num7 = 0;
				Bullet bullet2;
				bullet2.Damage = num7;
			}
		}
		while (num2 != 0);
		int num8 = 0;
		bullet.velocity = num8;
		bullet.velocity.y = 8f;
		bullet.acceleration.y = -15f;
		int num9 = 0;
		bullet.Damage = num9;
		uint num10;
		uint num11;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num10, (int)num11), 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00074284 File Offset: 0x00072484
	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x4CE010", Offset = "0x4CC610", VA = "0x1804CE010", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x000742A4 File Offset: 0x000724A4
	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x000742B4 File Offset: 0x000724B4
	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public ThornsAloes()
	{
	}

	// Token: 0x04000D4D RID: 3405
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D4D")]
	public GameObject blackBall;
}
