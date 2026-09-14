using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200074B RID: 1867
[Token(Token = "0x200074B")]
public class WaterSpray : MonoBehaviour
{
	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x0600257E RID: 9598 RVA: 0x000C25E8 File Offset: 0x000C07E8
	[Token(Token = "0x170001B6")]
	private static GameObject Prefab
	{
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x60BC70", Offset = "0x60A270", VA = "0x18060BC70")]
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

	// Token: 0x0600257F RID: 9599 RVA: 0x000C261C File Offset: 0x000C081C
	[Token(Token = "0x600257F")]
	[Address(RVA = "0x60B7A0", Offset = "0x609DA0", VA = "0x18060B7A0")]
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

	// Token: 0x06002580 RID: 9600 RVA: 0x000C26B4 File Offset: 0x000C08B4
	[Token(Token = "0x6002580")]
	[Address(RVA = "0x60B740", Offset = "0x609D40", VA = "0x18060B740")]
	public void Active()
	{
		this.active = true;
		global::UnityEngine.Object.Destroy(this.water);
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x000C26D4 File Offset: 0x000C08D4
	[Token(Token = "0x6002581")]
	[Address(RVA = "0x60BB80", Offset = "0x60A180", VA = "0x18060BB80")]
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

	// Token: 0x06002582 RID: 9602 RVA: 0x000C2748 File Offset: 0x000C0948
	[Token(Token = "0x6002582")]
	[Address(RVA = "0x60BB30", Offset = "0x60A130", VA = "0x18060BB30")]
	private void OnDestroy()
	{
		global::UnityEngine.Object.Destroy(this.water);
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x000C2760 File Offset: 0x000C0960
	[Token(Token = "0x6002583")]
	[Address(RVA = "0x60BC50", Offset = "0x60A250", VA = "0x18060BC50")]
	public WaterSpray()
	{
	}

	// Token: 0x04001296 RID: 4758
	[Token(Token = "0x4001296")]
	private static GameObject _prefab;

	// Token: 0x04001297 RID: 4759
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001297")]
	public float liveTimer = 5f;

	// Token: 0x04001298 RID: 4760
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001298")]
	private GameObject water;

	// Token: 0x04001299 RID: 4761
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001299")]
	private Zombie zombie;

	// Token: 0x0400129A RID: 4762
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400129A")]
	private float coolTimer = 10f;

	// Token: 0x0400129B RID: 4763
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400129B")]
	public bool active;
}
