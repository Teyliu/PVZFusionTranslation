using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x020002B1 RID: 689
[Token(Token = "0x20002B1")]
public class ConnectPortal : MonoBehaviour
{
	// Token: 0x06000C28 RID: 3112 RVA: 0x00046108 File Offset: 0x00044308
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x3D2CD0", Offset = "0x3D12D0", VA = "0x1803D2CD0")]
	public void Shoot()
	{
		ConnectPortal.PortalBall portalBall = new ConnectPortal.PortalBall(this);
		List<ConnectPortal> list = this.connectPortals;
		Func<ConnectPortal, bool> <>9__7_ = ConnectPortal.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			Func<ConnectPortal, bool> func;
			ConnectPortal.<>c.<>9__7_0 = func;
		}
		ConnectPortal connectPortal = Enumerable.FirstOrDefault<ConnectPortal>(list, <>9__7_);
		List<ConnectPortal.PortalBall> list2 = connectPortal.balls;
		int size = list2._size;
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00046160 File Offset: 0x00044360
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x3D21A0", Offset = "0x3D07A0", VA = "0x1803D21A0")]
	public void AcceptBall(ConnectPortal.PortalBall ball)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00046180 File Offset: 0x00044380
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x3D2C20", Offset = "0x3D1220", VA = "0x1803D2C20")]
	private void Start()
	{
		Transform transform = this.portal_in.transform;
		float num = this.distance;
		Transform transform2 = this.portal_out.transform;
		float num2 = this.distance;
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x000461C0 File Offset: 0x000443C0
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x3D2C20", Offset = "0x3D1220", VA = "0x1803D2C20")]
	private void OnDrawGizmosSelected()
	{
		Transform transform = this.portal_in.transform;
		float num = this.distance;
		Transform transform2 = this.portal_out.transform;
		float num2 = this.distance;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00046200 File Offset: 0x00044400
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x3D2F60", Offset = "0x3D1560", VA = "0x1803D2F60")]
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

	// Token: 0x06000C2D RID: 3117 RVA: 0x00046234 File Offset: 0x00044434
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x3D2AF0", Offset = "0x3D10F0", VA = "0x1803D2AF0")]
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

	// Token: 0x06000C2E RID: 3118 RVA: 0x00046268 File Offset: 0x00044468
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x3D2C10", Offset = "0x3D1210", VA = "0x1803D2C10")]
	private CancellationToken GetCancellationToken()
	{
		return this.GetCancellationTokenOnDestroy();
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0004627C File Offset: 0x0004447C
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x3D2A20", Offset = "0x3D1020", VA = "0x1803D2A20")]
	public void Die(float timer)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x000462A0 File Offset: 0x000444A0
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x3D2270", Offset = "0x3D0870", VA = "0x1803D2270")]
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

	// Token: 0x06000C31 RID: 3121 RVA: 0x000463F8 File Offset: 0x000445F8
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
	public static void Shooting(ConnectPortal connectPortal, int count)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0004641C File Offset: 0x0004461C
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x3D2810", Offset = "0x3D0E10", VA = "0x1803D2810")]
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

	// Token: 0x06000C33 RID: 3123 RVA: 0x0004647C File Offset: 0x0004467C
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x3D3080", Offset = "0x3D1680", VA = "0x1803D3080")]
	public ConnectPortal()
	{
		List<ConnectPortal> list = new List();
		this.connectPortals = list;
		List<ConnectPortal.PortalBall> list2 = new List();
		this.balls = list2;
		base..ctor();
	}

	// Token: 0x04000846 RID: 2118
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000846")]
	public List<ConnectPortal> connectPortals;

	// Token: 0x04000847 RID: 2119
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000847")]
	public List<ConnectPortal.PortalBall> balls;

	// Token: 0x04000848 RID: 2120
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000848")]
	public GameObject portal_in;

	// Token: 0x04000849 RID: 2121
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000849")]
	public GameObject portal_out;

	// Token: 0x0400084A RID: 2122
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400084A")]
	public int damage;

	// Token: 0x0400084B RID: 2123
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400084B")]
	[Range(5f, 15f)]
	public float distance;

	// Token: 0x0400084C RID: 2124
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400084C")]
	public bool main;

	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	[Serializable]
	public class PortalBall
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x000464AC File Offset: 0x000446AC
		[Token(Token = "0x1700009F")]
		public Vector2 Target
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x3DC650", Offset = "0x3DAC50", VA = "0x1803DC650")]
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

		// Token: 0x06000C35 RID: 3125 RVA: 0x000464E4 File Offset: 0x000446E4
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x3DC020", Offset = "0x3DA620", VA = "0x1803DC020")]
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

		// Token: 0x06000C36 RID: 3126 RVA: 0x000465A0 File Offset: 0x000447A0
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x3DBBF0", Offset = "0x3DA1F0", VA = "0x1803DBBF0")]
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

		// Token: 0x06000C37 RID: 3127 RVA: 0x00046648 File Offset: 0x00044848
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x3DC3D0", Offset = "0x3DA9D0", VA = "0x1803DC3D0")]
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

		// Token: 0x06000C38 RID: 3128 RVA: 0x00046758 File Offset: 0x00044958
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x3DB950", Offset = "0x3D9F50", VA = "0x1803DB950")]
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

		// Token: 0x0400084D RID: 2125
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400084D")]
		public Transform transform;

		// Token: 0x0400084E RID: 2126
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400084E")]
		public ConnectPortal portal;

		// Token: 0x0400084F RID: 2127
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400084F")]
		public Transform sprite;

		// Token: 0x04000850 RID: 2128
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000850")]
		public ParticleSystem particle;

		// Token: 0x04000851 RID: 2129
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000851")]
		public ConnectPortal.PortalBall.Direction direction;

		// Token: 0x04000852 RID: 2130
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000852")]
		private float moveSpeed = 10f;

		// Token: 0x04000853 RID: 2131
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000853")]
		private float rotateSpeed = 10f;

		// Token: 0x020002B3 RID: 691
		[Token(Token = "0x20002B3")]
		public enum Direction
		{
			// Token: 0x04000855 RID: 2133
			[Token(Token = "0x4000855")]
			InToOut,
			// Token: 0x04000856 RID: 2134
			[Token(Token = "0x4000856")]
			OutToIn
		}
	}
}
