using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000272 RID: 626
[Token(Token = "0x2000272")]
public class MiniPet : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00040AA8 File Offset: 0x0003ECA8
	// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00040ABC File Offset: 0x0003ECBC
	[Token(Token = "0x17000094")]
	public virtual float Damage
	{
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x3B0410", Offset = "0x3AEA10", VA = "0x1803B0410", Slot = "7")]
		get
		{
			return this.damage;
		}
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x3B0420", Offset = "0x3AEA20", VA = "0x1803B0420", Slot = "8")]
		set
		{
			this.damage = value;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00040AD0 File Offset: 0x0003ECD0
	// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00040AE8 File Offset: 0x0003ECE8
	[Token(Token = "0x17000095")]
	public Team Team
	{
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x8A7480", Offset = "0x8A5A80", VA = "0x1808A7480", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00040AFC File Offset: 0x0003ECFC
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "9")]
	protected virtual void AnimAttack()
	{
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00040B0C File Offset: 0x0003ED0C
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "10")]
	protected virtual void PetUpdate()
	{
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00040B1C File Offset: 0x0003ED1C
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x8A57D0", Offset = "0x8A3DD0", VA = "0x1808A57D0", Slot = "11")]
	protected virtual void AttackReady(bool moveOver)
	{
		float num = this.attackInterval;
		this.attackTimer = num;
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00040B38 File Offset: 0x0003ED38
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	protected virtual void AttributeEvent()
	{
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00040B48 File Offset: 0x0003ED48
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x8A6820", Offset = "0x8A4E20", VA = "0x1808A6820", Slot = "13")]
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

	// Token: 0x06000B48 RID: 2888 RVA: 0x00040C34 File Offset: 0x0003EE34
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x8A6210", Offset = "0x8A4810", VA = "0x1808A6210", Slot = "14")]
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

	// Token: 0x06000B49 RID: 2889 RVA: 0x00040DC0 File Offset: 0x0003EFC0
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x8A5B90", Offset = "0x8A4190", VA = "0x1808A5B90", Slot = "15")]
	protected virtual bool CheckZombie(Zombie zombie, int row)
	{
		bool flag = this.CheckZombie(zombie);
		if (!flag)
		{
			return flag;
		}
		return zombie.theZombieRow <= row;
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00040DF0 File Offset: 0x0003EFF0
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x8A5C30", Offset = "0x8A4230", VA = "0x1808A5C30", Slot = "16")]
	protected virtual bool CheckZombie(Zombie zombie)
	{
		if (zombie.isMindControlled)
		{
		}
		return Lawnf.InLandStatus(zombie.theStatus);
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00040E1C File Offset: 0x0003F01C
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x8A5AF0", Offset = "0x8A40F0", VA = "0x1808A5AF0", Slot = "17")]
	protected virtual bool CheckZombie_Search(Zombie zombie)
	{
		if (zombie.theStatus != ZombieStatus.Dying && !zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus) && !zombie.beforeDying)
		{
			Transform axis = zombie.axis;
			float boardMaxX = this.board.boardMaxX;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00040E70 File Offset: 0x0003F070
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "18")]
	protected virtual void SetTarget()
	{
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x00040E80 File Offset: 0x0003F080
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x8A5C60", Offset = "0x8A4260", VA = "0x1808A5C60")]
	public void GetExperience(int value)
	{
		PetData petData = this.data;
		Board board = this.board;
		Transform transform = base.transform;
		Vector3 vector;
		string text = string.Format("+{0}xp", vector);
		PetData petData2 = this.data;
		if (petData2.attributeCount >= 3000)
		{
			GameObject gameObject = this.levelIcon;
			int num = 0;
			gameObject.SetActive(num != 0);
			ulong num2;
			this.levelIcon2.SetActive(num2 != 0UL);
			this.level = (int)((ulong)3L);
			return;
		}
		if (petData2.attributeCount < 1000)
		{
			this.level = (int)((ulong)1L);
			return;
		}
		ulong num3;
		this.levelIcon.SetActive(num3 != 0UL);
		this.level = (int)((ulong)2L);
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00040F28 File Offset: 0x0003F128
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x8A6040", Offset = "0x8A4640", VA = "0x1808A6040")]
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

	// Token: 0x06000B4F RID: 2895 RVA: 0x00040FF0 File Offset: 0x0003F1F0
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x8A57E0", Offset = "0x8A3DE0", VA = "0x1808A57E0")]
	private void AttackUpdate()
	{
		float num = this.attackTimer;
		float deltaTime = Time.deltaTime;
		this.attackTimer = num;
		int num2 = 0;
		this.AttackReady(num2 != 0);
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00041024 File Offset: 0x0003F224
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x8A5840", Offset = "0x8A3E40", VA = "0x1808A5840")]
	private void AttributeUpdate()
	{
		float num = this.attributeTimer;
		float deltaTime = Time.deltaTime;
		this.attributeTimer = num;
		this.attributeTimer = 0f;
		this.AttributeEvent();
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x0004105C File Offset: 0x0003F25C
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x8A58A0", Offset = "0x8A3EA0", VA = "0x1808A58A0", Slot = "19")]
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

	// Token: 0x06000B52 RID: 2898 RVA: 0x000410FC File Offset: 0x0003F2FC
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x8A6FB0", Offset = "0x8A55B0", VA = "0x1808A6FB0")]
	private void Start()
	{
		this.GetExperience(200);
		this.LayerUpdate();
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0004111C File Offset: 0x0003F31C
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x8A6FE0", Offset = "0x8A55E0", VA = "0x1808A6FE0")]
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

	// Token: 0x06000B54 RID: 2900 RVA: 0x000411E4 File Offset: 0x0003F3E4
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x8A6CA0", Offset = "0x8A52A0", VA = "0x1808A6CA0")]
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

	// Token: 0x06000B55 RID: 2901 RVA: 0x000412BC File Offset: 0x0003F4BC
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x8A5E10", Offset = "0x8A4410", VA = "0x1808A5E10")]
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

	// Token: 0x06000B56 RID: 2902 RVA: 0x00041320 File Offset: 0x0003F520
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x8A5A40", Offset = "0x8A4040", VA = "0x1808A5A40", Slot = "6")]
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

	// Token: 0x06000B57 RID: 2903 RVA: 0x00041350 File Offset: 0x0003F550
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MiniPet()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00041364 File Offset: 0x0003F564
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x8A7170", Offset = "0x8A5770", VA = "0x1808A7170")]
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

	// Token: 0x04000756 RID: 1878
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000756")]
	[Header("参数")]
	public int thePetColumn;

	// Token: 0x04000757 RID: 1879
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000757")]
	public int thePetRow;

	// Token: 0x04000758 RID: 1880
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000758")]
	public int level;

	// Token: 0x04000759 RID: 1881
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000759")]
	public float damage;

	// Token: 0x0400075A RID: 1882
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400075A")]
	public float attackRange;

	// Token: 0x0400075B RID: 1883
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400075B")]
	public float attackSpeed;

	// Token: 0x0400075C RID: 1884
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400075C")]
	public float attributeSpeed;

	// Token: 0x0400075D RID: 1885
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400075D")]
	public float attackInterval;

	// Token: 0x0400075E RID: 1886
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400075E")]
	public PetData data;

	// Token: 0x0400075F RID: 1887
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400075F")]
	public PetOriginalData originalData;

	// Token: 0x04000760 RID: 1888
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000760")]
	[Header("倒计时")]
	public float attackTimer;

	// Token: 0x04000761 RID: 1889
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000761")]
	public float attributeTimer;

	// Token: 0x04000762 RID: 1890
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000762")]
	public float holdTimer;

	// Token: 0x04000763 RID: 1891
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000763")]
	[Header("手动引用")]
	public Transform shoot;

	// Token: 0x04000764 RID: 1892
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000764")]
	public GameObject lily;

	// Token: 0x04000765 RID: 1893
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000765")]
	public GameObject levelIcon;

	// Token: 0x04000766 RID: 1894
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000766")]
	public GameObject levelIcon2;

	// Token: 0x04000767 RID: 1895
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000767")]
	[Header("引用")]
	public Mouse mouse;

	// Token: 0x04000768 RID: 1896
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000768")]
	public Board board;

	// Token: 0x04000769 RID: 1897
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000769")]
	public SortingGroup sortingGroup;

	// Token: 0x0400076A RID: 1898
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400076A")]
	public Animator anim;

	// Token: 0x0400076B RID: 1899
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400076B")]
	public Rigidbody2D rb;

	// Token: 0x0400076C RID: 1900
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400076C")]
	[Header("碰撞检测层级")]
	public LayerMask plantLayer;

	// Token: 0x0400076D RID: 1901
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400076D")]
	public LayerMask zombieLayer;

	// Token: 0x0400076E RID: 1902
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400076E")]
	[Header("运动属性")]
	public Vector2Int targetGrid;

	// Token: 0x0400076F RID: 1903
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400076F")]
	public Vector2 targetPosition;

	// Token: 0x04000770 RID: 1904
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000770")]
	public bool moving;

	// Token: 0x04000771 RID: 1905
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x4000771")]
	public bool player;

	// Token: 0x04000772 RID: 1906
	[FieldOffset(Offset = "0xC2")]
	[Token(Token = "0x4000772")]
	public bool holdOn;

	// Token: 0x04000773 RID: 1907
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000773")]
	public float moveSpeed;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000774")]
	private static readonly Dictionary<PetType, PetOriginalData> PetOriginalDataDic;
}
