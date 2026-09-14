using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DF RID: 1247
[Token(Token = "0x20004DF")]
public class DoomCorn : Cornpult
{
	// Token: 0x06001775 RID: 6005 RVA: 0x00080718 File Offset: 0x0007E918
	[Token(Token = "0x6001775")]
	[Address(RVA = "0x4A0D80", Offset = "0x49F380", VA = "0x1804A0D80", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)10L);
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x00080738 File Offset: 0x0007E938
	[Token(Token = "0x6001776")]
	[Address(RVA = "0x4A13E0", Offset = "0x49F9E0", VA = "0x1804A13E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x00080758 File Offset: 0x0007E958
	[Token(Token = "0x6001777")]
	[Address(RVA = "0x4A10F0", Offset = "0x49F6F0", VA = "0x1804A10F0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)2), action);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00080770 File Offset: 0x0007E970
	[Token(Token = "0x6001778")]
	[Address(RVA = "0x4A1280", Offset = "0x49F880", VA = "0x1804A1280")]
	private void OnZombieDeath(object obj)
	{
		bool flag;
		if (obj != 0 && flag)
		{
			int thePlantRow = this.thePlantRow;
			base.UpdateText();
		}
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00080794 File Offset: 0x0007E994
	[Token(Token = "0x6001779")]
	[Address(RVA = "0x4A11A0", Offset = "0x49F7A0", VA = "0x1804A11A0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_doom;
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x000807A8 File Offset: 0x0007E9A8
	[Token(Token = "0x600177A")]
	[Address(RVA = "0x4A1190", Offset = "0x49F790", VA = "0x1804A1190", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_doom;
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x000807BC File Offset: 0x0007E9BC
	[Token(Token = "0x600177B")]
	[Address(RVA = "0x4A1330", Offset = "0x49F930", VA = "0x1804A1330", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Bullet bullet = base.Shoot2();
		int num = this.thePlantColumn;
		num++;
		base.UpdateText();
		return bullet;
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x000807E4 File Offset: 0x0007E9E4
	[Token(Token = "0x600177C")]
	[Address(RVA = "0x4A0DA0", Offset = "0x49F3A0", VA = "0x1804A0DA0")]
	private void CopyShoot(Bullet originalBullet, int column, int row, float offset)
	{
		List<Plant> list = Lawnf.Get1x1Plants(column, row);
		Func<Plant, bool> <>9__7_ = DoomCorn.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			Func<Plant, bool> func;
			DoomCorn.<>c.<>9__7_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__7_));
		if (plant == 0)
		{
		}
		int num = 0;
		bool flag;
		if (plant != num && flag)
		{
			Transform transform = originalBullet.transform;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			float detaVx = originalBullet.detaVx;
			float detaVy = originalBullet.detaVy;
			float vx = originalBullet.Vx;
			float vy = originalBullet.Vy;
		}
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00080874 File Offset: 0x0007EA74
	[Token(Token = "0x600177D")]
	[Address(RVA = "0x4A11B0", Offset = "0x49F7B0", VA = "0x1804A11B0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x00080894 File Offset: 0x0007EA94
	[Token(Token = "0x600177E")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public DoomCorn()
	{
	}
}
