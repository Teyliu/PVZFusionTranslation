using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class ZombieBattleManager : MonoBehaviour
{
	// Token: 0x0600048C RID: 1164 RVA: 0x00017CAC File Offset: 0x00015EAC
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x5B6DA0", Offset = "0x5B53A0", VA = "0x1805B6DA0")]
	private void Awake()
	{
		ZombieBattleManager.Instance = this;
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00017CC0 File Offset: 0x00015EC0
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x5B73F0", Offset = "0x5B59F0", VA = "0x1805B73F0")]
	private void Start()
	{
		this.InitZombie();
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00017CD4 File Offset: 0x00015ED4
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x5B7110", Offset = "0x5B5710", VA = "0x1805B7110")]
	public void SelectZombie(Zombie zombie)
	{
		Zombie zombie2 = this.controlledZombie;
		int num = 0;
		if (!(zombie2 == num))
		{
			ZombieType theZombieType = this.controlledZombie.theZombieType;
			if (zombie.theZombieType != theZombieType)
			{
				Transform axis = this.controlledZombie.axis;
				Zombie zombie3 = this.controlledZombie;
				int theHealth = zombie3.theHealth;
				zombie3.Die(2);
				Zombie zombie4 = this.controlledZombie;
				ParticleManager instance = ParticleManager.Instance;
				Transform axis2 = zombie4.axis;
				int num2 = 0;
				int num3 = 0;
				int theZombieRow = this.controlledZombie.theZombieRow;
				int num4 = 0;
				ulong num5;
				Particle particle = instance.SetParticle((ParticleType)((uint)11), num2, theZombieRow, num5 != 0UL, (float)num3);
				CreateZombie instance2 = CreateZombie.Instance;
				Zombie zombie5;
				this.controlledZombie = zombie5;
				this.controlledZombie.theHealth = theHealth;
				Zombie zombie6 = this.controlledZombie;
				int num6 = this.maxHealth;
				zombie6.theMaxHealth = num6;
				this.controlledZombie.theFirstArmorHealth = num4;
				this.controlledZombie.theSecondArmorHealth = num4;
				Zombie zombie7 = this.controlledZombie;
				this.controlledZombie.theOriginSpeed = 1.3f;
			}
		}
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00017DE4 File Offset: 0x00015FE4
	[Token(Token = "0x600048F")]
	[Address(RVA = "0x5B6E90", Offset = "0x5B5490", VA = "0x1805B6E90")]
	public void InitZombie()
	{
		int num = 0;
		CreateZombie instance = CreateZombie.Instance;
		float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(num);
		int num2 = 0;
		ulong num3;
		Zombie component = instance.SetZombieWithMindControl(num2, (ZombieType)((uint)100), boxXFromColumn, num3 != 0UL).GetComponent<Zombie>();
		this.controlledZombie = component;
		Zombie zombie = this.controlledZombie;
		ulong num4;
		this.zombieBox = num4;
		Vector2 zombiePosition = this.GetZombiePosition();
		Zombie zombie2 = this.controlledZombie;
		int num5 = this.maxHealth;
		zombie2.theHealth = num5;
		Zombie zombie3 = this.controlledZombie;
		int num6 = this.maxHealth;
		zombie3.theMaxHealth = num6;
		this.controlledZombie.theOriginSpeed = 1.3f;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00017E84 File Offset: 0x00016084
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x5B7400", Offset = "0x5B5A00", VA = "0x1805B7400")]
	private void Update()
	{
		Zombie zombie = this.controlledZombie;
		int num = 0;
		bool flag = zombie != num;
		if (!flag)
		{
			if (this.lose != flag)
			{
				goto IL_00B5;
			}
			this.lose = true;
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("你失去了你的僵尸，将在10秒后复活", 3f, num2 != 0);
			this.timer = 10f;
		}
		if (global::Lawnf.GetKeyDown((KeyCode)((uint)119)))
		{
		}
		if (global::Lawnf.GetKeyDown((KeyCode)((uint)97)))
		{
		}
		if (global::Lawnf.GetKeyDown((KeyCode)((uint)115)))
		{
			int num3 = this.zombieBox.m_Y;
			num3++;
		}
		if (global::Lawnf.GetKeyDown((KeyCode)((uint)100)))
		{
			Vector2Int vector2Int = this.zombieBox;
		}
		Zombie zombie2 = this.controlledZombie;
		Vector2 zombiePosition = this.GetZombiePosition();
		if (!this.lose)
		{
			return;
		}
		IL_00B5:
		float num4 = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num4;
		InGameText instance2 = InGameText.Instance;
		int num5 = 0;
		instance2.ShowText("你的僵尸复活了！", 3f, num5 != 0);
		this.lose = false;
		this.InitZombie();
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00017F94 File Offset: 0x00016194
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x5B6FF0", Offset = "0x5B55F0", VA = "0x1805B6FF0")]
	private void MoveBox(int theColumn, int theRow)
	{
		Board instance = Board.Instance;
		if (theColumn < instance.columnNum && theRow < instance.rowNum)
		{
			Zombie zombie = this.controlledZombie;
			this.zombieBox = theColumn;
			int y = this.zombieBox.m_Y;
			zombie.theZombieRow = y;
			SortingGroup sortingGroup = this.controlledZombie.sortingGroup;
			int y2 = this.zombieBox.m_Y;
			string text = string.Format("zombie{0}", y2);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00018010 File Offset: 0x00016210
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x5B6E00", Offset = "0x5B5400", VA = "0x1805B6E00")]
	private Vector2 GetZombiePosition()
	{
		Mouse instance = Mouse.Instance;
		Mouse instance2 = Mouse.Instance;
		int y = this.zombieBox.m_Y;
		float num;
		float landY = instance2.GetLandY(num, y);
		return typeof(Mouse).TypeHandle;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00018058 File Offset: 0x00016258
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x5B7620", Offset = "0x5B5C20", VA = "0x1805B7620")]
	public ZombieBattleManager()
	{
	}

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	public static ZombieBattleManager Instance;

	// Token: 0x040002AE RID: 686
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002AE")]
	public Zombie controlledZombie;

	// Token: 0x040002AF RID: 687
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002AF")]
	private Vector2Int zombieBox;

	// Token: 0x040002B0 RID: 688
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B0")]
	public int maxHealth = (int)((ulong)1000L);

	// Token: 0x040002B1 RID: 689
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002B1")]
	private bool lose;

	// Token: 0x040002B2 RID: 690
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B2")]
	private float timer;
}
