using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000236 RID: 566
[Token(Token = "0x2000236")]
public class ScaryPot : GridItem
{
	// Token: 0x060009F1 RID: 2545 RVA: 0x000360F8 File Offset: 0x000342F8
	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x885830", Offset = "0x883E30", VA = "0x180885830")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00036114 File Offset: 0x00034314
	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x886F30", Offset = "0x885530", VA = "0x180886F30")]
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

	// Token: 0x060009F3 RID: 2547 RVA: 0x00036148 File Offset: 0x00034348
	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x886F50", Offset = "0x885550", VA = "0x180886F50")]
	private void Update()
	{
		Board board = this.board;
		Animator animator = this.anim;
		int theItemRow = this.theItemRow;
		List<Plant> list = global::Lawnf.Get3x3Plants(this.theItemColumn, theItemRow);
		Func<Plant, bool> <>9__6_ = ScaryPot.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			Func<Plant, bool> func;
			ScaryPot.<>c.<>9__6_0 = func;
		}
		bool flag = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__6_));
		animator.SetBool("show", flag);
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x000361B4 File Offset: 0x000343B4
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x885880", Offset = "0x883E80", VA = "0x180885880")]
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

	// Token: 0x060009F5 RID: 2549 RVA: 0x00036214 File Offset: 0x00034414
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x885A90", Offset = "0x884090", VA = "0x180885A90")]
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
					Func<Plant, bool> func;
					ScaryPot.<>c.<>9__8_0 = func;
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
				goto IL_00CF;
			}
			if (this.theZombieType != ZombieType.Nothing)
			{
				CreateZombie instance = CreateZombie.Instance;
				ZombieType zombieType = this.theZombieType;
				Transform transform = base.transform;
				Zombie zombie;
				if (zombie.read == num)
				{
				}
				CreateZombie instance2 = CreateZombie.Instance;
				ZombieType zombieType2 = this.theZombieType;
				Transform transform2 = base.transform;
				goto IL_00CF;
			}
			IL_0156:
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
			IL_00CF:
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
			goto IL_0156;
		}
		InGameText instance4 = InGameText.Instance;
		int num9 = 0;
		instance4.ShowText("该格子已被标记，若想扫雷请移除上方的植物", 5f, num9 != 0);
		return;
		Block_11:
		throw new NullReferenceException();
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x000364AC File Offset: 0x000346AC
	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x8857E0", Offset = "0x883DE0", VA = "0x1808857E0")]
	private IEnumerator AllHit()
	{
		ScaryPot.<AllHit>d__9 <AllHit>d__;
		<AllHit>d__.System.IDisposable.Dispose();
		<AllHit>d__.<>1__state = (int)((ulong)0L);
		return null;
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x000364CC File Offset: 0x000346CC
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x886C90", Offset = "0x885290", VA = "0x180886C90")]
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

	// Token: 0x060009F8 RID: 2552 RVA: 0x00036534 File Offset: 0x00034734
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x886770", Offset = "0x884D70", VA = "0x180886770")]
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

	// Token: 0x060009F9 RID: 2553 RVA: 0x000365FC File Offset: 0x000347FC
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x886430", Offset = "0x884A30", VA = "0x180886430")]
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

	// Token: 0x060009FA RID: 2554 RVA: 0x0003667C File Offset: 0x0003487C
	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x887180", Offset = "0x885780", VA = "0x180887180")]
	public ScaryPot()
	{
	}

	// Token: 0x04000549 RID: 1353
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000549")]
	public PlantType thePlantType = (PlantType)((ulong)(-1L));

	// Token: 0x0400054A RID: 1354
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400054A")]
	public ZombieType theZombieType;

	// Token: 0x0400054B RID: 1355
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400054B")]
	private Animator anim;

	// Token: 0x0400054C RID: 1356
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400054C")]
	private bool hit;

	// Token: 0x0400054D RID: 1357
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400054D")]
	public SpriteRenderer iconSprite;

	// Token: 0x0400054E RID: 1358
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400054E")]
	public SpriteRenderer back;
}
