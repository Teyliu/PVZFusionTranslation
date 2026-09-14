using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000414 RID: 1044
[Token(Token = "0x2000414")]
public class PeaPumpkin : Pumpkin
{
	// Token: 0x06001332 RID: 4914 RVA: 0x0006B3DC File Offset: 0x000695DC
	[Token(Token = "0x6001332")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x0006B3FC File Offset: 0x000695FC
	[Token(Token = "0x6001333")]
	[Address(RVA = "0x4B0690", Offset = "0x4AEC90", VA = "0x1804B0690", Slot = "39")]
	protected override void AttributeEvent()
	{
		while (base.Shootable())
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, int> peaPlant = PeaPumpkin.PeaPlant;
				bool flag2;
				while (!flag2)
				{
				}
				this.anim.SetTrigger("shoot");
			}
			ulong num;
			if (num == (ulong)0L)
			{
				break;
			}
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x0006B46C File Offset: 0x0006966C
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x4B0390", Offset = "0x4AE990", VA = "0x1804B0390")]
	private void AnimShoot()
	{
		int num;
		bool flag;
		do
		{
			num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			if (flag)
			{
				Dictionary<PlantType, int> peaPlant = PeaPumpkin.PeaPlant;
				bool flag2;
				while (!flag2)
				{
				}
				int num2 = 0;
				Bullet bullet;
				if (bullet != num2)
				{
					Transform transform = bullet.transform;
					Transform shoot = this.shoot;
					Vector3 vector;
					float z = vector.z;
				}
			}
		}
		while (num != 0);
		if (flag > false)
		{
		}
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x0006B4FC File Offset: 0x000696FC
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public PeaPumpkin()
	{
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x0006B510 File Offset: 0x00069710
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x4B08D0", Offset = "0x4AEED0", VA = "0x1804B08D0")]
	static PeaPumpkin()
	{
		Dictionary<PlantType, int> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add(num, 1);
		dictionary.Add((uint)1030, 2);
		dictionary.Add((uint)1090, 3);
		dictionary.Add((uint)1032, 4);
		dictionary.Add((uint)1168, 6);
		dictionary.Add((uint)1412, 1);
		dictionary.Add((uint)1319, 1);
		dictionary.Add((uint)1320, 2);
		dictionary.Add((uint)1321, 3);
		dictionary.Add((uint)1322, 4);
		dictionary.Add((uint)1385, 1);
		dictionary.Add((uint)1386, 2);
		dictionary.Add((uint)1387, 3);
		dictionary.Add((uint)1388, 4);
		dictionary.Add((uint)1001, 1);
		dictionary.Add((uint)1008, 2);
		dictionary.Add((uint)1108, 3);
		dictionary.Add((uint)1017, 4);
		dictionary.Add((uint)1005, 1);
		dictionary.Add((uint)901, 4);
		dictionary.Add((uint)301, 6);
		dictionary.Add((uint)1331, 6);
		dictionary.Add((uint)1034, 1);
		dictionary.Add((uint)1105, 2);
		dictionary.Add((uint)1107, 3);
		dictionary.Add((uint)1106, 4);
		dictionary.Add((uint)1165, 6);
		dictionary.Add((uint)1267, 1);
		dictionary.Add((uint)1268, 2);
		dictionary.Add((uint)1269, 3);
		dictionary.Add((uint)1270, 4);
		dictionary.Add((uint)1292, 6);
		dictionary.Add((uint)1194, 1);
		dictionary.Add((uint)907, 4);
		dictionary.Add((uint)971, 4);
		dictionary.Add((uint)1020, 1);
		dictionary.Add((uint)1208, 1);
		dictionary.Add((uint)1306, 4);
		dictionary.Add((uint)985, 6);
		dictionary.Add((uint)1443, 1);
		dictionary.Add((uint)5001, 1);
		PeaPumpkin.PeaPlant = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04000C9B RID: 3227
	[Token(Token = "0x4000C9B")]
	public static readonly Dictionary<PlantType, int> PeaPlant;
}
