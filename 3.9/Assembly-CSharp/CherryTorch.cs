using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000377 RID: 887
[Token(Token = "0x2000377")]
public class CherryTorch : SquashTorch
{
	// Token: 0x0600103F RID: 4159 RVA: 0x0005D1C4 File Offset: 0x0005B3C4
	[Token(Token = "0x600103F")]
	[Address(RVA = "0x47B9E0", Offset = "0x479FE0", VA = "0x18047B9E0", Slot = "68")]
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

	// Token: 0x06001040 RID: 4160 RVA: 0x0005D238 File Offset: 0x0005B438
	[Token(Token = "0x6001040")]
	[Address(RVA = "0x47BB60", Offset = "0x47A160", VA = "0x18047BB60", Slot = "69")]
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

	// Token: 0x06001041 RID: 4161 RVA: 0x0005D308 File Offset: 0x0005B508
	[Token(Token = "0x6001041")]
	[Address(RVA = "0x47B940", Offset = "0x479F40", VA = "0x18047B940", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x0005D33C File Offset: 0x0005B53C
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x47BE00", Offset = "0x47A400", VA = "0x18047BE00")]
	public CherryTorch()
	{
		CherryLittleFly[] array = new CherryLittleFly[3];
		this.cherryLittleFlies = array;
		base..ctor();
	}

	// Token: 0x04000BB5 RID: 2997
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BB5")]
	public GameObject cherryFlyPrefab;

	// Token: 0x04000BB6 RID: 2998
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BB6")]
	private readonly CherryLittleFly[] cherryLittleFlies;
}
