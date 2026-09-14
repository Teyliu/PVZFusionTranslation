using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000712 RID: 1810
[Token(Token = "0x2000712")]
public class WaterSpray : MonoBehaviour
{
	// Token: 0x17000170 RID: 368
	// (get) Token: 0x0600245E RID: 9310 RVA: 0x000BD800 File Offset: 0x000BBA00
	[Token(Token = "0x17000170")]
	private static GameObject Prefab
	{
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x591B50", Offset = "0x590150", VA = "0x180591B50")]
		get
		{
			GameObject prefab = WaterSpray._prefab;
			int num = 0;
			if (prefab == num)
			{
				WaterSpray._prefab = Resources.Load<GameObject>("Zombies/WaterSpray");
			}
			return WaterSpray._prefab;
		}
	}

	// Token: 0x0600245F RID: 9311 RVA: 0x000BD834 File Offset: 0x000BBA34
	[Token(Token = "0x600245F")]
	[Address(RVA = "0x591680", Offset = "0x58FC80", VA = "0x180591680")]
	private void Awake()
	{
		bool flag;
		if (!flag)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
		ulong num;
		this.zombie = num;
		bool flag2;
		if (flag2)
		{
		}
		GameObject prefab = WaterSpray._prefab;
		int num2 = 0;
		if (prefab == num2)
		{
			WaterSpray._prefab = Resources.Load<GameObject>("Zombies/WaterSpray");
		}
		Transform transform;
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(WaterSpray._prefab, transform);
		this.water = gameObject;
		uint num3;
		this.water.GetComponent<SortingGroup>().sortingOrder = (int)num3;
		GameObject gameObject2 = this.water;
		bool flag3;
		if (!flag3)
		{
			Transform transform2 = gameObject2.transform;
			Vector3 vector;
			float z = vector.z;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002460 RID: 9312 RVA: 0x000BD8CC File Offset: 0x000BBACC
	[Token(Token = "0x6002460")]
	[Address(RVA = "0x591620", Offset = "0x58FC20", VA = "0x180591620")]
	public void Active()
	{
		this.active = true;
		global::UnityEngine.Object.Destroy(this.water);
	}

	// Token: 0x06002461 RID: 9313 RVA: 0x000BD8EC File Offset: 0x000BBAEC
	[Token(Token = "0x6002461")]
	[Address(RVA = "0x591A60", Offset = "0x590060", VA = "0x180591A60")]
	private void Update()
	{
		int num = 0;
		if ((this.active ? 1 : 0) == num)
		{
			float num2 = this.liveTimer;
			float deltaTime = Time.deltaTime;
			this.liveTimer = num2;
		}
		float num3 = this.coolTimer;
		float deltaTime2 = Time.deltaTime;
		this.coolTimer = num3;
		if (0 > (int)num3)
		{
			global::UnityEngine.Object.Destroy(this);
		}
		Zombie zombie = this.zombie;
		if (zombie.beforeDying || zombie.theStatus == ZombieStatus.Dying)
		{
			global::UnityEngine.Object.Destroy(this);
			return;
		}
	}

	// Token: 0x06002462 RID: 9314 RVA: 0x000BD960 File Offset: 0x000BBB60
	[Token(Token = "0x6002462")]
	[Address(RVA = "0x591A10", Offset = "0x590010", VA = "0x180591A10")]
	private void OnDestroy()
	{
		global::UnityEngine.Object.Destroy(this.water);
	}

	// Token: 0x06002463 RID: 9315 RVA: 0x000BD978 File Offset: 0x000BBB78
	[Token(Token = "0x6002463")]
	[Address(RVA = "0x591B30", Offset = "0x590130", VA = "0x180591B30")]
	public WaterSpray()
	{
	}

	// Token: 0x040011C4 RID: 4548
	[Token(Token = "0x40011C4")]
	private static GameObject _prefab;

	// Token: 0x040011C5 RID: 4549
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011C5")]
	public float liveTimer = 5f;

	// Token: 0x040011C6 RID: 4550
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011C6")]
	private GameObject water;

	// Token: 0x040011C7 RID: 4551
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011C7")]
	private Zombie zombie;

	// Token: 0x040011C8 RID: 4552
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011C8")]
	private float coolTimer = 10f;

	// Token: 0x040011C9 RID: 4553
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40011C9")]
	public bool active;
}
