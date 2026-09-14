using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E4 RID: 1508
[Token(Token = "0x20005E4")]
public class UltimateKelp : SuperKelp
{
	// Token: 0x06001C08 RID: 7176 RVA: 0x00095C34 File Offset: 0x00093E34
	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x5668D0", Offset = "0x564ED0", VA = "0x1805668D0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (base.BoxType != BoxType.Water)
		{
			int num = 0;
			base.Die((Plant.DieReason)num);
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
		if (Lawnf.TravelUltimate((UltiBuff)((uint)28)))
		{
			Board board = this.board;
			float num2;
			base.AddSpeed(num2);
		}
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x00095C8C File Offset: 0x00093E8C
	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x566750", Offset = "0x564D50", VA = "0x180566750", Slot = "68")]
	protected override void GrabUpdate()
	{
		base.GrabUpdate();
		this.attributeCountdown = 10f;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x00095CAC File Offset: 0x00093EAC
	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0x566480", Offset = "0x564A80", VA = "0x180566480", Slot = "73")]
	protected override void AnimShoot()
	{
		base.UpdateText();
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		int rowNum = this.board.rowNum;
		CreateBullet instance2 = CreateBullet.Instance;
		int num = this.thePlantRow;
		num++;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		CreateBullet instance3 = CreateBullet.Instance;
		int attackDamage3 = this.attackDamage;
		Bullet bullet3;
		bullet3.Damage = attackDamage3;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00095D48 File Offset: 0x00093F48
	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x566790", Offset = "0x564D90", VA = "0x180566790", Slot = "71")]
	protected override IEnumerator Moving()
	{
		UltimateKelp.<Moving>d__3 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x00095D6C File Offset: 0x00093F6C
	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x566800", Offset = "0x564E00", VA = "0x180566800", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x00095D8C File Offset: 0x00093F8C
	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0x566AB0", Offset = "0x5650B0", VA = "0x180566AB0")]
	public UltimateKelp()
	{
	}
}
