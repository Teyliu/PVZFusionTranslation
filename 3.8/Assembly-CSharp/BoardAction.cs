using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000257 RID: 599
[Token(Token = "0x2000257")]
public class BoardAction
{
	// Token: 0x06000AC3 RID: 2755 RVA: 0x0003DDE0 File Offset: 0x0003BFE0
	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x89C800", Offset = "0x89AE00", VA = "0x18089C800")]
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
				goto IL_020D;
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
					goto IL_011F;
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
			IL_011F:
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
				goto IL_0236;
			}
			bool flag7;
			if (flag7)
			{
			}
			if (num != 0)
			{
				goto IL_023C;
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
				goto IL_011F;
			}
			goto IL_011F;
		}
		bool flag11;
		bool flag10 = flag11 - true;
		if (flag11 > false)
		{
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
		}
		IL_020D:
		ScreenShake.TriggerShake(0.15f);
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		bool flag12;
		if (!flag12)
		{
			Crater crater;
			return crater;
		}
		throw new NullReferenceException();
		IL_0236:
		throw new NullReferenceException();
		IL_023C:
		throw new NullReferenceException();
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0003E030 File Offset: 0x0003C230
	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x89DDB0", Offset = "0x89C3B0", VA = "0x18089DDB0")]
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
				goto IL_00C9;
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
		IL_00C9:
		throw new NullReferenceException();
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x0003E10C File Offset: 0x0003C30C
	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x89BC70", Offset = "0x89A270", VA = "0x18089BC70")]
	public void CreateFreeze(Vector2 pos, float timer = 4f)
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
				goto IL_00D6;
			}
			int num3 = 0;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag3;
			if (flag3)
			{
			}
			if (num3 != 0)
			{
				goto IL_00DC;
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
				goto IL_00E2;
			}
			num6 = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
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
				int num7 = 0;
				int num8 = num.System.IConvertible.ToInt32(num7);
			}
		}
		while (num6 != 0);
		uint num9;
		GameAPP.PlaySound((int)num9, 0.5f, 1f);
		GameObject gameObject = Resources.Load<GameObject>("Particle/Prefabs/IceShroomExplode");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num6, identityQuaternion, transform);
		return;
		IL_00D6:
		throw new NullReferenceException();
		IL_00DC:
		throw new NullReferenceException();
		IL_00E2:
		throw new NullReferenceException();
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x0003E204 File Offset: 0x0003C404
	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x89B020", Offset = "0x899620", VA = "0x18089B020")]
	public void CreateFireLineVision(int theRow)
	{
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(42, 0.5f, 1f);
		this.CreateFireAnim(theRow);
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x0003E234 File Offset: 0x0003C434
	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x89B0D0", Offset = "0x8996D0", VA = "0x18089B0D0")]
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
					goto IL_020A;
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
				bool flag8;
				if (flag6 > true)
				{
					if (flag6 > true)
					{
						if (flag6)
						{
							goto IL_01DD;
						}
						if (flag6)
						{
						}
						bool flag7;
						if (!flag7)
						{
							goto IL_01DD;
						}
					}
					flag8 = "{il2cpp field on {'constant155' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(UltimateJalaNut).TypeHandle;
					if (flag8)
					{
						goto IL_01D8;
					}
				}
				if (flag8 <= true)
				{
					goto IL_01DD;
				}
				if (flag8)
				{
				}
				IL_01D8:
				if (flag8)
				{
				}
			}
			IL_01DD:;
		}
		while (num7 != 0);
		num7++;
		IceRoad iceRoad;
		float roadStartX = iceRoad.roadStartX;
		IceRoad iceRoad2;
		iceRoad2.x = roadStartX;
		return;
		IL_020A:
		throw new NullReferenceException();
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x0003E46C File Offset: 0x0003C66C
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x89C4C0", Offset = "0x89AAC0", VA = "0x18089C4C0")]
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

	// Token: 0x06000AC9 RID: 2761 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x89AC90", Offset = "0x899290", VA = "0x18089AC90")]
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

	// Token: 0x06000ACA RID: 2762 RVA: 0x0003E590 File Offset: 0x0003C790
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x89C580", Offset = "0x89AB80", VA = "0x18089C580")]
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

	// Token: 0x06000ACB RID: 2763 RVA: 0x0003E6A0 File Offset: 0x0003C8A0
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x89DA10", Offset = "0x89C010", VA = "0x18089DA10")]
	public Crater SetPit(int theColumn, int theRow)
	{
		int num2;
		do
		{
			int num = 0;
			List<GridItem> griditemArray = this.board.griditemArray;
			num2 = 0;
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
		}
		while (num2 != 0);
		int num3 = 0;
		BoardGrid boardGrid;
		GridItem gridItem;
		GridItem gridItem2;
		if (boardGrid.boxType == BoxType.Water || gridItem == 0 || gridItem2 != 0)
		{
		}
		List<Plant> plants = boardGrid.plants;
		int num4 = 0;
		Plant plant;
		if (plant != num4)
		{
			int num5 = 0;
			plant.Die((Plant.DieReason)num5);
		}
		num3++;
		return null;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0003E718 File Offset: 0x0003C918
	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x89A9E0", Offset = "0x898FE0", VA = "0x18089A9E0")]
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

	// Token: 0x06000ACD RID: 2765 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public BoardAction()
	{
	}

	// Token: 0x040006D7 RID: 1751
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D7")]
	public Board board;
}
