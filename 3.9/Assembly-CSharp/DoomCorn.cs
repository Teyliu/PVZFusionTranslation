using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000507 RID: 1287
[Token(Token = "0x2000507")]
public class DoomCorn : Cornpult
{
	// Token: 0x0600182C RID: 6188 RVA: 0x00083954 File Offset: 0x00081B54
	[Token(Token = "0x600182C")]
	[Address(RVA = "0x5208B0", Offset = "0x51EEB0", VA = "0x1805208B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)10L);
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00083974 File Offset: 0x00081B74
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x520F10", Offset = "0x51F510", VA = "0x180520F10", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x00083994 File Offset: 0x00081B94
	[Token(Token = "0x600182E")]
	[Address(RVA = "0x520C20", Offset = "0x51F220", VA = "0x180520C20", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)2), action);
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x000839AC File Offset: 0x00081BAC
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x520DB0", Offset = "0x51F3B0", VA = "0x180520DB0")]
	private void OnZombieDeath(object obj)
	{
		bool flag;
		if (obj != 0 && flag)
		{
			int thePlantRow = this.thePlantRow;
			base.UpdateText();
		}
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x000839D0 File Offset: 0x00081BD0
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x520CD0", Offset = "0x51F2D0", VA = "0x180520CD0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_doom;
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x000839E4 File Offset: 0x00081BE4
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x520CC0", Offset = "0x51F2C0", VA = "0x180520CC0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_doom;
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x000839F8 File Offset: 0x00081BF8
	[Token(Token = "0x6001832")]
	[Address(RVA = "0x520E60", Offset = "0x51F460", VA = "0x180520E60", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Bullet bullet = base.Shoot2();
		int num = this.thePlantColumn;
		num++;
		base.UpdateText();
		return bullet;
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x00083A20 File Offset: 0x00081C20
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x5208D0", Offset = "0x51EED0", VA = "0x1805208D0")]
	private void CopyShoot(Bullet originalBullet, int column, int row, float offset)
	{
		List<Plant> list = Lawnf.Get1x1Plants(column, row);
		Func<Plant, bool> <>9__7_ = DoomCorn.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			DoomCorn.<>c.<>9__7_0 = delegate(Plant a)
			{
				int num2 = 0;
				if (a != 0)
				{
				}
				return num2 != 0;
			};
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
			Vector2 velocity = originalBullet.velocity;
			float y = originalBullet.velocity.y;
			float y2 = originalBullet.acceleration.y;
			Vector2 acceleration = originalBullet.acceleration;
		}
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x00083AC8 File Offset: 0x00081CC8
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x520CE0", Offset = "0x51F2E0", VA = "0x180520CE0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x00083AE8 File Offset: 0x00081CE8
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public DoomCorn()
	{
	}
}
