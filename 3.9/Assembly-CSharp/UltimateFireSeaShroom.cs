using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D8 RID: 1496
[Token(Token = "0x20005D8")]
public class UltimateFireSeaShroom : Shooter, IChargeByFire
{
	// Token: 0x06001BC4 RID: 7108 RVA: 0x0009463C File Offset: 0x0009283C
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x559AF0", Offset = "0x5580F0", VA = "0x180559AF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)11001)))
		{
			this.attributeCount = (int)((ulong)1000L);
		}
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x0009466C File Offset: 0x0009286C
	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x559B20", Offset = "0x558120", VA = "0x180559B20", Slot = "72")]
	public void ChargeByFire(int count)
	{
		this.current = count;
		if (this.rest > 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform = base.transform;
		}
		this.current = (int)((ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x000946B0 File Offset: 0x000928B0
	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x559DC0", Offset = "0x5583C0", VA = "0x180559DC0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num = this.current;
		num++;
		this.current = num;
		if (this.rest > 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform = base.transform;
		}
		this.current = (int)((ulong)0L);
		base.UpdateText();
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)42)))
		{
		}
		int num2 = 0;
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)43));
		if (!flag)
		{
		}
		Bullet bullet;
		bullet.Damage = num2;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00094764 File Offset: 0x00092964
	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x559CB0", Offset = "0x5582B0", VA = "0x180559CB0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x00094784 File Offset: 0x00092984
	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x55A1A0", Offset = "0x5587A0", VA = "0x18055A1A0")]
	public UltimateFireSeaShroom()
	{
	}

	// Token: 0x04000F5E RID: 3934
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F5E")]
	private int thisCount;

	// Token: 0x04000F5F RID: 3935
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000F5F")]
	private int current;

	// Token: 0x04000F60 RID: 3936
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F60")]
	private int rest = (int)((ulong)100L);
}
