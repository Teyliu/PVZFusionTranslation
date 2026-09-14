using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200059B RID: 1435
[Token(Token = "0x200059B")]
public class UltimateBigSniper : Shooter
{
	// Token: 0x06001A8C RID: 6796 RVA: 0x0008EA34 File Offset: 0x0008CC34
	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x4F99B0", Offset = "0x4F7FB0", VA = "0x1804F99B0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			Transform transform = this.headPos;
			float num = this.angle * 0.017453292f;
			float deltaTime = Time.deltaTime;
		}
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x0008EA80 File Offset: 0x0008CC80
	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x4F8CE0", Offset = "0x4F72E0", VA = "0x1804F8CE0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		this.ValidateTargetPlant();
		Plant targetPlant = this.targetPlant;
		int num2 = 0;
		if (!(targetPlant != num2))
		{
			if (base.Shootable())
			{
				this.anim.SetTrigger("shoot");
				this.theStatus = (PlantStatus)((ulong)28L);
			}
			return;
		}
		Transform shoot = this.targetPlant.shoot;
		float num3;
		this.angle = num3;
		throw new NullReferenceException();
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x0008EB04 File Offset: 0x0008CD04
	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x4F81F0", Offset = "0x4F67F0", VA = "0x1804F81F0")]
	private int GetAttackDamage()
	{
		if (global::Lawnf.TravelUltimateLevel((UltiBuff)((uint)21)) == 2)
		{
		}
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)20)))
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x0008EB2C File Offset: 0x0008CD2C
	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x4F7770", Offset = "0x4F5D70", VA = "0x1804F7770")]
	private float CalculateBaseDamage()
	{
		return 0f;
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x0008EB40 File Offset: 0x0008CD40
	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x4F75A0", Offset = "0x4F5BA0", VA = "0x1804F75A0")]
	private float ApplyLowHealthBonus(float dmg)
	{
		if (global::Lawnf.TravelUltimateLevel((UltiBuff)((uint)21)) == 2)
		{
		}
		return dmg;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x0008EB5C File Offset: 0x0008CD5C
	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x4F75E0", Offset = "0x4F5BE0", VA = "0x1804F75E0")]
	private float ApplyUltimateBuffs(float dmg)
	{
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)20)))
		{
		}
		return dmg;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x0008EB7C File Offset: 0x0008CD7C
	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x4F78F0", Offset = "0x4F5EF0", VA = "0x1804F78F0")]
	private void ConsumeHealthIfHigh()
	{
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x0008EB8C File Offset: 0x0008CD8C
	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x4F82F0", Offset = "0x4F68F0", VA = "0x1804F82F0", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)21)))
		{
		}
		return base.GetDamage(damage);
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x0008EBBC File Offset: 0x0008CDBC
	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x4F97F0", Offset = "0x4F7DF0", VA = "0x1804F97F0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		this.DrawLines();
		float num = global::UnityEngine.Random.Range(0.8f, 1.2f);
		GameAPP.PlaySound(135, 0.3f, num);
		List<LineRenderer> list = this.allLasers;
		Transform transform = this.headPos;
		this.theStatus = (PlantStatus)((ulong)8L);
		throw new NullReferenceException();
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x0008EC10 File Offset: 0x0008CE10
	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x4F7BC0", Offset = "0x4F61C0", VA = "0x1804F7BC0")]
	private void DrawLines()
	{
		this.KillLine(true);
		Transform transform = this.laserStart;
		float num = this.angle * 0.017453292f;
		Plant targetPlant = this.targetPlant;
		int num2 = 0;
		int num3 = 0;
		if (!(targetPlant != num3))
		{
			Board board = this.board;
			int num4 = 0;
			int num5 = 0;
			this.DrawLine(num3, num2, num5 != 0, num4);
			return;
		}
		Transform shoot = this.targetPlant.shoot;
		Vector3 vector;
		float z = vector.z;
		Plant targetPlant2 = this.targetPlant;
		GameObject gameObject = this.laserPrefab;
		Transform shoot2 = this.targetPlant.shoot;
		Transform shoot3 = this.targetPlant.shoot;
		Board board2 = this.board;
		Vector2 rightVector = Vector2.rightVector;
		Transform shoot4 = this.targetPlant.shoot;
		Transform shoot5 = this.targetPlant.shoot;
		Board board3 = this.board;
		Transform shoot6 = this.targetPlant.shoot;
		Transform shoot7 = this.targetPlant.shoot;
		Board board4 = this.board;
		throw new NullReferenceException();
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x0008ED0C File Offset: 0x0008CF0C
	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x4F7950", Offset = "0x4F5F50", VA = "0x1804F7950")]
	private void DrawLine(Vector2 start, Vector2 end, bool isExtra, [Optional] GameObject prefab)
	{
		bool flag;
		if (flag)
		{
		}
		Transform transform = this.board.transform;
		GameObject gameObject;
		LineRenderer component = gameObject.GetComponent<LineRenderer>();
		component.AddComponent<SortingGroup>().sortingLayerName = "particle11";
		GameObject gameObject2 = component.gameObject;
		string text = "MainLaser";
		if (isExtra)
		{
			text = "ExtraLaser";
		}
		gameObject2.name = text;
		List<LineRenderer> list = this.allLasers;
		int size = list._size;
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x0008ED88 File Offset: 0x0008CF88
	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x4F81E0", Offset = "0x4F67E0", VA = "0x1804F81E0")]
	private void FadeLine()
	{
		int num = 0;
		this.KillLine(num != 0);
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x0008EDA0 File Offset: 0x0008CFA0
	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x4F89C0", Offset = "0x4F6FC0", VA = "0x1804F89C0")]
	private void KillLine(bool quick)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x0008EDC4 File Offset: 0x0008CFC4
	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x4F7940", Offset = "0x4F5F40", VA = "0x1804F7940", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.KillLine(true);
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x0008EDD8 File Offset: 0x0008CFD8
	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x4F8E50", Offset = "0x4F7450", VA = "0x1804F8E50")]
	private void RestShoots()
	{
		List<LineRenderer> list = this.allLasers;
		Transform transform = this.headPos;
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x0008EDFC File Offset: 0x0008CFFC
	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0x4F8380", Offset = "0x4F6980", VA = "0x1804F8380")]
	private void HitZombies(Vector2 startPositon, float angle, PlantType hitType = PlantType.Nothing)
	{
		int num = 0;
		Plant targetPlant = this.targetPlant;
		int num2 = 0;
		if (targetPlant != num2)
		{
			Plant targetPlant2 = this.targetPlant;
		}
		int num3;
		if (num3 == 2)
		{
		}
		bool flag;
		if (flag)
		{
		}
		if (hitType == PlantType.GoldThreePlantern)
		{
			Plant targetPlant3 = this.targetPlant;
		}
		LayerMask zombieLayer = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			int num4 = 0;
			Collider2D collider2D;
			if (collider2D != num4)
			{
				int num5 = 0;
				Collider2D collider2D2;
				bool flag2 = collider2D2.TryGetComponent<Zombie>(num5);
				if (flag2 && !flag2 && !flag2 && flag2 > true)
				{
					PlantType thePlantType = this.thePlantType;
					if (hitType == PlantType.UltimatePlantern)
					{
						PlantType thePlantType2 = this.thePlantType;
						ParticleManager instance = ParticleManager.Instance;
						num++;
					}
					if (hitType == PlantType.GoldThreePlantern)
					{
						this.board.GetMoney(50f);
					}
				}
			}
			num++;
		}
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x0008EEDC File Offset: 0x0008D0DC
	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x4F8A90", Offset = "0x4F7090", VA = "0x1804F8A90")]
	private void LookAtTargetPlant()
	{
		Transform shoot = this.targetPlant.shoot;
		float num;
		this.angle = num;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x0008EF04 File Offset: 0x0008D104
	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x4F7620", Offset = "0x4F5C20", VA = "0x1804F7620")]
	private float CalculateAngle(Vector2 targetPosition)
	{
		Transform transform = this.headPos;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		if (z3 > 180f)
		{
		}
		return z3;
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x0008EF48 File Offset: 0x0008D148
	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x4F7830", Offset = "0x4F5E30", VA = "0x1804F7830")]
	private float ClampAngle(float angle, float maxAngle)
	{
		if (global::Core.Lawnf.ValueBetween(maxAngle, angle, maxAngle))
		{
			return maxAngle;
		}
		return 0f;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x0008EF6C File Offset: 0x0008D16C
	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x4F77F0", Offset = "0x4F5DF0", VA = "0x1804F77F0")]
	private bool CanHitZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus == ZombieStatus.Snokle_inWater || theStatus == ZombieStatus.Miner_digging || theStatus > ZombieStatus.Dying)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x0008EFA0 File Offset: 0x0008D1A0
	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x4F8FC0", Offset = "0x4F75C0", VA = "0x1804F8FC0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		Transform shoot = this.shoot;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		float num2 = this.maxAngle;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(num);
		int num3 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			int num4 = 0;
			Collider2D collider2D;
			if (collider2D != num4)
			{
				int num5 = 0;
				Collider2D collider2D2;
				if (collider2D2.TryGetComponent<Zombie>(num5))
				{
					Transform shoot2 = this.shoot;
					Vector3 vector2;
					if (vector2 != (ulong)7L && vector2 != (ulong)12L && vector2 > (ulong)1L)
					{
						Transform shoot3 = this.shoot;
					}
				}
			}
			num++;
		}
		while (num2 >= num2)
		{
		}
		int num6 = 0;
		if (!(num != num6))
		{
		}
		float num7 = this.CalculateAngle(num6);
		bool flag;
		if (!flag)
		{
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0008F060 File Offset: 0x0008D260
	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x0008F070 File Offset: 0x0008D270
	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x4F8AF0", Offset = "0x4F70F0", VA = "0x1804F8AF0", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[16];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
		return true;
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x0008F0D0 File Offset: 0x0008D2D0
	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x4F9520", Offset = "0x4F7B20", VA = "0x1804F9520", Slot = "63")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			this.targetPlant = num2;
			int theMouseRow = mouse.theMouseRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow);
			bool flag;
			if (flag)
			{
				if (!flag)
				{
					while (!flag)
					{
					}
				}
				this.targetPlant = num;
			}
		}
		while (num2 != 0);
		bool flag2;
		if (!flag2)
		{
			Plant targetPlant = this.targetPlant;
			if (targetPlant.thePlantType == PlantType.UltimatePlantern || targetPlant.thePlantType != PlantType.GoldThreePlantern)
			{
			}
			Transform shoot = targetPlant.shoot;
			float num3;
			float num4;
			if (num3 > num4)
			{
			}
		}
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x0008F16C File Offset: 0x0008D36C
	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x4F9AD0", Offset = "0x4F80D0", VA = "0x1804F9AD0")]
	private void ValidateTargetPlant()
	{
		Plant targetPlant = this.targetPlant;
		int num = 0;
		if (!(targetPlant == num))
		{
			Plant targetPlant2 = this.targetPlant;
			int num2 = 0;
			if (targetPlant2.thePlantHealth <= num2)
			{
				throw new NullReferenceException();
			}
			int num3 = this.thePlantColumn;
			num3++;
			if (targetPlant2.thePlantColumn > num3)
			{
				if (targetPlant2.thePlantType != PlantType.UltimatePlantern && targetPlant2.thePlantType != PlantType.GoldThreePlantern)
				{
					this.targetPlant = num2;
				}
				Transform shoot = this.targetPlant.shoot;
				float num4 = this.maxAngle * 3f;
				float num5;
				if (num5 <= num4)
				{
					return;
				}
			}
			this.targetPlant = num2;
		}
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x0008F20C File Offset: 0x0008D40C
	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x4F9C40", Offset = "0x4F8240", VA = "0x1804F9C40")]
	public UltimateBigSniper()
	{
		List<LineRenderer> list = new List();
		this.allLasers = list;
		this.maxAngle = 10f;
		base..ctor();
	}

	// Token: 0x04000E7A RID: 3706
	[Token(Token = "0x4000E7A")]
	private const float ExtraLaserAngleOffset = 10f;

	// Token: 0x04000E7B RID: 3707
	[Token(Token = "0x4000E7B")]
	private const float LaserRangeMultiplier = 2f;

	// Token: 0x04000E7C RID: 3708
	[Token(Token = "0x4000E7C")]
	private const int BerzerkerThreshold = 500;

	// Token: 0x04000E7D RID: 3709
	[Token(Token = "0x4000E7D")]
	private const int BerzerkerImmuneThreshold = 1000;

	// Token: 0x04000E7E RID: 3710
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E7E")]
	public Transform headPos;

	// Token: 0x04000E7F RID: 3711
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E7F")]
	public GameObject laserPrefab;

	// Token: 0x04000E80 RID: 3712
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E80")]
	public Transform laserStart;

	// Token: 0x04000E81 RID: 3713
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000E81")]
	[SerializeField]
	private List<LineRenderer> allLasers;

	// Token: 0x04000E82 RID: 3714
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000E82")]
	private float angle;

	// Token: 0x04000E83 RID: 3715
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000E83")]
	private readonly float maxAngle;
}
