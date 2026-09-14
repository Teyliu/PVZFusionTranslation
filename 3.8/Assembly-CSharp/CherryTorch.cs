using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000367 RID: 871
[Token(Token = "0x2000367")]
public class CherryTorch : SquashTorch
{
	// Token: 0x06000FF3 RID: 4083 RVA: 0x0005C204 File Offset: 0x0005A404
	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x424D00", Offset = "0x423300", VA = "0x180424D00", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag)
		{
			bool flag2 = base.CheckFire(num);
			if (flag2)
			{
				if (!flag2)
				{
					BoardAction boardAction = this.board.boardAction;
					int num2 = this.fireTimes;
					num2++;
					this.fireTimes = num2;
					if (num2 > 30)
					{
						bool flag3 = this.SummonPlant(300);
					}
				}
				else
				{
					if (flag)
					{
						while (!flag)
						{
						}
						return;
					}
					while (!flag)
					{
					}
					throw new NullReferenceException();
				}
			}
		}
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x0005C278 File Offset: 0x0005A478
	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x424E80", Offset = "0x423480", VA = "0x180424E80", Slot = "70")]
	protected override bool SummonPlant(int dmg = 300)
	{
		CherryLittleFly[] array = this.cherryLittleFlies;
		int num = 0;
		int num2 = 0;
		if (num2 < array.Length)
		{
			CherryLittleFly[] array2 = this.cherryLittleFlies;
			int num3 = 0;
			CherryLittleFly cherryLittleFly;
			if (!(cherryLittleFly == num3))
			{
				CherryLittleFly[] array3 = this.cherryLittleFlies;
				num++;
				uint num4;
				num4 += (uint)8;
			}
			Transform shoot = this.shoot;
			GameObject gameObject = this.cherryFlyPrefab;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			CherryLittleFly component = gameObject2.GetComponent<CherryLittleFly>();
			CherryLittleFly[] array4 = this.cherryLittleFlies;
			if (component != 0)
			{
			}
			array4[0] = component;
			num += 4;
			component.parentPlant = this;
			component.small = true;
			component.dmg = dmg;
			float num5;
			component.positionOffset = num5;
			this.fireTimes = (int)((ulong)0L);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0005C348 File Offset: 0x0005A548
	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x424C60", Offset = "0x423260", VA = "0x180424C60", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0005C37C File Offset: 0x0005A57C
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x425120", Offset = "0x423720", VA = "0x180425120")]
	public CherryTorch()
	{
		CherryLittleFly[] array = new CherryLittleFly[3];
		this.cherryLittleFlies = array;
		base..ctor();
	}

	// Token: 0x04000B64 RID: 2916
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B64")]
	public GameObject cherryFlyPrefab;

	// Token: 0x04000B65 RID: 2917
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B65")]
	private readonly CherryLittleFly[] cherryLittleFlies;
}
