using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000452 RID: 1106
[Token(Token = "0x2000452")]
public class ThornsAloes : Thrower
{
	// Token: 0x06001465 RID: 5221 RVA: 0x00071CD4 File Offset: 0x0006FED4
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x476830", Offset = "0x474E30", VA = "0x180476830", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Animator anim = this.anim;
		this.thePlantAttackCountDown = num;
		anim.SetTrigger("shoot");
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00071D1C File Offset: 0x0006FF1C
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x4768E0", Offset = "0x474EE0", VA = "0x1804768E0", Slot = "69")]
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
			Func<Plant, bool> func;
			IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(Lawnf.GetPlantsByRow(this.board, thePlantRow2), func);
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
		bullet.Vx = (float)num8;
		bullet.Vy = 8f;
		bullet.detaVy = 15f;
		int num9 = 0;
		bullet.Damage = num9;
		uint num10;
		uint num11;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num10, (int)num11), 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00071F18 File Offset: 0x00070118
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x476760", Offset = "0x474D60", VA = "0x180476760", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00071F38 File Offset: 0x00070138
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00071F48 File Offset: 0x00070148
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public ThornsAloes()
	{
	}

	// Token: 0x04000CC1 RID: 3265
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CC1")]
	public GameObject blackBall;
}
