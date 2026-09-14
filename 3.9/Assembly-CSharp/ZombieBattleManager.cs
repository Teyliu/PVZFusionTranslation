using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000F7")]
public class ZombieBattleManager : MonoBehaviour
{
	// Token: 0x060004A7 RID: 1191 RVA: 0x000180C4 File Offset: 0x000162C4
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x5EC830", Offset = "0x5EAE30", VA = "0x1805EC830")]
	private void Awake()
	{
		ZombieBattleManager.Instance = this;
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x000180D8 File Offset: 0x000162D8
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x5ECE90", Offset = "0x5EB490", VA = "0x1805ECE90")]
	private void Start()
	{
		this.InitZombie();
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x000180EC File Offset: 0x000162EC
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x5ECBA0", Offset = "0x5EB1A0", VA = "0x1805ECBA0")]
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
				long theHealth = zombie3.theHealth;
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
				zombie6.theMaxHealth = (long)num6;
				this.controlledZombie.theFirstArmorHealth = num4;
				this.controlledZombie.theSecondArmorHealth = num4;
				Zombie zombie7 = this.controlledZombie;
				this.controlledZombie.theOriginSpeed = 1.3f;
			}
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x000181FC File Offset: 0x000163FC
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x5EC920", Offset = "0x5EAF20", VA = "0x1805EC920")]
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
		zombie2.theHealth = (long)num5;
		Zombie zombie3 = this.controlledZombie;
		int num6 = this.maxHealth;
		zombie3.theMaxHealth = (long)num6;
		this.controlledZombie.theOriginSpeed = 1.3f;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0001829C File Offset: 0x0001649C
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x5ECEA0", Offset = "0x5EB4A0", VA = "0x1805ECEA0")]
	private void Update()
	{
		Zombie zombie = this.controlledZombie;
		int num = 0;
		bool flag = zombie != num;
		if (!flag)
		{
			if (this.lose != flag)
			{
				goto IL_009F;
			}
			this.lose = true;
			InGameText instance = InGameText.Instance;
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
			int num2 = this.zombieBox.m_Y;
			num2++;
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
		IL_009F:
		float num3 = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num3;
		InGameText instance2 = InGameText.Instance;
		this.lose = false;
		this.InitZombie();
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00018380 File Offset: 0x00016580
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x5ECA80", Offset = "0x5EB080", VA = "0x1805ECA80")]
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

	// Token: 0x060004AD RID: 1197 RVA: 0x000183FC File Offset: 0x000165FC
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x5EC890", Offset = "0x5EAE90", VA = "0x1805EC890")]
	private Vector2 GetZombiePosition()
	{
		Mouse instance = Mouse.Instance;
		Mouse instance2 = Mouse.Instance;
		int y = this.zombieBox.m_Y;
		float num;
		float landY = instance2.GetLandY(num, y);
		return typeof(Mouse).TypeHandle;
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00018444 File Offset: 0x00016644
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x5ED0F0", Offset = "0x5EB6F0", VA = "0x1805ED0F0")]
	public ZombieBattleManager()
	{
	}

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	public static ZombieBattleManager Instance;

	// Token: 0x040002BC RID: 700
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002BC")]
	public Zombie controlledZombie;

	// Token: 0x040002BD RID: 701
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002BD")]
	private Vector2Int zombieBox;

	// Token: 0x040002BE RID: 702
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002BE")]
	public int maxHealth = (int)((ulong)1000L);

	// Token: 0x040002BF RID: 703
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002BF")]
	private bool lose;

	// Token: 0x040002C0 RID: 704
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002C0")]
	private float timer;
}
