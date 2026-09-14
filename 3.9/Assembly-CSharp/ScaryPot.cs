using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200023C RID: 572
[Token(Token = "0x200023C")]
public class ScaryPot : GridItem
{
	// Token: 0x06000A0C RID: 2572 RVA: 0x00036000 File Offset: 0x00034200
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x9152F0", Offset = "0x9138F0", VA = "0x1809152F0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x0003601C File Offset: 0x0003421C
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x916A00", Offset = "0x915000", VA = "0x180916A00")]
	private void Start()
	{
		if (this.thePlantType == PlantType.Nothing)
		{
			ZombieType zombieType = this.theZombieType;
			this.SetTheSprite(zombieType);
			return;
		}
		PlantType plantType = this.thePlantType;
		this.SetTheSprite(plantType);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00036050 File Offset: 0x00034250
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x916A20", Offset = "0x915020", VA = "0x180916A20")]
	private void Update()
	{
		Board board = this.board;
		Animator animator = this.anim;
		int theItemRow = this.theItemRow;
		List<Plant> list = global::Lawnf.Get3x3Plants(this.theItemColumn, theItemRow);
		Func<Plant, bool> <>9__6_ = ScaryPot.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			ScaryPot.<>c.<>9__6_0 = delegate(Plant p)
			{
				int num = (int)p.thePlantType;
				bool flag2;
				return flag2;
			};
		}
		bool flag = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__6_));
		animator.SetBool("show", flag);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x000360C8 File Offset: 0x000342C8
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x915340", Offset = "0x913940", VA = "0x180915340")]
	public void Hitted()
	{
		GameObject gameObject = Resources.Load<GameObject>("_Other/GameHammer/Hammer");
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = base.transform;
		GameAPP.PlaySound(93, 0.5f, 1f);
		base.Invoke("OnHitted", 0.25f);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00036128 File Offset: 0x00034328
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x915550", Offset = "0x913B50", VA = "0x180915550")]
	public void OnHitted()
	{
		for (;;)
		{
			int num = 0;
			if (base.TryGetComponent<MinesweeperCell>(num))
			{
				int theItemRow = this.theItemRow;
				List<Plant> list = global::Lawnf.Get1x1Plants(this.theItemColumn, theItemRow);
				Func<Plant, bool> <>9__8_ = ScaryPot.<>c.<>9__8_0;
				if (<>9__8_ == 0)
				{
					ScaryPot.<>c.<>9__8_0 = delegate(Plant p)
					{
						Plant.PlantTag plantTag = p.plantTag;
						throw new NullReferenceException();
					};
				}
				if (Enumerable.FirstOrDefault<Plant>(list, <>9__8_))
				{
					break;
				}
			}
			while ((this.hit ? 1 : 0) != num)
			{
			}
			this.hit = true;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			if (this.thePlantType != PlantType.Nothing)
			{
				goto IL_00C7;
			}
			if (this.theZombieType != ZombieType.Nothing)
			{
				CreateZombie instance = CreateZombie.Instance;
				ZombieType zombieType = this.theZombieType;
				Transform transform = base.transform;
				Zombie zombie;
				if (zombie.takeDmgMultiplier == (float)num)
				{
				}
				CreateZombie instance2 = CreateZombie.Instance;
				ZombieType zombieType2 = this.theZombieType;
				Transform transform2 = base.transform;
				goto IL_00C7;
			}
			IL_014E:
			base.Die();
			if (global::Lawnf.GetScaryPotNum(this.board) == 0)
			{
				Board board = this.board;
				ScaryPot.<AllHit>d__9 <AllHit>d__;
				<AllHit>d__.System.IDisposable.Dispose();
				<AllHit>d__.<>1__state = num;
				Coroutine coroutine = board.StartCoroutine(<AllHit>d__);
			}
			Transform transform3 = base.transform;
			int num3 = 0;
			GameObject gameObject = transform3.GetChild(num3).gameObject;
			ulong num4;
			gameObject.SetActive(num4 != 0UL);
			Transform transform4 = gameObject.transform;
			Transform transform5 = this.board.transform;
			transform4.parentInternal = transform5;
			SortingGroup component = gameObject.GetComponent<SortingGroup>();
			int theItemRow2 = this.theItemRow;
			string text = string.Format("particle{0}", component);
			component.sortingLayerName = text;
			ulong num5;
			gameObject.GetComponent<SortingGroup>().enabled = num5 != 0UL;
			if (gameObject.transform.GetEnumerator() == 0)
			{
				continue;
			}
			if (num < typeof(IEnumerator).TypeHandle)
			{
				num += num;
				num++;
			}
			ParticleSystem particleSystem;
			ParticleSystem.MainModule main = particleSystem.main;
			List<Transform> plane = this.board.plane;
			int theItemRow3 = this.theItemRow;
			if (plane[theItemRow3] != 0)
			{
			}
			if (num == 0)
			{
				goto Block_11;
			}
			continue;
			IL_00C7:
			int num6 = 0;
			if (!(num != num6))
			{
				Transform transform6 = base.transform;
				Vector3 vector;
				float z = vector.z;
				Action<Plant> action;
				if (ScaryPot.<>c.<>9__8_1 == 0)
				{
					ScaryPot.<>c.<>9__8_1 = action;
				}
				DroppedCard droppedCard;
				droppedCard.plantAction = action;
			}
			CreatePlant instance3 = CreatePlant.Instance;
			PlantType plantType = this.thePlantType;
			int theItemRow4 = this.theItemRow;
			int theItemColumn = this.theItemColumn;
			ulong num7;
			ulong num8;
			Plant plant = instance3.SetPlant(theItemColumn, theItemRow4, plantType, num, num, num7 != 0UL, num8 != 0UL, num);
			plant.thePlantHealth = instance3;
			plant.thePlantMaxHealth = num;
			plant.UpdateText();
			goto IL_014E;
		}
		InGameText instance4 = InGameText.Instance;
		return;
		Block_11:
		throw new NullReferenceException();
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x000363B8 File Offset: 0x000345B8
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x9152A0", Offset = "0x9138A0", VA = "0x1809152A0")]
	private IEnumerator AllHit()
	{
		ScaryPot.<AllHit>d__9 <AllHit>d__;
		<AllHit>d__.System.IDisposable.Dispose();
		<AllHit>d__.<>1__state = (int)((ulong)0L);
		return null;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x000363D8 File Offset: 0x000345D8
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x916760", Offset = "0x914D60", VA = "0x180916760")]
	public void SetTheSprite(PlantType thePlantType)
	{
		Transform transform = this.back.transform;
		Sprite sprite = this.back.sprite;
		Transform transform2 = this.back.transform;
		Sprite sprite2 = this.back.sprite;
		Transform transform3 = this.back.transform;
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		SpriteRenderer spriteRenderer;
		Sprite sprite3 = spriteRenderer.sprite;
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00036440 File Offset: 0x00034640
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x916240", Offset = "0x914840", VA = "0x180916240")]
	public void SetTheSprite(ZombieType theZombieType)
	{
		Transform transform = this.back.transform;
		Vector3 vector;
		float z = vector.z;
		Sprite sprite = this.back.sprite;
		Transform transform2 = this.back.transform;
		Sprite sprite2 = this.back.sprite;
		Transform transform3 = this.back.transform;
		Dictionary<ZombieType, Sprite> zombieSprites = GameAPP.resourcesManager.zombieSprites;
		SpriteRenderer spriteRenderer = this.iconSprite;
		bool flag;
		if (!flag)
		{
			float num;
			if (num < num)
			{
			}
			Transform transform4 = this.iconSprite.transform;
			SpriteRenderer spriteRenderer2 = this.iconSprite;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform5 = spriteRenderer2.transform;
			Transform transform6 = this.iconSprite.transform;
			Transform transform7 = this.iconSprite.transform;
			Vector3 vector3;
			float z3 = vector3.z;
		}
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00036508 File Offset: 0x00034708
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x915F00", Offset = "0x914500", VA = "0x180915F00")]
	private void SetSprite(Sprite sprite, float minX, float maxX, float minY, float maxY)
	{
		this.iconSprite.sprite = sprite;
		int num = 0;
		if (!(sprite == num))
		{
			Transform transform = this.iconSprite.transform;
			SpriteRenderer spriteRenderer = this.iconSprite;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = spriteRenderer.transform;
			Vector2 pivot = sprite.pivot;
			Transform transform3 = this.iconSprite.transform;
			Transform transform4 = this.iconSprite.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00036588 File Offset: 0x00034788
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x916C50", Offset = "0x915250", VA = "0x180916C50")]
	public ScaryPot()
	{
	}

	// Token: 0x04000554 RID: 1364
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000554")]
	public PlantType thePlantType = (PlantType)((ulong)(-1L));

	// Token: 0x04000555 RID: 1365
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000555")]
	public ZombieType theZombieType;

	// Token: 0x04000556 RID: 1366
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000556")]
	private Animator anim;

	// Token: 0x04000557 RID: 1367
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000557")]
	private bool hit;

	// Token: 0x04000558 RID: 1368
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000558")]
	public SpriteRenderer iconSprite;

	// Token: 0x04000559 RID: 1369
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000559")]
	public SpriteRenderer back;
}
