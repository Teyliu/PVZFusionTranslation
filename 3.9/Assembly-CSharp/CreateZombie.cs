using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using GameLevel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000216 RID: 534
[Token(Token = "0x2000216")]
public class CreateZombie : MonoBehaviour
{
	// Token: 0x06000927 RID: 2343 RVA: 0x00030B90 File Offset: 0x0002ED90
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x903F50", Offset = "0x902550", VA = "0x180903F50")]
	private void Awake()
	{
		CreateZombie.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00030BB0 File Offset: 0x0002EDB0
	[Token(Token = "0x6000928")]
	[Address(RVA = "0x9051C0", Offset = "0x9037C0", VA = "0x1809051C0")]
	public static GameObject SetZombieInAlmanac(Vector3 position, ZombieType theZombieType)
	{
		int num;
		GameObject gameObject;
		for (;;)
		{
			num = 0;
			int num2 = 0;
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (!flag)
			{
				goto IL_01D5;
			}
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			float z = position.z;
			Zombie component = gameObject.GetComponent<Zombie>();
			float z2 = position.z;
			Animator anim = component.anim;
			int num3 = Animator.StringToHash("idle");
			int num4 = 0;
			if (anim.HasState(num4, num3))
			{
				component.anim.Play("idle");
			}
			component.anim.updateMode = (AnimatorUpdateMode)((uint)2);
			global::UnityEngine.Object.Destroy(component.col);
			global::UnityEngine.Object.Destroy(component.rb);
			global::UnityEngine.Object.Destroy(component);
			Transform transform = gameObject.transform;
			Vector3 vector;
			float z3 = vector.z;
			if (theZombieType <= ZombieType.BungiZombie)
			{
				goto IL_0120;
			}
			if (theZombieType > ZombieType.DolphinPeaZombie)
			{
				break;
			}
			if (theZombieType != ZombieType.GoldBungiZombie)
			{
				if (theZombieType != ZombieType.DolphinPeaZombie)
				{
					goto IL_0120;
				}
				goto IL_01C6;
			}
			IL_0135:
			BungiZombie component2 = gameObject.GetComponent<BungiZombie>();
			Transform transform2 = gameObject.transform;
			Vector2 vector2 = Vector3Extensions.Add(num, num, num);
			List<SortingGroup> hands = component2.hands;
			bool flag2;
			if (flag2)
			{
				global::UnityEngine.Object.Destroy(num2);
			}
			if (num != 0)
			{
				continue;
			}
			Transform transform3 = component2.BungeeCord.transform;
			Transform transform4 = component2.BungeeCord.transform;
			SpriteRenderer component3 = component2.bungeeTarget.GetComponent<SpriteRenderer>();
			int num5 = 0;
			component3.enabled = num5 != 0;
			IL_01AB:
			if (num2 == 17 && gameObject.transform == (ulong)19L)
			{
				goto IL_01C6;
			}
			continue;
			IL_0120:
			if (theZombieType <= ZombieType.Dolphinrider)
			{
				goto IL_01AB;
			}
			if (theZombieType != ZombieType.SnowDolphinrider)
			{
				while (theZombieType != ZombieType.BungiZombie)
				{
				}
				goto IL_0135;
			}
			goto IL_01C6;
		}
		if (theZombieType != ZombieType.DolphinGatlingZombie)
		{
			if (theZombieType == ZombieType.UltimateJacksonDriver)
			{
				Transform transform5 = gameObject.transform;
				int num6 = 0;
				transform5.GetChild(num6).GetComponent<Animator>().updateMode = (AnimatorUpdateMode)((uint)2);
				Transform transform6 = gameObject.transform;
				int num7 = 0;
				transform6.GetChild(num7).GetComponent<UltimateJacksonTurn>().active = num != 0;
			}
			return gameObject;
		}
		IL_01C6:
		Transform transform7 = gameObject.transform;
		IL_01D5:
		throw new NullReferenceException();
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00030D9C File Offset: 0x0002EF9C
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x903FF0", Offset = "0x9025F0", VA = "0x180903FF0")]
	public static GameObject CreateZombiePreview(ZombieType theZombieType, Color color, Transform parent, Vector2 position)
	{
		GameObject gameObject;
		Zombie component;
		int num;
		List<SpriteRenderer> sprites;
		do
		{
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (!flag)
			{
			}
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			component = gameObject.GetComponent<Zombie>();
			component.anim.Play("idle");
			num = 0;
			Animator anim = component.anim;
			int num2 = 0;
			anim.speed = (float)num2;
			component.isPreview = true;
			sprites = global::Core.Lawnf.GetSprites(gameObject);
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num != 0);
		int num3 = 0;
		Func<SpriteRenderer, int> func;
		if (CreateZombie.<>c.<>9__4_0 == 0)
		{
			CreateZombie.<>c.<>9__4_0 = func;
		}
		List<SpriteRenderer> list = Enumerable.ToList<SpriteRenderer>(Enumerable.OrderByDescending<SpriteRenderer, int>(sprites, func));
		int size = list._size;
		if (num3 < size)
		{
			SpriteRenderer spriteRenderer = list[num3];
			SpriteMask spriteMask = spriteRenderer.AddComponent<SpriteMask>();
			Sprite sprite = spriteRenderer.sprite;
			spriteMask.sprite = sprite;
			ulong num4;
			spriteMask.isCustomRangeActive = num4 != 0UL;
			int num5 = spriteRenderer.sortingOrder - 1;
			spriteMask.frontSortingOrder = num5;
			int sortingLayerID = spriteRenderer.sortingLayerID;
			spriteMask.frontSortingLayerID = sortingLayerID;
			spriteMask.alphaCutoff = 1f;
			SpriteRenderer spriteRenderer2 = list[1];
			num3++;
		}
		GameObject gameObject2 = new GameObject();
		Transform transform = gameObject2.transform;
		Transform transform2 = gameObject2.transform;
		gameObject2.tag = "Preview";
		Transform transform3 = gameObject2.transform;
		Transform axis = component.axis;
		Transform transform4 = gameObject2.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform5 = gameObject.transform;
		Transform transform6 = gameObject.transform;
		Transform transform7 = gameObject2.transform;
		transform6.parentInternal = transform7;
		SortingGroup sortingGroup = gameObject2.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "up1";
		uint num6;
		sortingGroup.sortingOrder = (int)num6;
		global::UnityEngine.Object.Destroy(component.axis.gameObject);
		global::UnityEngine.Object.Destroy(component);
		global::UnityEngine.Object.Destroy(component.col);
		global::UnityEngine.Object.Destroy(component.rb);
		throw new NullReferenceException();
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00030F98 File Offset: 0x0002F198
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x906000", Offset = "0x904600", VA = "0x180906000")]
	public Zombie SetZombie(int theRow, ZombieType theZombieType, float theX = 9.9f, bool isMindControlled = false)
	{
		Zombie component;
		for (;;)
		{
			int num = 0;
			BoxType[] roadType = this.board.roadType;
			if ("{il2cpp array field local8->}" == (ulong)1L)
			{
				Dictionary<ZombieType, ZombieType> amphibiousZombieToWater = TypeMgr.AmphibiousZombieToWater;
				bool flag;
				if (flag)
				{
				}
			}
			BoxType[] roadType2 = this.board.roadType;
			if ("{il2cpp array field local12->}" != (ulong)1L)
			{
				Dictionary<ZombieType, ZombieType> amphibiousZombieToLand = TypeMgr.AmphibiousZombieToLand;
				bool flag2;
				if (flag2)
				{
				}
			}
			Board board = this.board;
			if ((board.isEveStarted ? 1 : 0) == num)
			{
				BoxType[] roadType3 = board.roadType;
				bool flag3;
				if ("{il2cpp array field local16->}" != (ulong)1L && flag3)
				{
					goto IL_03B6;
				}
				BoxType[] roadType4 = this.board.roadType;
				bool flag4;
				bool flag5;
				if ("{il2cpp array field local20->}" == (ulong)1L && !flag4 && !flag5)
				{
					goto IL_03B6;
				}
			}
			int rowNum = this.board.rowNum;
			if (theRow == rowNum)
			{
				Board board2 = this.board;
				Mouse instance = Mouse.Instance;
				int columnNum = board2.columnNum;
				float boxXFromColumn = instance.GetBoxXFromColumn(columnNum);
			}
			if (theZombieType == ZombieType.ZombieBoss || theZombieType == ZombieType.ZombieBoss2)
			{
			}
			float landY = Mouse.Instance.GetLandY(8f, theRow);
			Board board3 = this.board;
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag6;
			if (!flag6)
			{
				goto IL_03B6;
			}
			Board board4 = this.board;
			GameObject gameObject;
			string name = gameObject.transform.name;
			int num2 = 0;
			gameObject.name = name;
			this.SetTransform(gameObject, num2);
			component = gameObject.GetComponent<Zombie>();
			Board board5 = this.board;
			component.board = board5;
			Rigidbody2D rb = component.rb;
			component.theZombieRow = theRow;
			component.theZombieType = theZombieType;
			component.<Team>k__BackingField = (Team)((ulong)1L);
			int num3 = component.col.callbackLayers.m_Mask.m_Mask;
			int mask = LayerMask.GetMask(new string[] { "Default" });
			num3 -= mask;
			LayerMask layerMask = num3;
			int num4 = component.col.callbackLayers.m_Mask.m_Mask;
			int mask2 = LayerMask.GetMask(new string[] { "Bullet" });
			num4 -= mask2;
			int mask3 = num4.m_Mask;
			Board board6 = this.board;
			Board board7 = this.board;
			this.SetLayer(theRow, component);
			this.AddToList(component);
			Dictionary<ZombieType, int> enermyCountDic = this.board.enermyCountDic;
			bool flag7;
			if (!flag7)
			{
			}
			BoardConfig config = this.board.config;
			float maxOriginalSpeed = config.maxOriginalSpeed;
			float num5 = global::UnityEngine.Random.Range(config.minOriginalSpeed, maxOriginalSpeed);
			component.theOriginSpeed = num5;
			if (this.board.config == 0)
			{
			}
			float num6 = this.board.config.zombieSpeedMultiplier * component.theOriginSpeed;
			component.theOriginSpeed = num6;
			Dictionary<ZombieType, int> enermyCountDic2 = this.board.enermyCountDic;
			bool flag8;
			if (flag8)
			{
				float theOriginSpeed = component.theOriginSpeed;
				component.theOriginSpeed = theOriginSpeed;
			}
			bool flag9;
			if (flag9)
			{
			}
			component.InitHealth();
			if (theZombieType > ZombieType.DoorZombie)
			{
				if (theZombieType == ZombieType.RandomZombie || theZombieType == ZombieType.RandomPlusZombie || theZombieType == ZombieType.DiamondRandomZombie)
				{
					break;
				}
			}
			else
			{
				while (theZombieType == ZombieType.NormalZombie)
				{
				}
				if (theZombieType != ZombieType.NormalZombie)
				{
					while (theZombieType == ZombieType.NormalZombie)
					{
					}
					if (theZombieType != ZombieType.NormalZombie)
					{
						while (theZombieType == ZombieType.FlagZombie)
						{
						}
						while (theZombieType == ZombieType.DoorZombie)
						{
						}
					}
				}
			}
			Animator anim = component.anim;
			int num7 = Animator.StringToHash("walk");
			int num8 = 0;
			if (anim.HasState(num8, num7))
			{
				goto Block_17;
			}
		}
		float theOriginSpeed2 = component.theOriginSpeed;
		string text = "walk";
		if (theOriginSpeed2 > 1.2f)
		{
			text = "walk2";
		}
		component.anim.Play(text);
		if (theZombieType == ZombieType.ZombieBoss || theZombieType == ZombieType.ZombieBoss2)
		{
			component.anim.Play("enter");
			component.theOriginSpeed = 1f;
		}
		TravelMgr.Instance.ReinforceZombie(component);
		return component;
		Block_17:
		Animator anim2 = component.anim;
		Debug.LogWarning("尝试地图外面放置僵尸");
		InGameText instance2 = InGameText.Instance;
		IL_03B6:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00031368 File Offset: 0x0002F568
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x905930", Offset = "0x903F30", VA = "0x180905930")]
	public Zombie SetZombieWithMindControl(int theRow, ZombieType theZombieType, float theX = 9.9f, bool withEffect = false)
	{
		Zombie component;
		int num7;
		Animator anim;
		int num8;
		int num9;
		do
		{
			int num = 0;
			int rowNum = this.board.rowNum;
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (!flag)
			{
				goto IL_021F;
			}
			float landY = Mouse.Instance.GetLandY(theX, theRow);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Board board = this.board;
			GameObject gameObject;
			component = gameObject.GetComponent<Zombie>();
			component.subed = true;
			this.SetLayer(theRow, component);
			this.AddToList(component);
			component.theZombieRow = theRow;
			float num2 = global::UnityEngine.Random.Range(1f, 1.4f);
			component.theOriginSpeed = num2;
			Board board2 = this.board;
			component.board = board2;
			component.theZombieType = theZombieType;
			if (LevelManager.TryGetLevelData(num))
			{
			}
			string[] array;
			if (theZombieType > ZombieType.DoorZombie)
			{
				if (theZombieType != ZombieType.RandomZombie && theZombieType != ZombieType.RandomPlusZombie && theZombieType != ZombieType.DiamondRandomZombie)
				{
					goto IL_01A8;
				}
				float theOriginSpeed = component.theOriginSpeed;
				string text = "walk";
				if (theOriginSpeed > 1.2f)
				{
					text = "walk2";
				}
				component.anim.Play(text);
				component.towards = (Towards)((ulong)1L);
				component.isMindControlled = true;
				component.<Team>k__BackingField = (Team)num;
				Transform transform = gameObject.transform;
				int num3 = 0;
				int num4 = 0;
				transform.Rotate((float)num4, 180f, (float)num3);
				int num5 = 0;
				component.UpdateColor((Zombie.ZombieColor)num5);
				int num6 = LayerMask.NameToLayer("Plant");
				gameObject.layer = num6;
				Rigidbody2D rb = component.rb;
				component.InitHealth();
				num7 = component.col.callbackLayers.m_Mask.m_Mask;
				array = new string[1];
			}
			while (array == 0)
			{
			}
			if (array != 0)
			{
				while (array == 0)
				{
				}
				if (array != 0)
				{
					while (array == (ulong)1L)
					{
					}
					while (array == (ulong)8L)
					{
					}
				}
			}
			IL_01A8:
			anim = component.anim;
			num8 = Animator.StringToHash("walk");
			num9 = 0;
		}
		while (!anim.HasState(num9, num8));
		Animator anim2 = component.anim;
		int num10;
		num7 -= num10;
		uint num11;
		GameAPP.PlaySound((int)num11, 0.5f, 1f);
		uint num12;
		GameAPP.PlaySound((int)num12, 0.5f, 1f);
		Transform axis = component.axis;
		Vector3 vector;
		float z = vector.z;
		Debug.LogWarning("尝试地图外面放置僵尸");
		IL_021F:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x000315A0 File Offset: 0x0002F7A0
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x904C80", Offset = "0x903280", VA = "0x180904C80")]
	public void SetLayer(int theRow, Zombie zombie)
	{
		SortingGroup sortingGroup = zombie.AddComponent<SortingGroup>();
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (flag)
		{
			uint num;
			sortingGroup.sortingOrder = (int)num;
			string text = string.Format("zombie{0}", flag);
			sortingGroup.sortingLayerName = text;
		}
		ZombieType theZombieType2 = zombie.theZombieType;
		if (theZombieType2 != ZombieType.ZombieBoss && theZombieType2 != ZombieType.ZombieBoss2)
		{
			int num2 = this.board.theTotalNumOfZombie;
			num2 += num2;
			sortingGroup.sortingOrder = num2;
			string text2 = string.Format("zombie{0}", theZombieType2);
		}
		uint num3;
		sortingGroup.sortingOrder = (int)num3;
		sortingGroup.sortingLayerName = "zombie11";
		zombie.sortingGroup = sortingGroup;
		ulong num4;
		zombie.axis.AddComponent<SortingGroup>().sortAtRoot = num4 != 0UL;
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x0003164C File Offset: 0x0002F84C
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x904E60", Offset = "0x903460", VA = "0x180904E60")]
	private void SetTransform(GameObject zombie, Vector3 position)
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = zombie.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				float z = position.z;
				Transform transform = zombie.transform;
			}
			Vector3 vector;
			if (vector != 0)
			{
			}
		}
		while (num != 0);
		Transform transform2;
		Transform transform3;
		transform2.parentInternal = transform3;
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x000316CC File Offset: 0x0002F8CC
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x903E00", Offset = "0x902400", VA = "0x180903E00")]
	private void AddToList(Zombie zombie)
	{
		Board board = this.board;
		int num = 0;
		int size = board.zombieArray._size;
		List<Zombie> zombieArray = this.board.zombieArray;
		if (num < size)
		{
			Zombie zombie2 = zombieArray[num];
			int num2 = 0;
			bool flag = zombie2 == num2;
			Board board2 = this.board;
			if (!flag)
			{
				num++;
			}
			board2.zombieArray[num] = zombie;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0003173C File Offset: 0x0002F93C
	[Token(Token = "0x600092F")]
	[Address(RVA = "0x904990", Offset = "0x902F90", VA = "0x180904990")]
	private void GetZombieData(Zombie zombie, ZombieType theZombieType, bool isMindControlled = false)
	{
		Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
		bool flag;
		if (flag)
		{
			if (!isMindControlled)
			{
				float zombieHealthMultiplier = this.board.config.zombieHealthMultiplier;
				ZombieType theZombieType2 = zombie.theZombieType;
				int zombieLevel = this.board.boardData.GetZombieLevel();
				zombie.level = (int)((uint)1);
				Board board = this.board;
				if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)1007)))
				{
				}
				Board board2 = this.board;
				zombie.theAttackDamage = board2;
				zombie.theHealth = board2;
				zombie.theMaxHealth = board2;
				zombie.theFirstArmorHealth = board2;
				zombie.theFirstArmorMaxHealth = board2;
				zombie.theSecondArmorHealth = board2;
				zombie.theSecondArmorMaxHealth = board2;
			}
			return;
		}
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x000317F4 File Offset: 0x0002F9F4
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x9048F0", Offset = "0x902EF0", VA = "0x1809048F0")]
	public static ZombieType GetDuckZombie(ZombieType zombieType)
	{
		Dictionary<ZombieType, ZombieType> duckZombies = CreateZombie.DuckZombies;
		throw new NullReferenceException();
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x0003181C File Offset: 0x0002FA1C
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CreateZombie()
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00031830 File Offset: 0x0002FA30
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x906BA0", Offset = "0x9051A0", VA = "0x180906BA0")]
	static CreateZombie()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04000486 RID: 1158
	[Token(Token = "0x4000486")]
	public static CreateZombie Instance;

	// Token: 0x04000487 RID: 1159
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000487")]
	private Board board;

	// Token: 0x04000488 RID: 1160
	[Token(Token = "0x4000488")]
	private static readonly Dictionary<ZombieType, ZombieType> DuckZombies = new Dictionary();
}
