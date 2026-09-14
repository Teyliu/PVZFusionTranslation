using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200025D RID: 605
[Token(Token = "0x200025D")]
public class BoardAction
{
	// Token: 0x06000ADE RID: 2782 RVA: 0x0003DBC8 File Offset: 0x0003BDC8
	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x92C420", Offset = "0x92AA20", VA = "0x18092C420")]
	public Crater SetDoom(int theColumn, int theRow, bool setPit, bool iceDoom = false, [Optional] Vector2 position, int damage = 1800, int effect = 0, [Optional] Action<Zombie> action, bool existParticle = true, PlantType fromType = PlantType.Nothing)
	{
		for (;;)
		{
			int num = 0;
			Mouse instance = Mouse.Instance;
			float num2;
			float landY = Mouse.Instance.GetLandY(num2, theRow);
			GameConfig config = GameAPP.config;
			GameObject[] particlePrefab = GameAPP.particlePrefab;
			GameObject[] particlePrefab2 = GameAPP.particlePrefab;
			GameObject gameObject = GameAPP.particlePrefab[29];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			bool flag;
			if (flag)
			{
				GameObject gameObject2;
				global::UnityEngine.Object.Destroy(gameObject2.GetComponent<Doom>().sprit);
			}
			int mask = LayerMask.GetMask(new string[] { "Zombie", "Ladder", "TorchWood", "Default" });
			Collider2D[] array;
			if (num >= array.Length)
			{
				goto IL_01FA;
			}
			bool flag2;
			if (flag2)
			{
				goto IL_00FC;
			}
			bool flag3;
			if (!flag3)
			{
				bool flag4;
				if (!flag4)
				{
					goto IL_011B;
				}
				num++;
			}
			if (array == (ulong)3L)
			{
				num++;
			}
			if (array == (ulong)8L)
			{
				bool flag5 = "{il2cpp array field local45->}" == typeof(FreezedPlant).TypeHandle;
				num++;
				goto IL_00FC;
			}
			IL_011B:
			num++;
			if (num == 1)
			{
				this.board.iceDoomFreezeTime = 10f;
			}
			List<Zombie> list = new List();
			int size = this.board.zombieArray._size;
			int num3 = size - 1;
			if (size > 0)
			{
				Zombie zombie = this.board.zombieArray[num3];
				int num4 = 0;
				if (zombie != num4 && (this.board.zombieArray[num3].isMindControlled ? 1 : 0) == num)
				{
					Zombie zombie2 = this.board.zombieArray[num3];
				}
			}
			bool flag6;
			if (flag6)
			{
			}
			if (num != 0)
			{
				goto IL_028E;
			}
			bool flag7;
			if (flag7)
			{
			}
			if (num != 0)
			{
				goto IL_0294;
			}
			int num5 = 0;
			bool flag8;
			if (flag8)
			{
			}
			if (num5 == 0)
			{
				break;
			}
			continue;
			IL_00FC:
			num++;
			bool flag9;
			if (flag9)
			{
				BoxType boxType;
				if (boxType != BoxType.Water)
				{
					CreateZombie instance2 = CreateZombie.Instance;
				}
				CreateZombie instance3 = CreateZombie.Instance;
				goto IL_011B;
			}
			goto IL_011B;
		}
		int num6 = 0;
		GridItem gridItem;
		if (gridItem != num6)
		{
			GridItem gridItem2;
			GridItem gridItem3;
			if (gridItem2.theItemType == GridItemType.Ladder)
			{
				gridItem3.Die();
			}
			if (gridItem3 == (ulong)8L)
			{
			}
		}
		IL_01FA:
		ScreenShake.TriggerShake(0.15f);
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		bool flag10;
		if (!flag10)
		{
			Func<Plant, bool> func;
			if (BoardAction.<>c.<>9__1_0 == 0)
			{
				func = (Plant a) => a.thePlantType == PlantType.DoomPot;
				BoardAction.<>c.<>9__1_0 = func;
			}
			List<Plant> list2;
			Plant plant = Enumerable.FirstOrDefault<Plant>(list2, func);
			int num8 = 0;
			if (!(plant != num8))
			{
				Crater crater;
				return crater;
			}
			int thePlantMaxHealth = plant.thePlantMaxHealth;
			plant.thePlantMaxHealth = thePlantMaxHealth;
			int num9 = thePlantMaxHealth.Multiply(0.2f);
			plant.RealTakeDamage(num9);
			plant.FlashOnce();
		}
		throw new NullReferenceException();
		IL_028E:
		throw new NullReferenceException();
		IL_0294:
		throw new NullReferenceException();
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0003DE70 File Offset: 0x0003C070
	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x92DD30", Offset = "0x92C330", VA = "0x18092DD30")]
	public void SetSmallDoom(Vector2 position, int theRow, Team team, int damage = 1800)
	{
		ulong num5;
		do
		{
			int num = 0;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			ScreenShake.TriggerShake(0.15f);
			ParticleManager instance = ParticleManager.Instance;
			List<Plant> list = new List();
			List<Zombie> list2 = new List();
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					LayerMask layerMask;
					int mask = layerMask.m_Mask;
					if (layerMask != 0)
					{
						num++;
					}
				}
				bool flag2;
				if (!flag2 || flag2 || !flag2)
				{
				}
				num++;
			}
			Func<Plant, bool> func;
			if (BoardAction.<>c.<>9__2_0 == 0)
			{
				func = (Plant p) => p.thePlantType == PlantType.DoomNut;
				BoardAction.<>c.<>9__2_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(list, func);
			int num3 = 0;
			if (plant != num3)
			{
				break;
			}
			bool flag3;
			if (flag3)
			{
			}
			ulong num4;
			if (num4 != (ulong)0L)
			{
				goto IL_00DB;
			}
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num5 != (ulong)0L);
		Vector3 vector;
		float z = vector.z;
		return;
		IL_00DB:
		throw new NullReferenceException();
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0003DF60 File Offset: 0x0003C160
	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x92B840", Offset = "0x929E40", VA = "0x18092B840")]
	public void CreateFreeze(Vector2 pos, float timer = 4f, bool sprit = true)
	{
		int num6;
		do
		{
			int num = 0;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
			if (num2 != 0)
			{
				goto IL_00E4;
			}
			int num3 = 0;
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag3;
			if (flag3)
			{
			}
			if (num3 != 0)
			{
				goto IL_00EA;
			}
			int num4 = 0;
			bool flag4;
			if (flag4)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
			if (num4 != 0)
			{
				goto IL_00F0;
			}
			num6 = 0;
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
			bool flag5;
			if (flag5)
			{
				if (flag5 > true)
				{
				}
				while (num == 12)
				{
				}
				bool flag6;
				while (flag6)
				{
				}
				if (flag6 <= true || flag6)
				{
				}
			}
		}
		while (num6 != 0);
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		GameObject gameObject = Resources.Load<GameObject>("Particle/Prefabs/IceShroomExplode");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2;
		Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num6, identityQuaternion, transform2).transform;
		int num8 = 0;
		global::UnityEngine.Object.Destroy(transform.GetChild(num8).gameObject);
		return;
		IL_00E4:
		throw new NullReferenceException();
		IL_00EA:
		throw new NullReferenceException();
		IL_00F0:
		throw new NullReferenceException();
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0003E064 File Offset: 0x0003C264
	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x92ABF0", Offset = "0x9291F0", VA = "0x18092ABF0")]
	public void CreateFireLineVision(int theRow)
	{
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(42, 0.5f, 1f);
		this.CreateFireAnim(theRow);
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0003E094 File Offset: 0x0003C294
	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x92ACA0", Offset = "0x9292A0", VA = "0x18092ACA0")]
	public void CreateFireLine(int theFireRow, int damage = 1800, bool fromZombie = false, bool fix = false, bool shake = true, [Optional] Action<Zombie> action, PlantType fromType = PlantType.Nothing)
	{
		int num7;
		do
		{
			int num = 0;
			int rowNum = this.board.rowNum;
			ScreenShake.TriggerShake(0.15f);
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			this.CreateFireAnim(theFireRow);
			if (!fromZombie)
			{
				Board board = this.board;
				int num3 = 0;
				BoardAction.<FireLineDamage>d__6 <FireLineDamage>d__;
				<FireLineDamage>d__.<>1__state = num3;
				<FireLineDamage>d__.<>4__this = this;
				<FireLineDamage>d__.theFireRow = theFireRow;
				<FireLineDamage>d__.damage = damage;
				<FireLineDamage>d__.fix = false;
				<FireLineDamage>d__.action = 0;
				<FireLineDamage>d__.fromType = PlantType.Peashooter;
				Coroutine coroutine = board.StartCoroutine(<FireLineDamage>d__);
				int size = this.board.griditemArray._size;
				int num4 = size - 1;
				if (size > 0)
				{
					GridItem gridItem = this.board.griditemArray[num4];
					int num5 = 0;
					if (gridItem != num5 && gridItem.theItemRow == theFireRow)
					{
						if (gridItem.theItemType == GridItemType.Ladder)
						{
							gridItem.Die();
						}
						bool flag = "{il2cpp field on GridItem.Die, offset 0xFFFFFFFFFFFFFFF8}" == typeof(FreezedPlant).TypeHandle;
					}
				}
				List<Obstacle> zombieBalls = this.board.zombieBalls;
				bool flag2;
				if (flag2)
				{
					int num6 = 0;
					if (!(num != num6))
					{
						continue;
					}
				}
				if (num3 != 0)
				{
					goto IL_0206;
				}
			}
			bool flag4;
			bool flag3 = flag4 - true;
			num7 = 0;
			if (flag4 > false)
			{
				int num8 = 0;
				Zombie zombie;
				if (zombie != num8 && (zombie.isMindControlled ? 1 : 0) == num7 && (zombie.beforeDying ? 1 : 0) == num7 && zombie.theZombieType == ZombieType.SquashZombie)
				{
					uint num9;
					zombie.Die((int)num9);
					CreateZombie instance = CreateZombie.Instance;
					Transform axis = zombie.axis;
				}
			}
			GridSystem gridSystem = this.board.gridSystem;
			BoardGrid boardGrid;
			List<Plant> plants = boardGrid.plants;
			bool flag5;
			if (flag5)
			{
				int num10 = 0;
				bool flag6 = num != num10;
				while (!flag6)
				{
				}
				if (flag6 <= true)
				{
					goto IL_01C0;
				}
				if (flag6 > true)
				{
					if (flag6)
					{
						goto IL_01CF;
					}
					if (flag6)
					{
					}
					bool flag7;
					if (!flag7)
					{
						goto IL_01D9;
					}
				}
				bool flag8;
				if (!flag8)
				{
					goto IL_01C0;
				}
				IL_01CA:
				if (flag8)
				{
					goto IL_01CF;
				}
				goto IL_01D9;
				IL_01C0:
				if (flag8 > true)
				{
					if (flag8)
					{
						goto IL_01CA;
					}
					goto IL_01CA;
				}
				IL_01CF:
				bool flag9;
				if (flag9 || !flag9)
				{
				}
			}
			IL_01D9:;
		}
		while (num7 != 0);
		num7++;
		IceRoad iceRoad;
		float roadStartX = iceRoad.roadStartX;
		IceRoad iceRoad2;
		iceRoad2.x = roadStartX;
		return;
		IL_0206:
		throw new NullReferenceException();
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x92C0E0", Offset = "0x92A6E0", VA = "0x18092C0E0")]
	private IEnumerator FireLineDamage(int theFireRow, int damage, bool fix, Action<Zombie> action, PlantType fromType)
	{
		BoardAction.<FireLineDamage>d__6 <FireLineDamage>d__;
		<FireLineDamage>d__.System.IDisposable.Dispose();
		<FireLineDamage>d__.<>1__state = (int)((ulong)0L);
		<FireLineDamage>d__.<>4__this = this;
		<FireLineDamage>d__.action = 0;
		<FireLineDamage>d__.theFireRow = theFireRow;
		<FireLineDamage>d__.damage = damage;
		<FireLineDamage>d__.fix = fix;
		<FireLineDamage>d__.fromType = PlantType.Peashooter;
		return null;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0003E310 File Offset: 0x0003C510
	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x92A860", Offset = "0x928E60", VA = "0x18092A860")]
	private void CreateFireAnim(int row)
	{
		FireLine fireLine = this.board.fireLineArray[row];
		int num = 0;
		if (!(fireLine == num))
		{
			this.board.fireLineArray[row].InitFireLine();
		}
		GameObject gameObject = Resources.Load<GameObject>("Particle/Anim/FineLine/FireLine");
		float boxYFromRow = Mouse.Instance.GetBoxYFromRow(row);
		if (this.board.rowNum == 5)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		SortingGroup component = gameObject2.GetComponent<SortingGroup>();
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		gameObject2.GetComponent<SortingGroup>().sortingOrder = 30000;
		FireLine component2 = gameObject2.GetComponent<FireLine>();
		component2.theFireRow = row;
		this.board.fireLineArray[0] = component2;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0003E3EC File Offset: 0x0003C5EC
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x92C1A0", Offset = "0x92A7A0", VA = "0x18092C1A0")]
	public Bullet FirePeas(Bullet ob, Plant torch, int damage, BulletType theBulletType, bool sound = true)
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = ob.transform;
		Transform transform2 = ob.transform;
		BulletMoveWay moveWay = ob._moveWay;
		int num = ob._damage;
		num += damage;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		bullet._damage = num;
		float theExistTime = ob.theExistTime;
		bullet.theExistTime = theExistTime;
		Vector2 velocity = ob.rb.velocity;
		rb.velocity = velocity;
		float normalSpeed = ob.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		bullet.torchWood = torch;
		int rogueStatus = ob.rogueStatus;
		bullet.rogueStatus = rogueStatus;
		Transform transform3 = bullet.transform;
		Transform transform4 = ob.transform;
		BulletStatus theStatus = ob.theStatus;
		bullet.theStatus = theStatus;
		PlantType fromType = ob.fromType;
		bullet.fromType = fromType;
		bool shootByZombie = ob.shootByZombie;
		bullet.shootByZombie = shootByZombie;
		if (transform3 == 0)
		{
			bullet.normalSpeed = 6f;
		}
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		ob.Die();
		return bullet;
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0003E4FC File Offset: 0x0003C6FC
	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x92D750", Offset = "0x92BD50", VA = "0x18092D750")]
	public Crater SetPit(int theColumn, int theRow)
	{
		int num3;
		do
		{
			int num = 0;
			List<GridItem> griditemArray = this.board.griditemArray;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
			}
			if (num2 != 0)
			{
				goto IL_008D;
			}
			num3 = 0;
			BoardGrid boardGrid;
			if (boardGrid.boxType == BoxType.Water)
			{
				bool flag2;
				if (flag2)
				{
				}
				if (num3 != 0)
				{
					goto IL_0093;
				}
				CreatePlant instance = CreatePlant.Instance;
				Plant plant;
				if (plant != 0)
				{
				}
				int num4 = 0;
				if (plant != num4)
				{
					plant.theLilyType = (PlantType)((ulong)11L);
				}
			}
			GridItem gridItem;
			if (gridItem == 0)
			{
			}
			GridItem gridItem2;
			if (gridItem2 == 0)
			{
			}
			bool flag3;
			if (flag3)
			{
			}
		}
		while (num3 != 0);
		throw new NullReferenceException();
		IL_008D:
		throw new NullReferenceException();
		IL_0093:
		throw new NullReferenceException();
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x92A5B0", Offset = "0x928BB0", VA = "0x18092A5B0")]
	public BombCherry CreateCherryExplode(Vector2 v, int theRow, CherryBombType bombType = CherryBombType.Normal, int damage = 1800, PlantType fromType = PlantType.Nothing, [Optional] Action<Zombie> action, bool immediately = true)
	{
		int num = bombType - CherryBombType.Sun;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num == 1)
					{
						goto IL_0026;
					}
					ParticleManager instance = ParticleManager.Instance;
				}
				ParticleManager instance2 = ParticleManager.Instance;
			}
			IL_0026:
			ParticleManager instance3 = ParticleManager.Instance;
		}
		ParticleManager instance4 = ParticleManager.Instance;
		ScreenShake.TriggerShake(0.15f);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		BombCherry bombCherry = new BombCherry();
		Board board = this.board;
		bombCherry.board = board;
		bombCherry.damageToZombie = 0;
		bombCherry.bombRow = theRow;
		bombCherry.bombType = bombType;
		bombCherry.zombieAction = 0;
		bombCherry.bombPosition = 0;
		bombCherry.bombPosition.y = (float)0;
		bombCherry.fromType = PlantType.Peashooter;
		bombCherry.targetPlant = (ulong)0L;
		int num3 = 0;
		bombCherry.Explode(num3);
		return bombCherry;
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0003E67C File Offset: 0x0003C87C
	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public BoardAction()
	{
	}

	// Token: 0x040006E2 RID: 1762
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E2")]
	public Board board;
}
