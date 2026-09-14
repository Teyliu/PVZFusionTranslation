using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003FA RID: 1018
[Token(Token = "0x20003FA")]
public class PeaPumpkin : Pumpkin
{
	// Token: 0x060012BF RID: 4799 RVA: 0x00069628 File Offset: 0x00067828
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00069648 File Offset: 0x00067848
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x45A340", Offset = "0x458940", VA = "0x18045A340", Slot = "40")]
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

	// Token: 0x060012C1 RID: 4801 RVA: 0x000696B8 File Offset: 0x000678B8
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x45A040", Offset = "0x458640", VA = "0x18045A040")]
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

	// Token: 0x060012C2 RID: 4802 RVA: 0x00069748 File Offset: 0x00067948
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public PeaPumpkin()
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x0006975C File Offset: 0x0006795C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x45A580", Offset = "0x458B80", VA = "0x18045A580")]
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

	// Token: 0x04000C24 RID: 3108
	[Token(Token = "0x4000C24")]
	public static readonly Dictionary<PlantType, int> PeaPlant;
}
