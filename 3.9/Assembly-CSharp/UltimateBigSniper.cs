using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005CC RID: 1484
[Token(Token = "0x20005CC")]
public class UltimateBigSniper : Shooter
{
	// Token: 0x06001B72 RID: 7026 RVA: 0x00092E20 File Offset: 0x00091020
	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x556F60", Offset = "0x555560", VA = "0x180556F60", Slot = "16")]
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

	// Token: 0x06001B73 RID: 7027 RVA: 0x00092E6C File Offset: 0x0009106C
	[Token(Token = "0x6001B73")]
	[Address(RVA = "0x556290", Offset = "0x554890", VA = "0x180556290", Slot = "44")]
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

	// Token: 0x06001B74 RID: 7028 RVA: 0x00092EF0 File Offset: 0x000910F0
	[Token(Token = "0x6001B74")]
	[Address(RVA = "0x5557A0", Offset = "0x553DA0", VA = "0x1805557A0")]
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

	// Token: 0x06001B75 RID: 7029 RVA: 0x00092F18 File Offset: 0x00091118
	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x554D20", Offset = "0x553320", VA = "0x180554D20")]
	private float CalculateBaseDamage()
	{
		return 0f;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x00092F2C File Offset: 0x0009112C
	[Token(Token = "0x6001B76")]
	[Address(RVA = "0x554B50", Offset = "0x553150", VA = "0x180554B50")]
	private float ApplyLowHealthBonus(float dmg)
	{
		if (global::Lawnf.TravelUltimateLevel((UltiBuff)((uint)21)) == 2)
		{
		}
		return dmg;
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x00092F48 File Offset: 0x00091148
	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x554B90", Offset = "0x553190", VA = "0x180554B90")]
	private float ApplyUltimateBuffs(float dmg)
	{
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)20)))
		{
		}
		return dmg;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x00092F68 File Offset: 0x00091168
	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x554EA0", Offset = "0x5534A0", VA = "0x180554EA0")]
	private void ConsumeHealthIfHigh()
	{
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x00092F78 File Offset: 0x00091178
	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x5558A0", Offset = "0x553EA0", VA = "0x1805558A0", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)21)))
		{
		}
		return base.GetDamage(damage);
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x00092FA8 File Offset: 0x000911A8
	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x556DA0", Offset = "0x5553A0", VA = "0x180556DA0", Slot = "68")]
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

	// Token: 0x06001B7B RID: 7035 RVA: 0x00092FFC File Offset: 0x000911FC
	[Token(Token = "0x6001B7B")]
	[Address(RVA = "0x555170", Offset = "0x553770", VA = "0x180555170")]
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

	// Token: 0x06001B7C RID: 7036 RVA: 0x000930F8 File Offset: 0x000912F8
	[Token(Token = "0x6001B7C")]
	[Address(RVA = "0x554F00", Offset = "0x553500", VA = "0x180554F00")]
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

	// Token: 0x06001B7D RID: 7037 RVA: 0x00093174 File Offset: 0x00091374
	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x555790", Offset = "0x553D90", VA = "0x180555790")]
	private void FadeLine()
	{
		int num = 0;
		this.KillLine(num != 0);
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x0009318C File Offset: 0x0009138C
	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x555F70", Offset = "0x554570", VA = "0x180555F70")]
	private void KillLine(bool quick)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x000931B0 File Offset: 0x000913B0
	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x554EF0", Offset = "0x5534F0", VA = "0x180554EF0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.KillLine(true);
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x000931C4 File Offset: 0x000913C4
	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x556400", Offset = "0x554A00", VA = "0x180556400")]
	private void RestShoots()
	{
		List<LineRenderer> list = this.allLasers;
		Transform transform = this.headPos;
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000931E8 File Offset: 0x000913E8
	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x555930", Offset = "0x553F30", VA = "0x180555930")]
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

	// Token: 0x06001B82 RID: 7042 RVA: 0x000932C8 File Offset: 0x000914C8
	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x556040", Offset = "0x554640", VA = "0x180556040")]
	private void LookAtTargetPlant()
	{
		Transform shoot = this.targetPlant.shoot;
		float num;
		this.angle = num;
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x000932F0 File Offset: 0x000914F0
	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x554BD0", Offset = "0x5531D0", VA = "0x180554BD0")]
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

	// Token: 0x06001B84 RID: 7044 RVA: 0x00093334 File Offset: 0x00091534
	[Token(Token = "0x6001B84")]
	[Address(RVA = "0x554DE0", Offset = "0x5533E0", VA = "0x180554DE0")]
	private float ClampAngle(float angle, float maxAngle)
	{
		if (global::Core.Lawnf.ValueBetween(maxAngle, angle, maxAngle))
		{
			return maxAngle;
		}
		return 0f;
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x00093358 File Offset: 0x00091558
	[Token(Token = "0x6001B85")]
	[Address(RVA = "0x554DA0", Offset = "0x5533A0", VA = "0x180554DA0")]
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

	// Token: 0x06001B86 RID: 7046 RVA: 0x0009338C File Offset: 0x0009158C
	[Token(Token = "0x6001B86")]
	[Address(RVA = "0x556570", Offset = "0x554B70", VA = "0x180556570", Slot = "43")]
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

	// Token: 0x06001B87 RID: 7047 RVA: 0x0009344C File Offset: 0x0009164C
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x0009345C File Offset: 0x0009165C
	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x5560A0", Offset = "0x5546A0", VA = "0x1805560A0", Slot = "61")]
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

	// Token: 0x06001B89 RID: 7049 RVA: 0x000934BC File Offset: 0x000916BC
	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x556AD0", Offset = "0x5550D0", VA = "0x180556AD0", Slot = "62")]
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

	// Token: 0x06001B8A RID: 7050 RVA: 0x00093558 File Offset: 0x00091758
	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x557080", Offset = "0x555680", VA = "0x180557080")]
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

	// Token: 0x06001B8B RID: 7051 RVA: 0x000935F8 File Offset: 0x000917F8
	[Token(Token = "0x6001B8B")]
	[Address(RVA = "0x5571F0", Offset = "0x5557F0", VA = "0x1805571F0")]
	public UltimateBigSniper()
	{
		List<LineRenderer> list = new List();
		this.allLasers = list;
		this.maxAngle = 10f;
		base..ctor();
	}

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000F39")]
	private const float ExtraLaserAngleOffset = 10f;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000F3A")]
	private const float LaserRangeMultiplier = 2f;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000F3B")]
	private const int BerzerkerThreshold = 500;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000F3C")]
	private const int BerzerkerImmuneThreshold = 1000;

	// Token: 0x04000F3D RID: 3901
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F3D")]
	public Transform headPos;

	// Token: 0x04000F3E RID: 3902
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F3E")]
	public GameObject laserPrefab;

	// Token: 0x04000F3F RID: 3903
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F3F")]
	public Transform laserStart;

	// Token: 0x04000F40 RID: 3904
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000F40")]
	[SerializeField]
	private List<LineRenderer> allLasers;

	// Token: 0x04000F41 RID: 3905
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000F41")]
	private float angle;

	// Token: 0x04000F42 RID: 3906
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000F42")]
	private readonly float maxAngle;
}
