using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200034F RID: 847
[Token(Token = "0x200034F")]
public class CabbageCaltrop : Caltrop
{
	// Token: 0x06000F83 RID: 3971 RVA: 0x00059F30 File Offset: 0x00058130
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x41CAE0", Offset = "0x41B0E0", VA = "0x18041CAE0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)18), action, num != 0);
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00059F50 File Offset: 0x00058150
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x41CA00", Offset = "0x41B000", VA = "0x18041CA00")]
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

	// Token: 0x06000F85 RID: 3973 RVA: 0x00059F90 File Offset: 0x00058190
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x41C5C0", Offset = "0x41ABC0", VA = "0x18041C5C0")]
	private void AnimSupply()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
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
		Zombie zombie;
		bool flag = zombie != num;
		Transform shoot3 = this.shoot;
		if (!flag)
		{
			Board board2 = this.board;
			Board board3 = this.board;
		}
		Vector2 velocity = zombie.Velocity;
		GameAPP.PlaySound((int)zombie.ColliderPosition.x, 0.5f, 1f);
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x0005A054 File Offset: 0x00058254
	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x41C950", Offset = "0x41AF50", VA = "0x18041C950", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		base.OnCreate((int)reason, num);
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)18), action);
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x0005A078 File Offset: 0x00058278
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x41CBF0", Offset = "0x41B1F0", VA = "0x18041CBF0")]
	public CabbageCaltrop()
	{
		this.range = 1f;
		base..ctor();
	}

	// Token: 0x04000B4D RID: 2893
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B4D")]
	private CabbageCaltrop.BulletData bulletData;

	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	private struct BulletData
	{
		// Token: 0x04000B4E RID: 2894
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4E")]
		public BulletType BulletType;

		// Token: 0x04000B4F RID: 2895
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000B4F")]
		public int damage;
	}
}
