using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200066E RID: 1646
[Token(Token = "0x200066E")]
public class BungiZombie : Zombie
{
	// Token: 0x06001F2C RID: 7980 RVA: 0x000A5988 File Offset: 0x000A3B88
	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x58C030", Offset = "0x58A630", VA = "0x18058C030", Slot = "10")]
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

	// Token: 0x06001F2D RID: 7981 RVA: 0x000A59FC File Offset: 0x000A3BFC
	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x58D4D0", Offset = "0x58BAD0", VA = "0x18058D4D0")]
	private void Scream()
	{
		List<SoundType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int random = (int)ListExtensions.GetRandom<SoundType>(list);
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x000A5A34 File Offset: 0x000A3C34
	[Token(Token = "0x6001F2E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x000A5A44 File Offset: 0x000A3C44
	[Token(Token = "0x6001F2F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x000A5A54 File Offset: 0x000A3C54
	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000A5A64 File Offset: 0x000A3C64
	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x58BFB0", Offset = "0x58A5B0", VA = "0x18058BFB0", Slot = "24")]
	protected override void AttributeEvent()
	{
		if (!this.setZombie)
		{
			this.anim.SetTrigger("steal");
			return;
		}
		base.ChangeStatus((ZombieStatus)((uint)23));
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x000A5A9C File Offset: 0x000A3C9C
	[Token(Token = "0x6001F32")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x000A5AAC File Offset: 0x000A3CAC
	[Token(Token = "0x6001F33")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x000A5ABC File Offset: 0x000A3CBC
	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x58DB80", Offset = "0x58C180", VA = "0x18058DB80")]
	public void SetZombie()
	{
		this.setZombie = true;
		ZombieType randomBungiType = Lawnf.GetRandomBungiType(false);
		this.theSetZombieType = randomBungiType;
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x000A5AE0 File Offset: 0x000A3CE0
	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x58DBB0", Offset = "0x58C1B0", VA = "0x18058DBB0", Slot = "16")]
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

	// Token: 0x06001F36 RID: 7990 RVA: 0x000A5C1C File Offset: 0x000A3E1C
	[Token(Token = "0x6001F36")]
	[Address(RVA = "0x58C6F0", Offset = "0x58ACF0", VA = "0x18058C6F0")]
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

	// Token: 0x06001F37 RID: 7991 RVA: 0x000A5D94 File Offset: 0x000A3F94
	[Token(Token = "0x6001F37")]
	[Address(RVA = "0x58BD80", Offset = "0x58A380", VA = "0x18058BD80")]
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

	// Token: 0x06001F38 RID: 7992 RVA: 0x000A5E44 File Offset: 0x000A4044
	[Token(Token = "0x6001F38")]
	[Address(RVA = "0x58C670", Offset = "0x58AC70", VA = "0x18058C670", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		bool flag;
		if (flag)
		{
			ulong num;
			num += num;
		}
		long num2;
		return num2;
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x000A5E60 File Offset: 0x000A4060
	[Token(Token = "0x6001F39")]
	[Address(RVA = "0x58E080", Offset = "0x58C680", VA = "0x18058E080", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		if (!this.setZombie)
		{
			this.BungeeTargetPositonUpdate();
		}
		Transform transform = this.s.transform;
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x000A5E98 File Offset: 0x000A4098
	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000A5EB8 File Offset: 0x000A40B8
	[Token(Token = "0x6001F3B")]
	[Address(RVA = "0x58D6C0", Offset = "0x58BCC0", VA = "0x18058D6C0")]
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

	// Token: 0x06001F3C RID: 7996 RVA: 0x000A5FC0 File Offset: 0x000A41C0
	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x58C9C0", Offset = "0x58AFC0", VA = "0x18058C9C0")]
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

	// Token: 0x06001F3D RID: 7997 RVA: 0x000A60B0 File Offset: 0x000A42B0
	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0x58C130", Offset = "0x58A730", VA = "0x18058C130")]
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

	// Token: 0x06001F3E RID: 7998 RVA: 0x000A6158 File Offset: 0x000A4358
	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0x58DE90", Offset = "0x58C490", VA = "0x18058DE90")]
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

	// Token: 0x06001F3F RID: 7999 RVA: 0x000A61C8 File Offset: 0x000A43C8
	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0x58CDE0", Offset = "0x58B3E0", VA = "0x18058CDE0", Slot = "22")]
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

	// Token: 0x06001F40 RID: 8000 RVA: 0x000A63E4 File Offset: 0x000A45E4
	[Token(Token = "0x6001F40")]
	[Address(RVA = "0x58C3C0", Offset = "0x58A9C0", VA = "0x18058C3C0")]
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

	// Token: 0x06001F41 RID: 8001 RVA: 0x000A6458 File Offset: 0x000A4658
	[Token(Token = "0x6001F41")]
	[Address(RVA = "0x58C120", Offset = "0x58A720", VA = "0x18058C120", Slot = "76")]
	public virtual void Blocked()
	{
		base.ChangeStatus((ZombieStatus)((uint)24));
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x000A6470 File Offset: 0x000A4670
	[Token(Token = "0x6001F42")]
	[Address(RVA = "0x58BAD0", Offset = "0x58A0D0", VA = "0x18058BAD0")]
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

	// Token: 0x06001F43 RID: 8003 RVA: 0x000A6574 File Offset: 0x000A4774
	[Token(Token = "0x6001F43")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x000A6584 File Offset: 0x000A4784
	[Token(Token = "0x6001F44")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "42")]
	protected override void OnTriggerExit2D(Collider2D collision)
	{
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x000A6594 File Offset: 0x000A4794
	[Token(Token = "0x6001F45")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "44")]
	protected override void CancelAttack()
	{
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x000A65A4 File Offset: 0x000A47A4
	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x58E100", Offset = "0x58C700", VA = "0x18058E100")]
	public BungiZombie()
	{
		List<SortingGroup> list = new List();
		this.hands = list;
		base..ctor();
	}

	// Token: 0x04001108 RID: 4360
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001108")]
	public GameObject BungeeCord;

	// Token: 0x04001109 RID: 4361
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001109")]
	public GameObject bungeeTarget;

	// Token: 0x0400110A RID: 4362
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400110A")]
	public ZombieBoss boss;

	// Token: 0x0400110B RID: 4363
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400110B")]
	public int targetColumn;

	// Token: 0x0400110C RID: 4364
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x400110C")]
	private Vector2 target;

	// Token: 0x0400110D RID: 4365
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x400110D")]
	private readonly float moveSpeed = 12f;

	// Token: 0x0400110E RID: 4366
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x400110E")]
	private float startY = 14f;

	// Token: 0x0400110F RID: 4367
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x400110F")]
	private bool targetLand;

	// Token: 0x04001110 RID: 4368
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4001110")]
	public List<SortingGroup> hands;

	// Token: 0x04001111 RID: 4369
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4001111")]
	public SpriteRenderer s;

	// Token: 0x04001112 RID: 4370
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4001112")]
	public bool setZombie;

	// Token: 0x04001113 RID: 4371
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x4001113")]
	public ZombieType theSetZombieType;

	// Token: 0x04001114 RID: 4372
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4001114")]
	private GameObject preZombie;
}
