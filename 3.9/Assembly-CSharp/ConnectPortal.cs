using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x020002BC RID: 700
[Token(Token = "0x20002BC")]
public class ConnectPortal : MonoBehaviour
{
	// Token: 0x06000C51 RID: 3153 RVA: 0x00046430 File Offset: 0x00044630
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x41FB30", Offset = "0x41E130", VA = "0x18041FB30")]
	public void Shoot()
	{
		ConnectPortal.PortalBall portalBall = new ConnectPortal.PortalBall(this);
		List<ConnectPortal> list = this.connectPortals;
		Func<ConnectPortal, bool> <>9__7_ = ConnectPortal.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			ConnectPortal.<>c.<>9__7_0 = (ConnectPortal a) => a.main;
		}
		ConnectPortal connectPortal = Enumerable.FirstOrDefault<ConnectPortal>(list, <>9__7_);
		List<ConnectPortal.PortalBall> list2 = connectPortal.balls;
		int size = list2._size;
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00046494 File Offset: 0x00044694
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x41F000", Offset = "0x41D600", VA = "0x18041F000")]
	public void AcceptBall(ConnectPortal.PortalBall ball)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x000464B4 File Offset: 0x000446B4
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x41FA80", Offset = "0x41E080", VA = "0x18041FA80")]
	private void Start()
	{
		Transform transform = this.portal_in.transform;
		float num = this.distance;
		Transform transform2 = this.portal_out.transform;
		float num2 = this.distance;
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x000464F4 File Offset: 0x000446F4
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x41FA80", Offset = "0x41E080", VA = "0x18041FA80")]
	private void OnDrawGizmosSelected()
	{
		Transform transform = this.portal_in.transform;
		float num = this.distance;
		Transform transform2 = this.portal_out.transform;
		float num2 = this.distance;
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00046534 File Offset: 0x00044734
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x41FDC0", Offset = "0x41E3C0", VA = "0x18041FDC0")]
	private void Update()
	{
		ulong num2;
		do
		{
			int num = 0;
			if ((this.main ? 1 : 0) == num)
			{
				break;
			}
			List<ConnectPortal.PortalBall> list = this.balls;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00046568 File Offset: 0x00044768
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x41F950", Offset = "0x41DF50", VA = "0x18041F950")]
	private void FixedUpdate()
	{
		ulong num2;
		do
		{
			int num = 0;
			if ((this.main ? 1 : 0) == num)
			{
				break;
			}
			List<ConnectPortal.PortalBall> list = this.balls;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x0004659C File Offset: 0x0004479C
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x41FA70", Offset = "0x41E070", VA = "0x18041FA70")]
	private CancellationToken GetCancellationToken()
	{
		return this.GetCancellationTokenOnDestroy();
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x000465B0 File Offset: 0x000447B0
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x41F880", Offset = "0x41DE80", VA = "0x18041F880")]
	public void Die(float timer)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x000465D4 File Offset: 0x000447D4
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x41F0D0", Offset = "0x41D6D0", VA = "0x18041F0D0")]
	public static ConnectPortal CreatePortalGroups(int portalCount, int shootCount, float x, float lifeTime, int damage)
	{
		ConnectPortal connectPortal;
		int num5;
		do
		{
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			Mouse instance = Mouse.Instance;
			int rowNum = Board.Instance.rowNum;
			float landY = instance.GetLandY(x, rowNum);
			Mouse instance2 = Mouse.Instance;
			int num2 = 0;
			float landY2 = instance2.GetLandY(x, num2);
			uint num3;
			connectPortal.main = num3 != 0U;
			int size = connectPortal.connectPortals._size;
			connectPortal.connectPortals = connectPortal;
			int num4 = 0;
			Transform transform = connectPortal.transform;
			num5 = 0;
			int num6 = 0;
			int num7 = 0;
			transform.Rotate((float)num7, (float)num6, 90f);
			connectPortal.damage = 0;
			if (portalCount > (int)num3)
			{
				uint num8 = num3 + 1U;
				num8 -= (uint)num4;
				if (num3 == (uint)1)
				{
				}
				ConnectPortal connectPortal2 = ConnectPortal.CreateSingleGroup(num7);
				List<ConnectPortal> list = connectPortal.connectPortals;
				connectPortal2.connectPortals = list;
				Transform transform2 = connectPortal2.transform;
				int num9 = 0;
				int num10 = 0;
				transform2.Rotate((float)num10, (float)num9, 90f);
				connectPortal2.damage = 0;
				List<ConnectPortal> list2 = connectPortal.connectPortals;
				num3 += (uint)1;
			}
			List<ConnectPortal> list3 = connectPortal.connectPortals;
			bool flag;
			if (flag)
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			}
		}
		while (num5 != 0);
		Action defaultContextAction2 = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		return connectPortal;
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0004672C File Offset: 0x0004492C
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x41FD00", Offset = "0x41E300", VA = "0x18041FD00")]
	public static void Shooting(ConnectPortal connectPortal, int count)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00046750 File Offset: 0x00044950
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x41F670", Offset = "0x41DC70", VA = "0x18041F670")]
	private static ConnectPortal CreateSingleGroup(Vector2 center)
	{
		ConnectPortal connectPortal = Resources.Load<ConnectPortal>("Plants/DoomShroom/UltimateIceDoom/portal/Portal");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = Board.Instance.transform;
		Mouse instance = Mouse.Instance;
		Board instance2 = Board.Instance;
		Mouse instance3 = Mouse.Instance;
		float num2;
		float num = num2 * 5f;
		ConnectPortal connectPortal2;
		connectPortal2.distance = num;
		return connectPortal2;
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x000467B0 File Offset: 0x000449B0
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x41FEE0", Offset = "0x41E4E0", VA = "0x18041FEE0")]
	public ConnectPortal()
	{
		List<ConnectPortal> list = new List();
		this.connectPortals = list;
		List<ConnectPortal.PortalBall> list2 = new List();
		this.balls = list2;
		base..ctor();
	}

	// Token: 0x04000865 RID: 2149
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000865")]
	public List<ConnectPortal> connectPortals;

	// Token: 0x04000866 RID: 2150
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000866")]
	public List<ConnectPortal.PortalBall> balls;

	// Token: 0x04000867 RID: 2151
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000867")]
	public GameObject portal_in;

	// Token: 0x04000868 RID: 2152
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000868")]
	public GameObject portal_out;

	// Token: 0x04000869 RID: 2153
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000869")]
	public int damage;

	// Token: 0x0400086A RID: 2154
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400086A")]
	[Range(5f, 15f)]
	public float distance;

	// Token: 0x0400086B RID: 2155
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400086B")]
	public bool main;

	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	[Serializable]
	public class PortalBall
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000467E0 File Offset: 0x000449E0
		[Token(Token = "0x170000DE")]
		public Vector2 Target
		{
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x42A7F0", Offset = "0x428DF0", VA = "0x18042A7F0")]
			get
			{
				ConnectPortal connectPortal = this.portal;
				if (this.direction == ConnectPortal.PortalBall.Direction.InToOut)
				{
				}
				Transform transform = connectPortal.portal_in.transform;
				throw new NullReferenceException();
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00046818 File Offset: 0x00044A18
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x42A1C0", Offset = "0x4287C0", VA = "0x18042A1C0")]
		public void OnUpdate()
		{
			Transform transform = this.transform;
			Vector3 vector;
			float z = vector.z;
			ConnectPortal connectPortal = this.portal;
			if (this.direction == ConnectPortal.PortalBall.Direction.InToOut)
			{
			}
			Transform transform2 = connectPortal.portal_in.transform;
			float deltaTime = Time.deltaTime;
			if (0 == 0)
			{
			}
			Transform transform3 = this.sprite.transform;
			float deltaTime2 = Time.deltaTime;
			int num = 0;
			int num2 = 0;
			float num3 = deltaTime2 * 57.29578f;
			transform3.Rotate((float)num2, (float)num, num3);
			Transform transform4 = this.transform;
			ConnectPortal connectPortal2 = this.portal;
			if (this.direction == ConnectPortal.PortalBall.Direction.InToOut)
			{
			}
			Transform transform5 = connectPortal2.portal_in.transform;
			ConnectPortal connectPortal3 = this.portal;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000468D4 File Offset: 0x00044AD4
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x429D90", Offset = "0x428390", VA = "0x180429D90")]
		public void OnFixedUpdate()
		{
			int num = 0;
			ConnectPortal connectPortal = this.portal;
			if (this.direction == (ConnectPortal.PortalBall.Direction)num)
			{
			}
			Transform transform = connectPortal.portal_in.transform;
			Transform transform2 = this.transform;
			Transform transform3 = this.transform;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			RaycastHit2D[] array;
			if (num < array.Length)
			{
				int num2 = 0;
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(num2))
				{
					ConnectPortal connectPortal2 = this.portal;
					num2 += num2;
					num = num2;
					GameAPP.PlaySound(num2, 0.5f, 1f);
				}
				num++;
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0004697C File Offset: 0x00044B7C
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x42A570", Offset = "0x428B70", VA = "0x18042A570")]
		public PortalBall(ConnectPortal portal)
		{
			GameObject gameObject = Resources.Load<GameObject>("Plants/DoomShroom/UltimateIceDoom/portal/PortalBall");
			Transform transform = Board.Instance.transform;
			Transform transform2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).transform;
			this.transform = transform2;
			this.portal = portal;
			Transform transform3 = this.transform;
			Transform transform4 = portal.portal_in.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform5 = this.transform;
			int num = 0;
			Transform transform6 = transform5.GetChild(num).transform;
			this.sprite = transform6;
			ParticleSystem component = this.transform.GetChild(1).GetComponent<ParticleSystem>();
			this.particle = component;
			float num2 = global::UnityEngine.Random.Range(8f, 12f);
			this.moveSpeed = num2;
			float num3 = global::UnityEngine.Random.Range(4f, 9f);
			this.rotateSpeed = num3;
			if (global::UnityEngine.Random.Range(0, 2) == 0)
			{
				float num4 = this.rotateSpeed * -1f;
				this.rotateSpeed = num4;
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00046A8C File Offset: 0x00044C8C
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x429AF0", Offset = "0x4280F0", VA = "0x180429AF0")]
		public void Die()
		{
			Transform transform = this.transform;
			Mouse instance = Mouse.Instance;
			Transform transform2 = this.transform;
			Board instance2 = Board.Instance;
			Transform transform3 = this.transform;
			BoardAction boardAction = instance2.boardAction;
			int damage = this.portal.damage;
			if (ConnectPortal.PortalBall.<>c.<>9__13_0 == 0)
			{
				Action<Zombie> action;
				ConnectPortal.PortalBall.<>c.<>9__13_0 = action;
			}
			global::UnityEngine.Object.Destroy(this.transform.gameObject);
		}

		// Token: 0x0400086C RID: 2156
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400086C")]
		public Transform transform;

		// Token: 0x0400086D RID: 2157
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400086D")]
		public ConnectPortal portal;

		// Token: 0x0400086E RID: 2158
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400086E")]
		public Transform sprite;

		// Token: 0x0400086F RID: 2159
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400086F")]
		public ParticleSystem particle;

		// Token: 0x04000870 RID: 2160
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000870")]
		public ConnectPortal.PortalBall.Direction direction;

		// Token: 0x04000871 RID: 2161
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000871")]
		private float moveSpeed = 10f;

		// Token: 0x04000872 RID: 2162
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000872")]
		private float rotateSpeed = 10f;

		// Token: 0x020002BE RID: 702
		[Token(Token = "0x20002BE")]
		public enum Direction
		{
			// Token: 0x04000874 RID: 2164
			[Token(Token = "0x4000874")]
			InToOut,
			// Token: 0x04000875 RID: 2165
			[Token(Token = "0x4000875")]
			OutToIn
		}
	}
}
