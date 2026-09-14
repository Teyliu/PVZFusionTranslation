using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A7 RID: 1447
[Token(Token = "0x20005A7")]
public class UltimateFireSeaShroom : Shooter, IChargeByFire
{
	// Token: 0x06001ADE RID: 6878 RVA: 0x00090270 File Offset: 0x0008E470
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x4FC560", Offset = "0x4FAB60", VA = "0x1804FC560", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)11001)))
		{
			this.attributeCount = (int)((ulong)1000L);
		}
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x000902A0 File Offset: 0x0008E4A0
	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x4FC590", Offset = "0x4FAB90", VA = "0x1804FC590", Slot = "73")]
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

	// Token: 0x06001AE0 RID: 6880 RVA: 0x000902E4 File Offset: 0x0008E4E4
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x4FC830", Offset = "0x4FAE30", VA = "0x1804FC830", Slot = "69")]
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

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00090398 File Offset: 0x0008E598
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x4FC720", Offset = "0x4FAD20", VA = "0x1804FC720", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x000903B8 File Offset: 0x0008E5B8
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x4FCC10", Offset = "0x4FB210", VA = "0x1804FCC10")]
	public UltimateFireSeaShroom()
	{
	}

	// Token: 0x04000E9F RID: 3743
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E9F")]
	private int thisCount;

	// Token: 0x04000EA0 RID: 3744
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000EA0")]
	private int current;

	// Token: 0x04000EA1 RID: 3745
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EA1")]
	private int rest = (int)((ulong)100L);
}
