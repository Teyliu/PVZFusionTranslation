using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035F RID: 863
[Token(Token = "0x200035F")]
public class CabbageCaltrop : Caltrop
{
	// Token: 0x06000FCF RID: 4047 RVA: 0x0005AEA0 File Offset: 0x000590A0
	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0x473980", Offset = "0x471F80", VA = "0x180473980", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)18), action, num != 0);
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x0005AEC0 File Offset: 0x000590C0
	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0x4738A0", Offset = "0x471EA0", VA = "0x1804738A0")]
	private void OnBulletHitLand(object obj)
	{
		if (obj != 0)
		{
			int thePlantRow = this.thePlantRow;
			PlantType thePlantType = this.thePlantType;
			this.anim.SetTrigger("supply");
			this.bulletData = thePlantType;
		}
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x0005AF00 File Offset: 0x00059100
	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x473460", Offset = "0x471A60", VA = "0x180473460")]
	private void AnimSupply()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		Func<Zombie, bool> func = delegate(Zombie zombie)
		{
			if (Lawnf.InLandStatus(zombie.theStatus))
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow)
				{
					return !zombie.isMindControlled;
				}
			}
			throw new NullReferenceException();
		};
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		CabbageCaltrop.BulletData bulletData = this.bulletData;
		int damage = this.bulletData.damage;
		Bullet bullet;
		bullet.Damage = damage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int num = 0;
		Zombie zombie2;
		bool flag = zombie2 != num;
		Transform shoot3 = this.shoot;
		if (!flag)
		{
			Board board2 = this.board;
			Board board3 = this.board;
		}
		Vector2 velocity = zombie2.Velocity;
		GameAPP.PlaySound((int)zombie2.ColliderPosition.x, 0.5f, 1f);
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x0005AFD4 File Offset: 0x000591D4
	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0x4737F0", Offset = "0x471DF0", VA = "0x1804737F0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		base.OnCreate((int)reason, num);
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)18), action);
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x0005AFF8 File Offset: 0x000591F8
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x473A90", Offset = "0x472090", VA = "0x180473A90")]
	public CabbageCaltrop()
	{
		this.range = 1f;
		base..ctor();
	}

	// Token: 0x04000B9E RID: 2974
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B9E")]
	private CabbageCaltrop.BulletData bulletData;

	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	private struct BulletData
	{
		// Token: 0x04000B9F RID: 2975
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9F")]
		public BulletType BulletType;

		// Token: 0x04000BA0 RID: 2976
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000BA0")]
		public int damage;
	}
}
