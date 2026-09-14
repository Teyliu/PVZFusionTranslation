using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020004B8 RID: 1208
[Token(Token = "0x20004B8")]
public class Umbrellaleaf : Plant
{
	// Token: 0x06001693 RID: 5779 RVA: 0x0007C680 File Offset: 0x0007A880
	[Token(Token = "0x6001693")]
	[Address(RVA = "0x51A1F0", Offset = "0x5187F0", VA = "0x18051A1F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		SortingGroup component = transform.GetChild(num).GetComponent<SortingGroup>();
		this._sortingGroup = component;
		throw new NullReferenceException();
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06001694 RID: 5780 RVA: 0x0007C6B8 File Offset: 0x0007A8B8
	[Token(Token = "0x17000159")]
	public Plant UmbrellaPot
	{
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x51A7E0", Offset = "0x518DE0", VA = "0x18051A7E0")]
		get
		{
			ulong num;
			do
			{
				GridSystem gridSystem = this.board.gridSystem;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0007C710 File Offset: 0x0007A910
	[Token(Token = "0x6001695")]
	[Address(RVA = "0x51A410", Offset = "0x518A10", VA = "0x18051A410", Slot = "68")]
	public virtual void Block(Bullet bullet)
	{
		Collider2D col = bullet.col;
		int num = 0;
		col.enabled = num != 0;
		Umbrellaleaf.<DelayBlock>d__7 <DelayBlock>d__;
		<DelayBlock>d__.System.IDisposable.Dispose();
		<DelayBlock>d__.<>1__state = (int)((ulong)0L);
		<DelayBlock>d__.bullet = bullet;
		Coroutine coroutine = base.StartCoroutine(<DelayBlock>d__);
		if (!this.blocking)
		{
			this.anim.SetTrigger("block");
			this.blocking = true;
		}
		bullet.sortingGroup.sortingLayerName = "bullet11";
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform transform = bullet.transform;
			Transform transform2 = bullet.transform;
			BulletType theBulletType = bullet.theBulletType;
			Vector2 acceleration = bullet.acceleration;
			float y = bullet.acceleration.y;
			float y2 = bullet.velocity.y;
			Vector2 velocity = bullet.velocity;
			PlantType thePlantType = this.thePlantType;
			int num2 = bullet._damage;
			num2 += 200;
			bullet.Die();
		}
		BulletType theBulletType2 = bullet.theBulletType;
		if (theBulletType2 == BulletType.Bullet_superCherry || theBulletType2 == BulletType.Bullet_jackbox_black)
		{
			base.FlashOnce();
		}
		float num3 = bullet.velocity.y * -1f;
		bullet.velocity.y = num3;
		Vector2 velocity2 = bullet.velocity;
		bullet.velocity = velocity2;
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x0007C844 File Offset: 0x0007AA44
	[Token(Token = "0x6001696")]
	[Address(RVA = "0x51A270", Offset = "0x518870", VA = "0x18051A270")]
	public void BlockBungi(BungiZombie bungi)
	{
		if (!this.blocking)
		{
			GameAPP.PlaySound(106, 0.5f, 1f);
			this.anim.SetTrigger("block");
			this.blocking = true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0007C888 File Offset: 0x0007AA88
	[Token(Token = "0x6001697")]
	[Address(RVA = "0x51A770", Offset = "0x518D70", VA = "0x18051A770")]
	protected IEnumerator DelayBlock(Bullet bullet)
	{
		Umbrellaleaf.<DelayBlock>d__7 <DelayBlock>d__;
		<DelayBlock>d__.System.IDisposable.Dispose();
		<DelayBlock>d__.<>1__state = (int)((ulong)0L);
		<DelayBlock>d__.bullet = bullet;
		return null;
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0007C8AC File Offset: 0x0007AAAC
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x51A3A0", Offset = "0x5189A0", VA = "0x18051A3A0", Slot = "69")]
	protected virtual void BlockStart()
	{
		this._sortingGroup.sortingLayerName = "fog";
		this._sortingGroup.sortAtRoot = true;
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0007C8DC File Offset: 0x0007AADC
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x51A330", Offset = "0x518930", VA = "0x18051A330")]
	private void BlockOver()
	{
		this._sortingGroup.sortingLayerName = "Default";
		SortingGroup sortingGroup = this._sortingGroup;
		int num = 0;
		sortingGroup.sortAtRoot = num != 0;
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x0007C910 File Offset: 0x0007AB10
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x51A1E0", Offset = "0x5187E0", VA = "0x18051A1E0")]
	private void AllBlockOver()
	{
		this.blocking = false;
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x0007C924 File Offset: 0x0007AB24
	[Token(Token = "0x600169B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Umbrellaleaf()
	{
	}

	// Token: 0x04000DFD RID: 3581
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000DFD")]
	public SortingGroup _sortingGroup;

	// Token: 0x04000DFE RID: 3582
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000DFE")]
	public bool blocking;
}
