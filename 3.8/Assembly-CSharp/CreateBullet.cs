using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public class CreateBullet : MonoBehaviour
{
	// Token: 0x060008C7 RID: 2247 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x858260", Offset = "0x856860", VA = "0x180858260")]
	private void Awake()
	{
		CreateBullet.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		BoardEntity boardEntity = this.board.boardEntity;
		this.boardEntity = boardEntity;
		throw new NullReferenceException();
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x858390", Offset = "0x856990", VA = "0x180858390")]
	public Bullet SetBullet(float x, float y, int theRow, BulletType theBulletType, BulletMoveWay theMovingWay, bool fromEnermy = false)
	{
		Dictionary<BulletType, ObjectPool<Bullet>> pools = BulletPoolManager.Instance.pools;
		bool flag;
		if (flag)
		{
			Bullet bullet;
			Transform transform = bullet.transform;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Rigidbody2D rb = bullet.rb;
			bullet.theBulletRow = theRow;
			bullet.<Team>k__BackingField = Team.Player;
			this.AddToList(bullet);
			this.SetLayer(bullet, 11);
			bullet.InitData();
			return bullet;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x0002DC54 File Offset: 0x0002BE54
	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x8580D0", Offset = "0x8566D0", VA = "0x1808580D0")]
	private void AddToList(Bullet bullet)
	{
		Queue<int> availableIndices = this._availableIndices;
		List<Bullet> bulletArray = this.boardEntity.bulletArray;
		int size = bulletArray._size;
		bulletArray._size = availableIndices;
		int size2 = this.boardEntity.bulletArray._size;
		bullet.indexInArray = size2;
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x858300", Offset = "0x856900", VA = "0x180858300")]
	public void RemoveFromList(Bullet bullet)
	{
		List<Bullet> bulletArray = this.boardEntity.bulletArray;
		int num = 0;
		int indexInArray = bullet.indexInArray;
		bulletArray[indexInArray] = num;
		Queue<int> availableIndices = this._availableIndices;
		int indexInArray2 = bullet.indexInArray;
		availableIndices.Enqueue(indexInArray2);
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x0002DCF8 File Offset: 0x0002BEF8
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x8585C0", Offset = "0x856BC0", VA = "0x1808585C0")]
	public void SetLayer(Bullet bullet, int theRow)
	{
		SortingGroup component = bullet.GetComponent<SortingGroup>();
		bullet.sortingGroup = component;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
		int currentBulletNum = this.board.currentBulletNum;
		component.sortingOrder = currentBulletNum;
		Transform shadow = bullet.shadow;
		int num = 0;
		if (shadow != num)
		{
			SortingGroup component2 = bullet.shadow.GetComponent<SortingGroup>();
			int num2 = 0;
			if (component2 == num2)
			{
				bullet.shadow.gameObject.AddComponent<SortingGroup>().sortAtRoot = true;
			}
		}
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x0002DD88 File Offset: 0x0002BF88
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x858780", Offset = "0x856D80", VA = "0x180858780")]
	public CreateBullet()
	{
		Queue<int> queue = new Queue();
		this._availableIndices = queue;
		base..ctor();
	}

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	public static CreateBullet Instance;

	// Token: 0x0400045F RID: 1119
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045F")]
	private Board board;

	// Token: 0x04000460 RID: 1120
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000460")]
	private BoardEntity boardEntity;

	// Token: 0x04000461 RID: 1121
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000461")]
	private readonly Queue<int> _availableIndices;
}
