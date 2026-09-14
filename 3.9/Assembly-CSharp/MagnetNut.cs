using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003F4 RID: 1012
[Token(Token = "0x20003F4")]
public class MagnetNut : WallNut
{
	// Token: 0x17000131 RID: 305
	// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00068398 File Offset: 0x00066598
	[Token(Token = "0x17000131")]
	public bool Full
	{
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x4A5550", Offset = "0x4A3B50", VA = "0x1804A5550")]
		get
		{
			List<Bullet> list = this.bullets;
			int num = this.maxBulletCount;
			bool flag;
			return flag;
		}
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x000683BC File Offset: 0x000665BC
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x4A49F0", Offset = "0x4A2FF0", VA = "0x1804A49F0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			List<Bullet> list = this.bullets;
			int num = this.maxBulletCount;
			this.SearchBullet();
			return;
		}
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x000683F4 File Offset: 0x000665F4
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x4A4A60", Offset = "0x4A3060", VA = "0x1804A4A60")]
	private void SearchBullet()
	{
		Transform shoot = this.shoot;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		LayerMask bulletLayer = this.bulletLayer;
		int num2 = bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (<Team>k__BackingField == Team.Player || <Team>k__BackingField == (Team)2)
				{
					List<Bullet> list = this.bullets;
					PlantType thePlantType = this.thePlantType;
					Transform axis = this.axis;
					Vector3 vector2;
					float z2 = vector2.z;
					Vector3 vector3;
					float z3 = vector3.z;
					Vector3 vector4;
					float z4 = vector4.z;
					int num3 = 0;
					bool flag2;
					if (flag2)
					{
						int num4 = this.shootingCurse;
						num4++;
						this.shootingCurse = num4;
						List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
						TravelMgr instance = TravelMgr.Instance;
						InGameText instance2 = InGameText.Instance;
					}
					if (this.gets.ContainsKey(num3))
					{
						Dictionary<BulletType, long> dictionary = this.gets;
					}
					Dictionary<BulletType, long> dictionary2 = this.gets;
				}
			}
			num++;
		}
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x000684F4 File Offset: 0x000666F4
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x4A48A0", Offset = "0x4A2EA0", VA = "0x1804A48A0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Bullet> list = this.bullets;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x00068530 File Offset: 0x00066730
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x4A50B0", Offset = "0x4A36B0", VA = "0x1804A50B0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			int size = this.bullets._size;
			int num = size - 1;
			if (size > 0)
			{
				int num2 = 0;
				Bullet bullet = this.bullets[num];
				int num3 = 0;
				if (bullet != num3)
				{
					int maxHitCount = bullet.maxHitCount;
					if (bullet.hitCount < maxHitCount && bullet._moveWay == BulletMoveWay.Free)
					{
						Transform axis = this.axis;
						float deltaTime = Time.deltaTime;
						Transform transform = bullet.transform;
						Transform transform2 = bullet.transform;
						float deltaTime2 = Time.deltaTime;
						if (num2 > (int)deltaTime2 || deltaTime2 > 1f)
						{
						}
						bullet.magnetNutAngle = deltaTime;
					}
				}
				this.bullets.RemoveAt(num);
			}
		}
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x000685F4 File Offset: 0x000667F4
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x4A5460", Offset = "0x4A3A60", VA = "0x1804A5460")]
	public MagnetNut()
	{
		List<Bullet> list = new List();
		this.bullets = list;
		this.R = 2f;
		this.V = 3f;
		this.maxBulletCount = (int)((ulong)100L);
		Dictionary<BulletType, long> dictionary = new Dictionary();
		this.gets = dictionary;
		base..ctor();
	}

	// Token: 0x04000C70 RID: 3184
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C70")]
	private readonly List<Bullet> bullets;

	// Token: 0x04000C71 RID: 3185
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C71")]
	private readonly float R;

	// Token: 0x04000C72 RID: 3186
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000C72")]
	private readonly float V;

	// Token: 0x04000C73 RID: 3187
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C73")]
	public int maxBulletCount;

	// Token: 0x04000C74 RID: 3188
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C74")]
	public Dictionary<BulletType, long> gets;
}
