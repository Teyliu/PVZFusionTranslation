using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x020007A6 RID: 1958
[Token(Token = "0x20007A6")]
public class BulletPoolManager : MonoBehaviour
{
	// Token: 0x060027B4 RID: 10164 RVA: 0x000D27E4 File Offset: 0x000D09E4
	[Token(Token = "0x60027B4")]
	[Address(RVA = "0x638B50", Offset = "0x637150", VA = "0x180638B50")]
	private void Awake()
	{
		ulong num5;
		do
		{
			int num = 0;
			BulletPoolManager.Instance = this;
			Board instance = Board.Instance;
			this.board = instance;
			List<BulletType> allBullets = GameAPP.resourcesManager.allBullets;
			bool flag;
			if (flag)
			{
				BulletPoolManager.<>c__DisplayClass3_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.item = (BulletType)num;
				Func<Bullet> func;
				Action<Bullet> action;
				Action<Bullet> action2;
				Action<Bullet> action3;
				ulong num2;
				ulong num3;
				ulong num4;
				ObjectPool<Bullet> objectPool = new ObjectPool(func, action, action2, action3, num2 != 0UL, (int)num3, (int)num4);
				Dictionary<BulletType, ObjectPool<Bullet>> dictionary = this.pools;
				BulletType item = CS$<>8__locals1.item;
				dictionary.Add(item, objectPool);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x000D2870 File Offset: 0x000D0A70
	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x638EF0", Offset = "0x6374F0", VA = "0x180638EF0")]
	private Bullet CreateBullet(BulletType theBulletType)
	{
		Dictionary<BulletType, GameObject> bulletPrefabs = GameAPP.resourcesManager.bulletPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Transform transform = base.transform;
		GameObject gameObject;
		SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
		Rigidbody2D rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
		ulong num;
		rigidbody2D.isKinematic = num != 0UL;
		Bullet component = gameObject.GetComponent<Bullet>();
		Board instance = Board.Instance;
		component.board = instance;
		component.theBulletType = theBulletType;
		component.rb = rigidbody2D;
		Collider2D component2 = component.GetComponent<Collider2D>();
		component.col = component2;
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		component.zombieLayer = mask;
		float boardMinX = this.board.boardMinX;
		component.minX = boardMinX;
		float boardMinY = this.board.boardMinY;
		component.minY = boardMinY;
		float boardMaxX = this.board.boardMaxX;
		component.maxX = boardMaxX;
		float boardMaxY = this.board.boardMaxY;
		component.maxY = boardMaxY;
		Transform transform2 = component.transform.Find("Shadow");
		component.shadow = transform2;
		BulletMovement movement = BulletMovement.GetMovement(BulletMoveWay.MoveRight);
		component.bulletMovement = movement;
		component.bulletMovement.bullet = component;
		component.bulletMovement.UpdateHitFilter();
		if (GameAPP.config.showBulletDamage)
		{
			DamageHUD damageHUD = global::UnityEngine.Object.Instantiate<DamageHUD>(Resources.Load<DamageHUD>("Image/HealthIcon/DamageHUD"));
			Transform transform3 = damageHUD.transform;
			Transform uiparent = this.board.UIParent;
			int num2 = 0;
			transform3.SetParent(uiparent, num2 != 0);
			damageHUD.follow = component;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x000D2A08 File Offset: 0x000D0C08
	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x449530", Offset = "0x447B30", VA = "0x180449530")]
	private void GetBullet(Bullet obj)
	{
		obj.gameObject.SetActive(true);
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x000D2A28 File Offset: 0x000D0C28
	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void ReleaseBullet(Bullet obj)
	{
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x000D2A38 File Offset: 0x000D0C38
	[Token(Token = "0x60027B8")]
	[Address(RVA = "0x639360", Offset = "0x637960", VA = "0x180639360")]
	private void DestoryBullet(Bullet obj)
	{
		global::UnityEngine.Object.Destroy(obj.gameObject);
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x000D2A58 File Offset: 0x000D0C58
	[Token(Token = "0x60027B9")]
	[Address(RVA = "0x6393D0", Offset = "0x6379D0", VA = "0x1806393D0")]
	public BulletPoolManager()
	{
		Dictionary<BulletType, ObjectPool<Bullet>> dictionary = new Dictionary();
		this.pools = dictionary;
		base..ctor();
	}

	// Token: 0x040014F6 RID: 5366
	[Token(Token = "0x40014F6")]
	public static BulletPoolManager Instance;

	// Token: 0x040014F7 RID: 5367
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014F7")]
	public Dictionary<BulletType, ObjectPool<Bullet>> pools;

	// Token: 0x040014F8 RID: 5368
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014F8")]
	private Board board;
}
