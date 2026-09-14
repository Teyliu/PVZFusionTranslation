using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000278 RID: 632
[Token(Token = "0x2000278")]
public class MiniPet : MonoBehaviour, IDamageMaker
{
	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000408E0 File Offset: 0x0003EAE0
	// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000408F4 File Offset: 0x0003EAF4
	[Token(Token = "0x170000D2")]
	public virtual float Damage
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x3FC6D0", Offset = "0x3FACD0", VA = "0x1803FC6D0", Slot = "7")]
		get
		{
			return this.damage;
		}
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x3FC6E0", Offset = "0x3FACE0", VA = "0x1803FC6E0", Slot = "8")]
		set
		{
			this.damage = value;
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00040908 File Offset: 0x0003EB08
	// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00040920 File Offset: 0x0003EB20
	[Token(Token = "0x170000D3")]
	public Team Team
	{
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x9374A0", Offset = "0x935AA0", VA = "0x1809374A0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00040934 File Offset: 0x0003EB34
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "9")]
	protected virtual void AnimAttack()
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00040944 File Offset: 0x0003EB44
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "10")]
	protected virtual void PetUpdate()
	{
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00040954 File Offset: 0x0003EB54
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x9357C0", Offset = "0x933DC0", VA = "0x1809357C0", Slot = "11")]
	protected virtual void AttackReady(bool moveOver)
	{
		float num = this.attackInterval;
		this.attackTimer = num;
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00040970 File Offset: 0x0003EB70
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	protected virtual void AttributeEvent()
	{
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00040980 File Offset: 0x0003EB80
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x936840", Offset = "0x934E40", VA = "0x180936840", Slot = "13")]
	protected virtual void PositionUpdate()
	{
		this.LayerUpdate();
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float y = this.targetPosition.y;
		float num = Time.deltaTime * 5f;
		if (0 == 0)
		{
		}
		Vector2 vector = this.targetPosition;
		Transform transform3 = base.transform;
		int num2 = 0;
		Transform transform4 = base.transform;
		Transform transform5;
		transform5.rotation = num2;
		Transform transform6 = base.transform;
		int num3 = 0;
		base.transform.position = num3;
		Vector2Int vector2Int = this.targetGrid;
		this.thePetColumn = vector2Int;
		int y2 = this.targetGrid.m_Y;
		this.thePetRow = y2;
		this.moving = false;
		this.AttackReady(true);
		int num4 = 0;
		base.transform.rotation = num4;
		Animator animator = this.anim;
		bool flag = this.moving;
		animator.SetBool("walking", flag);
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00040A6C File Offset: 0x0003EC6C
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x936230", Offset = "0x934830", VA = "0x180936230", Slot = "14")]
	protected virtual void PlayerPositionUpdate()
	{
		this.LayerUpdate();
		if (!this.holdOn)
		{
			this.moving = false;
		}
		bool key = Lawnf.GetKey((KeyCode)((uint)119));
		int num = 0;
		if (key)
		{
			Transform transform = base.transform;
			int num2 = 0;
			Vector3 vector;
			float num3 = vector.y;
			if (Lawnf.GetBoxYFromRow(num2, 5) > num3)
			{
				this.moving = true;
				Transform transform2 = base.transform;
				num3 = Time.deltaTime;
				this.holdOn = num != 0;
				this.holdTimer = (float)num;
			}
		}
		if (Lawnf.GetKey((KeyCode)((uint)97)))
		{
			Transform transform3 = base.transform;
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
			this.moving = true;
			Transform transform4 = base.transform;
			float deltaTime = Time.deltaTime;
			int num4 = 0;
			base.transform.rotation = num4;
			this.holdOn = num != 0;
			this.holdTimer = (float)num;
		}
		if (Lawnf.GetKey((KeyCode)((uint)115)))
		{
			Transform transform5 = base.transform;
			Board board = this.board;
			Vector3 vector2;
			float num5 = vector2.y;
			float boxYFromRow = Lawnf.GetBoxYFromRow(board.rowNum, 5);
			if (num5 > boxYFromRow)
			{
				this.moving = true;
				Transform transform6 = base.transform;
				num5 = Time.deltaTime;
				this.holdOn = num != 0;
				this.holdTimer = (float)num;
			}
		}
		if (Lawnf.GetKey((KeyCode)((uint)100)))
		{
			Transform transform7 = base.transform;
			float boxXFromColumn2 = Lawnf.GetBoxXFromColumn(this.board.columnNum);
			this.moving = true;
			Transform transform8 = base.transform;
			float deltaTime2 = Time.deltaTime;
			int num6 = 0;
			base.transform.rotation = num6;
			this.holdOn = num != 0;
			this.holdTimer = (float)num;
		}
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00040BF8 File Offset: 0x0003EDF8
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x935B80", Offset = "0x934180", VA = "0x180935B80", Slot = "15")]
	protected virtual bool CheckZombie(Zombie zombie, int row)
	{
		bool flag = this.CheckZombie(zombie);
		if (!flag)
		{
			return flag;
		}
		return zombie.theZombieRow <= row;
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00040C28 File Offset: 0x0003EE28
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x935C20", Offset = "0x934220", VA = "0x180935C20", Slot = "16")]
	protected virtual bool CheckZombie(Zombie zombie)
	{
		if (zombie.isMindControlled)
		{
		}
		return Lawnf.InLandStatus(zombie.theStatus);
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00040C54 File Offset: 0x0003EE54
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x935AE0", Offset = "0x9340E0", VA = "0x180935AE0", Slot = "17")]
	protected virtual bool CheckZombie_Search(Zombie zombie)
	{
		if (zombie.theStatus != ZombieStatus.Dying && !zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus) && !zombie.beforeDying)
		{
			Transform axis = zombie.axis;
			float boardMaxX = this.board.boardMaxX;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00040CA8 File Offset: 0x0003EEA8
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "18")]
	protected virtual void SetTarget()
	{
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00040CB8 File Offset: 0x0003EEB8
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x935C50", Offset = "0x934250", VA = "0x180935C50")]
	public void GetExperience(int value)
	{
		PetData petData = this.data;
		NumberPopManager instance = NumberPopManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		string text = string.Format("+{0}xp", z);
		PetData petData2 = this.data;
		if (petData2.attributeCount < 3000)
		{
			if (petData2.attributeCount < 1000)
			{
				this.level = (int)((ulong)1L);
				return;
			}
			ulong num;
			this.levelIcon.SetActive(num != 0UL);
			this.level = (int)((ulong)2L);
		}
		GameObject gameObject = this.levelIcon;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		ulong num3;
		this.levelIcon2.SetActive(num3 != 0UL);
		this.level = (int)((ulong)3L);
		throw new NullReferenceException();
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00040D6C File Offset: 0x0003EF6C
	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x936060", Offset = "0x934660", VA = "0x180936060")]
	protected void LayerUpdate()
	{
		Mouse mouse = this.mouse;
		Transform transform = base.transform;
		Mouse mouse2 = this.mouse;
		int num;
		this.thePetColumn = num;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		SortingGroup sortingGroup = this.sortingGroup;
		int num2;
		this.thePetRow = num2;
		string text = string.Format("zombie{0}", num2);
		sortingGroup.sortingLayerName = text;
		GameObject gameObject = this.lily;
		int num3 = 0;
		if (gameObject != num3)
		{
			Board board = this.board;
			GameObject gameObject2 = this.lily;
			GridSystem gridSystem = board.gridSystem;
			int num4 = this.thePetRow;
			int num5 = this.thePetColumn;
			bool flag = gridSystem.GetGrid(num5, num4).boxType == BoxType.Water;
			gameObject2.SetActive(flag);
		}
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00040E34 File Offset: 0x0003F034
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x9357D0", Offset = "0x933DD0", VA = "0x1809357D0")]
	private void AttackUpdate()
	{
		float num = this.attackTimer;
		float deltaTime = Time.deltaTime;
		this.attackTimer = num;
		int num2 = 0;
		this.AttackReady(num2 != 0);
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00040E68 File Offset: 0x0003F068
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x935830", Offset = "0x933E30", VA = "0x180935830")]
	private void AttributeUpdate()
	{
		float num = this.attributeTimer;
		float deltaTime = Time.deltaTime;
		this.attributeTimer = num;
		this.attributeTimer = 0f;
		this.AttributeEvent();
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00040EA0 File Offset: 0x0003F0A0
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x935890", Offset = "0x933E90", VA = "0x180935890", Slot = "19")]
	protected virtual void Awake()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		this.sortingGroup.sortingOrder = 30000;
		Animator component2 = base.GetComponent<Animator>();
		this.anim = component2;
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		LayerMask layerMask2 = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
		this.plantLayer = layerMask2;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00040F40 File Offset: 0x0003F140
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x936FD0", Offset = "0x9355D0", VA = "0x180936FD0")]
	private void Start()
	{
		this.GetExperience(200);
		this.LayerUpdate();
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00040F60 File Offset: 0x0003F160
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x937000", Offset = "0x935600", VA = "0x180937000")]
	private void Update()
	{
		this.PetUpdate();
		if (this.player)
		{
			this.PlayerPositionUpdate();
			if (!this.holdOn)
			{
				goto IL_002D;
			}
		}
		if (!this.moving)
		{
			goto IL_0075;
		}
		this.PositionUpdate();
		IL_002D:
		float num = this.holdTimer;
		float deltaTime = Time.deltaTime;
		this.holdTimer = deltaTime;
		if (deltaTime > 5f)
		{
			this.holdOn = true;
			this.moving = false;
		}
		Animator animator = this.anim;
		bool flag = this.moving;
		animator.SetBool("walking", flag);
		IL_0075:
		this.AttackUpdate();
		float num2 = this.attributeTimer;
		int num3 = 0;
		if (num2 > (float)num3)
		{
			num = num2;
			float deltaTime2 = Time.deltaTime;
			this.attributeTimer = num;
			this.attributeTimer = 0f;
			this.AttributeEvent();
		}
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00041028 File Offset: 0x0003F228
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x936CC0", Offset = "0x9352C0", VA = "0x180936CC0")]
	public static MiniPet SetPet(Board board, Vector2 position, PetType petType)
	{
		Dictionary<PetType, GameObject> petPrefabs = GameAPP.resourcesManager.petPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject;
		MiniPet component = gameObject.GetComponent<MiniPet>();
		component.data.petType = petType;
		component.board = board;
		Mouse instance = Mouse.Instance;
		component.mouse = instance;
		component.attackSpeed = 1f;
		component.attributeSpeed = 1f;
		Dictionary<PetType, PetOriginalData> petOriginalDataDic = MiniPet.PetOriginalDataDic;
		PetOriginalData petOriginalData;
		component.originalData = petOriginalData;
		PetOriginalData petOriginalData2 = component.originalData;
		float attackDamage = petOriginalData2.attackDamage;
		component.Damage = attackDamage;
		float num = petOriginalData2.attackRange;
		component.attackRange = num;
		float num2 = petOriginalData2.attackInterval;
		component.attackInterval = num2;
		board.pet = component;
		throw new NullReferenceException();
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00041100 File Offset: 0x0003F300
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x935E30", Offset = "0x934430", VA = "0x180935E30")]
	protected int GetZombieMaxHealthRow()
	{
		int num;
		int num2;
		int num3;
		int num4;
		ulong num6;
		do
		{
			num = this.thePetRow;
			num2 = 0;
			num3 = 0;
			num4 = 0;
			Board board = this.board;
			if (num4 >= board.rowNum)
			{
				return num;
			}
			int num5 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(num4, num5 != 0);
			bool flag;
			if (flag)
			{
			}
		}
		while (num6 != (ulong)0L);
		if (num2 > num3)
		{
		}
		num4++;
		return num;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00041164 File Offset: 0x0003F364
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x935A30", Offset = "0x934030", VA = "0x180935A30", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		int num = 0;
		if (num < target)
		{
			num += num;
			num++;
		}
		return typeof(IDamageable).TypeHandle != 0;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00041194 File Offset: 0x0003F394
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MiniPet()
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x000411A8 File Offset: 0x0003F3A8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x937190", Offset = "0x935790", VA = "0x180937190")]
	static MiniPet()
	{
		Dictionary<PetType, PetOriginalData> dictionary = new Dictionary();
		PetOriginalData petOriginalData = new PetOriginalData();
		petOriginalData.attackDamage = 300f;
		petOriginalData.attackInterval = 1.5f;
		petOriginalData.attackRange = 0.5f;
		int num = 0;
		dictionary.Add(num, petOriginalData);
		PetOriginalData petOriginalData2 = new PetOriginalData();
		petOriginalData2.attackDamage = 100f;
		petOriginalData2.attackInterval = 3f;
		petOriginalData2.attackRange = 0.5f;
		dictionary.Add((uint)1, petOriginalData2);
		PetOriginalData petOriginalData3 = new PetOriginalData();
		petOriginalData3.attackDamage = 40f;
		petOriginalData3.attackInterval = 3f;
		petOriginalData3.attackRange = 0.5f;
		dictionary.Add((uint)2, petOriginalData3);
		PetOriginalData petOriginalData4 = new PetOriginalData();
		petOriginalData4.attackInterval = 15f;
		int num2 = 0;
		petOriginalData4.attackDamage = (float)num2;
		dictionary.Add((uint)3, petOriginalData4);
		PetOriginalData petOriginalData5 = new PetOriginalData();
		petOriginalData5.attackDamage = 1800f;
		petOriginalData5.attackInterval = 5f;
		dictionary.Add((uint)4, petOriginalData5);
		PetOriginalData petOriginalData6 = new PetOriginalData();
		petOriginalData6.attackDamage = 80f;
		petOriginalData6.attackInterval = 0.2f;
		dictionary.Add((uint)5, petOriginalData6);
		PetOriginalData petOriginalData7 = new PetOriginalData();
		petOriginalData7.attackDamage = (float)num2;
		petOriginalData7.attackInterval = 10f;
		dictionary.Add((uint)6, petOriginalData7);
		PetOriginalData petOriginalData8 = new PetOriginalData();
		petOriginalData8.attackDamage = 900f;
		petOriginalData8.attackInterval = 3f;
		dictionary.Add((uint)7, petOriginalData8);
		MiniPet.PetOriginalDataDic = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04000762 RID: 1890
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000762")]
	[Header("参数")]
	public int thePetColumn;

	// Token: 0x04000763 RID: 1891
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000763")]
	public int thePetRow;

	// Token: 0x04000764 RID: 1892
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000764")]
	public int level;

	// Token: 0x04000765 RID: 1893
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000765")]
	public float damage;

	// Token: 0x04000766 RID: 1894
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000766")]
	public float attackRange;

	// Token: 0x04000767 RID: 1895
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000767")]
	public float attackSpeed;

	// Token: 0x04000768 RID: 1896
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000768")]
	public float attributeSpeed;

	// Token: 0x04000769 RID: 1897
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000769")]
	public float attackInterval;

	// Token: 0x0400076A RID: 1898
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400076A")]
	public PetData data;

	// Token: 0x0400076B RID: 1899
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400076B")]
	public PetOriginalData originalData;

	// Token: 0x0400076C RID: 1900
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400076C")]
	[Header("倒计时")]
	public float attackTimer;

	// Token: 0x0400076D RID: 1901
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400076D")]
	public float attributeTimer;

	// Token: 0x0400076E RID: 1902
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400076E")]
	public float holdTimer;

	// Token: 0x0400076F RID: 1903
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400076F")]
	[Header("手动引用")]
	public Transform shoot;

	// Token: 0x04000770 RID: 1904
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000770")]
	public GameObject lily;

	// Token: 0x04000771 RID: 1905
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000771")]
	public GameObject levelIcon;

	// Token: 0x04000772 RID: 1906
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000772")]
	public GameObject levelIcon2;

	// Token: 0x04000773 RID: 1907
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000773")]
	[Header("引用")]
	public Mouse mouse;

	// Token: 0x04000774 RID: 1908
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000774")]
	public Board board;

	// Token: 0x04000775 RID: 1909
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000775")]
	public SortingGroup sortingGroup;

	// Token: 0x04000776 RID: 1910
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000776")]
	public Animator anim;

	// Token: 0x04000777 RID: 1911
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000777")]
	public Rigidbody2D rb;

	// Token: 0x04000778 RID: 1912
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000778")]
	[Header("碰撞检测层级")]
	public LayerMask plantLayer;

	// Token: 0x04000779 RID: 1913
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000779")]
	public LayerMask zombieLayer;

	// Token: 0x0400077A RID: 1914
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400077A")]
	[Header("运动属性")]
	public Vector2Int targetGrid;

	// Token: 0x0400077B RID: 1915
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400077B")]
	public Vector2 targetPosition;

	// Token: 0x0400077C RID: 1916
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400077C")]
	public bool moving;

	// Token: 0x0400077D RID: 1917
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x400077D")]
	public bool player;

	// Token: 0x0400077E RID: 1918
	[FieldOffset(Offset = "0xC2")]
	[Token(Token = "0x400077E")]
	public bool holdOn;

	// Token: 0x0400077F RID: 1919
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400077F")]
	public float moveSpeed;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	private static readonly Dictionary<PetType, PetOriginalData> PetOriginalDataDic;
}
