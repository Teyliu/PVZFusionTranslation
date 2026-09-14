using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000638 RID: 1592
[Token(Token = "0x2000638")]
public class BungiZombie : Zombie
{
	// Token: 0x06001E2A RID: 7722 RVA: 0x000A1238 File Offset: 0x0009F438
	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x535350", Offset = "0x533950", VA = "0x180535350", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.BungeeCord.SetActive(true);
		this.attributeCountDown = 2.5f;
		this.theStatus = (ZombieStatus)((ulong)44L);
		this.s.enabled = true;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)20)))
		{
			int num = global::UnityEngine.Random.Range(0, 2);
			if (num == 1)
			{
				this.setZombie = num != 0;
				ZombieType randomBungiType = Lawnf.GetRandomBungiType(false);
				this.theSetZombieType = randomBungiType;
			}
		}
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x000A12AC File Offset: 0x0009F4AC
	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x5367F0", Offset = "0x534DF0", VA = "0x1805367F0")]
	private void Scream()
	{
		List<SoundType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int random = (int)ListExtensions.GetRandom<SoundType>(list);
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x000A12E4 File Offset: 0x0009F4E4
	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x000A12F4 File Offset: 0x0009F4F4
	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x000A1304 File Offset: 0x0009F504
	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x000A1314 File Offset: 0x0009F514
	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0x5352D0", Offset = "0x5338D0", VA = "0x1805352D0", Slot = "23")]
	protected override void AttributeEvent()
	{
		if (!this.setZombie)
		{
			this.anim.SetTrigger("steal");
			return;
		}
		base.ChangeStatus((ZombieStatus)((uint)23));
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x000A134C File Offset: 0x0009F54C
	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x000A135C File Offset: 0x0009F55C
	[Token(Token = "0x6001E31")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x000A136C File Offset: 0x0009F56C
	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x536EA0", Offset = "0x5354A0", VA = "0x180536EA0")]
	public void SetZombie()
	{
		this.setZombie = true;
		ZombieType randomBungiType = Lawnf.GetRandomBungiType(false);
		this.theSetZombieType = randomBungiType;
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x000A1390 File Offset: 0x0009F590
	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x536ED0", Offset = "0x5354D0", VA = "0x180536ED0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.bungeeTarget.SetActive(true);
		if (this.boss)
		{
			this.Scream();
			base.ChangeStatus((ZombieStatus)((uint)23));
			GameObject gameObject = this.bungeeTarget;
			int num = 0;
			gameObject.SetActive(num != 0);
			List<Plant> allPlants = Lawnf.GetAllPlants();
			Predicate<Plant> predicate;
			int num2 = allPlants.RemoveAll(predicate);
			int num3 = allPlants._size;
			num3 = global::UnityEngine.Random.Range(0, num3);
			Plant plant = allPlants[num3];
			int rowNum = this.board.rowNum;
			int num4 = global::UnityEngine.Random.Range(0, rowNum);
			this.theZombieRow = num4;
			Mouse instance = Mouse.Instance;
			int num5 = this.targetColumn;
			float boxXFromColumn = instance.GetBoxXFromColumn(num5);
			Mouse instance2 = Mouse.Instance;
			int theZombieRow = this.theZombieRow;
			float landY = instance2.GetLandY(boxXFromColumn, theZombieRow);
			this.target = boxXFromColumn;
			this.target.y = landY;
			this.startY = 10f;
			this.MoveToTarget();
			return;
		}
		int num6 = 0;
		int num7;
		if ((this.setZombie ? 1 : 0) != num6)
		{
			base.Invoke("Scream", 1f);
			num7 = 0;
			this.GetZombiePlace();
		}
		base.Invoke(num7, 1f);
		this.SetTarget();
		throw new NullReferenceException();
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x000A14CC File Offset: 0x0009F6CC
	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x535A10", Offset = "0x534010", VA = "0x180535A10")]
	private void GetZombiePlace()
	{
		this.anim.Play("setzombie");
		GameObject gameObject = this.bungeeTarget;
		this.attributeCountDown = 1.5f;
		int num = 0;
		gameObject.SetActive(num != 0);
		int columnNum = this.board.columnNum;
		int num2 = global::UnityEngine.Random.Range(3, columnNum);
		Board board = this.board;
		this.targetColumn = num2;
		int rowNum = board.rowNum;
		int num3 = global::UnityEngine.Random.Range(0, rowNum);
		this.theZombieRow = num3;
		GridSystem gridSystem = this.board.gridSystem;
		int theZombieRow = this.theZombieRow;
		int num4 = this.targetColumn;
		if (gridSystem.GetGrid(num4, theZombieRow).boxType == BoxType.Water && (uint)100 > 0U)
		{
			int columnNum2 = this.board.columnNum;
			int num5 = global::UnityEngine.Random.Range(3, columnNum2);
			Board board2 = this.board;
			this.targetColumn = num5;
			int rowNum2 = board2.rowNum;
			int num6 = global::UnityEngine.Random.Range(0, rowNum2);
			this.theZombieRow = num6;
			Board board3 = this.board;
		}
		Mouse instance = Mouse.Instance;
		int num7 = this.targetColumn;
		float boxXFromColumn = instance.GetBoxXFromColumn(num7);
		Mouse instance2 = Mouse.Instance;
		int theZombieRow2 = this.theZombieRow;
		float boxYFromRow = instance2.GetBoxYFromRow(theZombieRow2);
		this.target = boxXFromColumn;
		this.target.y = boxYFromRow;
		this.MoveToTarget();
		ZombieType zombieType = this.theSetZombieType;
		Transform transform = base.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject2;
		this.preZombie = gameObject2;
		throw new NullReferenceException();
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x000A1644 File Offset: 0x0009F844
	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x5350A0", Offset = "0x5336A0", VA = "0x1805350A0")]
	private void AnimPutZombie()
	{
		global::UnityEngine.Object.Destroy(this.preZombie);
		int num = 0;
		this.preZombie = num;
		CreateZombie instance = CreateZombie.Instance;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			this.board.SetHealthInTravel(zombie);
			Board board = this.board;
			Dictionary<int, List<Zombie>> waveZombies = board.boardEntity.waveZombies;
			int theWave = board.theWave;
			if (waveZombies.ContainsKey(theWave))
			{
				Board board2 = this.board;
				Dictionary<int, List<Zombie>> waveZombies2 = board2.boardEntity.waveZombies;
				int theWave2 = board2.theWave;
				int size = waveZombies2[theWave2]._size;
				zombie.<Team>k__BackingField = zombie;
			}
		}
		base.ChangeStatus((ZombieStatus)((uint)24));
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000A16F4 File Offset: 0x0009F8F4
	[Token(Token = "0x6001E36")]
	[Address(RVA = "0x535990", Offset = "0x533F90", VA = "0x180535990", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		bool flag;
		if (flag)
		{
			ulong num;
			num += num;
		}
		int num2;
		return num2;
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x000A1710 File Offset: 0x0009F910
	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x5373A0", Offset = "0x5359A0", VA = "0x1805373A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (!this.setZombie)
		{
			this.BungeeTargetPositonUpdate();
		}
		Transform transform = this.s.transform;
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x000A1748 File Offset: 0x0009F948
	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x000A1768 File Offset: 0x0009F968
	[Token(Token = "0x6001E39")]
	[Address(RVA = "0x5369E0", Offset = "0x534FE0", VA = "0x1805369E0")]
	private void SetTarget()
	{
		List<Plant> list;
		int num2;
		do
		{
			int num = 0;
			Board board = this.board;
			list = new List();
			num2 = 0;
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !this.Stealable(num))
				{
					continue;
				}
				num2++;
			}
		}
		while (num2 != 0);
		if (num2 == 1)
		{
			Predicate<Plant> predicate;
			if (BungiZombie.<>c.<>9__28_0 == 0)
			{
				BungiZombie.<>c.<>9__28_0 = predicate;
			}
			int num4 = list.RemoveAll(predicate);
		}
		int num5 = list._size;
		num5 = global::UnityEngine.Random.Range(0, num5);
		Plant plant = list[num5];
		Transform axis = plant.axis;
		int thePlantRow = plant.thePlantRow;
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000A1870 File Offset: 0x0009FA70
	[Token(Token = "0x6001E3A")]
	[Address(RVA = "0x535CE0", Offset = "0x5342E0", VA = "0x180535CE0")]
	private void MoveToTarget()
	{
		int num = 0;
		SortingGroup sortingGroup = this.sortingGroup;
		int theZombieRow = this.theZombieRow;
		string text = string.Format("pumpkinback{0}", theZombieRow);
		sortingGroup.sortingLayerName = text;
		this.sortingGroup.sortingOrder = -10000;
		List<SortingGroup> list = this.hands;
		bool flag;
		if (flag)
		{
			int theZombieRow2 = this.theZombieRow;
			string text2 = string.Format("zombie{0}", theZombieRow2);
		}
		if (num == 0)
		{
			Transform transform;
			transform.position = num;
			bool flag2;
			if (!flag2)
			{
			}
			SortingGroup sortingGroup2;
			sortingGroup2.sortAtRoot = true;
			string text3 = string.Format("particle{0}", sortingGroup2);
			sortingGroup2.sortingLayerName = text3;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000A1960 File Offset: 0x0009FB60
	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x535450", Offset = "0x533A50", VA = "0x180535450")]
	private void BungeeTargetPositonUpdate()
	{
		if (!this.targetLand)
		{
			Transform transform = this.bungeeTarget.transform;
			Vector3 vector;
			float y = vector.y;
			Transform transform2 = this.bungeeTarget.transform;
			float num = this.moveSpeed;
			float deltaTime = Time.deltaTime;
			Transform transform3 = this.bungeeTarget.transform;
			float y2 = this.target.y;
			Transform transform4 = this.bungeeTarget.transform;
			GameAPP.PlaySound(50, 0.5f, 1f);
			this.targetLand = true;
			if (!this.targetLand)
			{
				return;
			}
		}
		Transform transform5 = this.bungeeTarget.transform;
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x000A1A08 File Offset: 0x0009FC08
	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x5371B0", Offset = "0x5357B0", VA = "0x1805371B0")]
	private bool Stealable(Plant plant)
	{
		ulong num2;
		do
		{
			int num = 0;
			if (plant.plantTag != num || plant.GetComponent<Pot>().carry)
			{
				goto IL_0051;
			}
			if (!plant.isLily)
			{
				break;
			}
			int thePlantRow = plant.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(plant.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				while (plant.plantTag != (ulong)0L)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
		return true;
		IL_0051:
		throw new NullReferenceException();
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x000A1A78 File Offset: 0x0009FC78
	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x536100", Offset = "0x534700", VA = "0x180536100", Slot = "21")]
	protected override void PositionUpdate()
	{
		Transform transform = base.transform;
		float num = this.moveSpeed;
		float deltaTime = Time.deltaTime;
		float num2 = num * 1.3f;
		Transform transform2 = this.s.transform;
		float num3 = Time.deltaTime;
		num2 = num3;
		num3 = num2 * 2.6f;
		Transform axis = this.axis;
		if (transform2.position.y > this.startY)
		{
			int num4 = 0;
			this.Die(num4);
			int num5 = 0;
			if ((this.setZombie ? 1 : 0) != num5)
			{
				Transform transform3 = base.transform;
				float num6 = this.moveSpeed;
				float deltaTime2 = Time.deltaTime;
				float num7 = num6 * 1.2f;
				Transform transform4 = this.s.transform;
				num7 = Time.deltaTime;
				float num8 = num7 * 2.4f;
				Transform axis2 = this.axis;
				Vector3 position = transform4.position;
				if (this.target.y <= position.y)
				{
					Transform axis3 = this.axis;
					Vector3 position2 = transform4.position;
					if (this.target.y > position2.y)
					{
						goto IL_01B2;
					}
				}
				if (this.FindUmbrella())
				{
					goto IL_01ED;
				}
				this.AnimPutZombie();
			}
			Transform transform5 = base.transform;
			float num9 = this.moveSpeed;
			float deltaTime3 = Time.deltaTime;
			float num10 = num9 * 0.9f;
			Transform transform6 = this.s.transform;
			num10 = Time.deltaTime;
			float num11 = num10 * 1.8f;
			Transform axis4 = this.axis;
			Vector3 position3 = transform6.position;
			if (this.target.y > position3.y)
			{
				goto IL_01BA;
			}
			Transform axis5 = this.axis;
			Vector3 position4 = transform6.position;
			if (this.target.y <= position4.y)
			{
				goto IL_01ED;
			}
			IL_01B2:
			bool flag = this.FindUmbrella();
			IL_01BA:
			if (!this.FindUmbrella())
			{
				int num12 = 0;
				base.ChangeStatus((ZombieStatus)num12);
				Animator anim = this.anim;
				this.attributeCountDown = 3f;
				anim.Play("idle");
			}
		}
		IL_01ED:
		Transform transform7 = this.s.transform;
		Transform transform8 = this.s.transform;
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x000A1C94 File Offset: 0x0009FE94
	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x5356E0", Offset = "0x533CE0", VA = "0x1805356E0")]
	private bool FindUmbrella()
	{
		int num;
		for (;;)
		{
			num = 0;
			int num2 = 0;
			int theZombieRow = this.theZombieRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.targetColumn, theZombieRow);
			bool flag;
			if (flag)
			{
				break;
			}
			if (num2 == 0)
			{
				goto Block_2;
			}
		}
		bool flag2;
		if (!flag2 || num != 0)
		{
		}
		int num3 = this.targetColumn;
		int theZombieRow2 = this.theZombieRow;
		return true;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x000A1D08 File Offset: 0x0009FF08
	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0x535440", Offset = "0x533A40", VA = "0x180535440", Slot = "74")]
	public virtual void Blocked()
	{
		base.ChangeStatus((ZombieStatus)((uint)24));
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000A1D20 File Offset: 0x0009FF20
	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x534DF0", Offset = "0x5333F0", VA = "0x180534DF0")]
	private void AnimCatch()
	{
		int num = this.theZombieRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.targetColumn, num);
		int size = list._size;
		int num2 = size - 1;
		if (size > 0)
		{
			num = num2;
			Plant plant = list[num];
			if (!this.Stealable(plant))
			{
				list.RemoveAt(num2);
			}
		}
		int num3 = list._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		Plant plant2 = list[num3];
		plant2.Die((Plant.DieReason)((uint)5));
		Transform transform = plant2.transform;
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		bool flag;
		SortingGroup sortingGroup;
		if (!flag)
		{
			sortingGroup = plant2.AddComponent<SortingGroup>();
		}
		string sortingLayerName = this.sortingGroup.sortingLayerName;
		sortingGroup.sortingLayerName = sortingLayerName;
		sortingGroup.sortingOrder = 26;
		GameAPP.PlaySound(62, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(this.bungeeTarget.GetComponent<SpriteRenderer>());
		Collider2D col = this.col;
		int num4 = 0;
		col.enabled = num4 != 0;
		base.ChangeStatus((ZombieStatus)((uint)24));
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000A1E24 File Offset: 0x000A0024
	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000A1E34 File Offset: 0x000A0034
	[Token(Token = "0x6001E42")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "40")]
	protected override void OnTriggerExit2D(Collider2D collision)
	{
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x000A1E44 File Offset: 0x000A0044
	[Token(Token = "0x6001E43")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "42")]
	protected override void CancelAttack()
	{
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000A1E54 File Offset: 0x000A0054
	[Token(Token = "0x6001E44")]
	[Address(RVA = "0x537420", Offset = "0x535A20", VA = "0x180537420")]
	public BungiZombie()
	{
		List<SortingGroup> list = new List();
		this.hands = list;
		base..ctor();
	}

	// Token: 0x0400103C RID: 4156
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400103C")]
	public GameObject BungeeCord;

	// Token: 0x0400103D RID: 4157
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400103D")]
	public GameObject bungeeTarget;

	// Token: 0x0400103E RID: 4158
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400103E")]
	public ZombieBoss boss;

	// Token: 0x0400103F RID: 4159
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400103F")]
	public int targetColumn;

	// Token: 0x04001040 RID: 4160
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4001040")]
	private Vector2 target;

	// Token: 0x04001041 RID: 4161
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4001041")]
	private readonly float moveSpeed = 12f;

	// Token: 0x04001042 RID: 4162
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001042")]
	private float startY = 14f;

	// Token: 0x04001043 RID: 4163
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4001043")]
	private bool targetLand;

	// Token: 0x04001044 RID: 4164
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001044")]
	public List<SortingGroup> hands;

	// Token: 0x04001045 RID: 4165
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001045")]
	public SpriteRenderer s;

	// Token: 0x04001046 RID: 4166
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001046")]
	public bool setZombie;

	// Token: 0x04001047 RID: 4167
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4001047")]
	public ZombieType theSetZombieType;

	// Token: 0x04001048 RID: 4168
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001048")]
	private GameObject preZombie;
}
