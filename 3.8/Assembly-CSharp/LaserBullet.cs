using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x20001D5")]
public class LaserBullet : MonoBehaviour
{
	// Token: 0x06000804 RID: 2052 RVA: 0x00029468 File Offset: 0x00027668
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x86B3F0", Offset = "0x8699F0", VA = "0x18086B3F0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00029484 File Offset: 0x00027684
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x86C6D0", Offset = "0x86ACD0", VA = "0x18086C6D0")]
	private void Update()
	{
		float num = this.lifeTime;
		float deltaTime = Time.deltaTime;
		this.lifeTime = num;
		float num2 = this.lifeTime;
		int num3 = 0;
		if (num3 > (int)num2 || num2 > 1f)
		{
		}
		Gradient colorGradient = this.lineRenderer.colorGradient;
		GradientAlphaKey[] array = new GradientAlphaKey[2];
		int num4 = 0;
		int num5 = 0;
		array[0] = num4;
		array[1] = num5;
		colorGradient.alphaKeys = array;
		this.lineRenderer.colorGradient = colorGradient;
		if (num3 > (int)this.lifeTime)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00029520 File Offset: 0x00027720
	[Token(Token = "0x6000806")]
	[Address(RVA = "0x86C2F0", Offset = "0x86A8F0", VA = "0x18086C2F0")]
	public static LaserBullet SetLaser(Board board, int row, Vector2 from, Vector2 direction, float distance, PlantType fromType, float lifeTime = 0.3f, [Optional] Action action)
	{
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		LaserBullet laserBullet;
		LineRenderer lineRenderer = laserBullet.lineRenderer;
		return laserBullet;
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00029560 File Offset: 0x00027760
	[Token(Token = "0x6000807")]
	[Address(RVA = "0x86B440", Offset = "0x869A40", VA = "0x18086B440")]
	private static LaserBullet CreateLaserGameObject(Board board, int row, Vector2 from, Vector2 direction, float distance, float lifeTime)
	{
		GameObject gameObject = Resources.Load<GameObject>("Bullet/Laser");
		Transform transform = board.transform;
		LaserBullet component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<LaserBullet>();
		component.lifeTime = (float)0;
		component.maxLifeTime = (float)0;
		SortingGroup sortingGroup = component.AddComponent<SortingGroup>();
		string text = string.Format("particle{0}", sortingGroup);
		sortingGroup.sortingLayerName = text;
		LineRenderer lineRenderer = component.lineRenderer;
		LineRenderer lineRenderer2 = component.lineRenderer;
		return component;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x000295D4 File Offset: 0x000277D4
	[Token(Token = "0x6000808")]
	[Address(RVA = "0x86B680", Offset = "0x869C80", VA = "0x18086B680")]
	private static LaserBullet.HitResult DetectPlantsOnLaserPath(Vector2 from, Vector2 direction, float distance, int row)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		from.x = (float)num;
		from.x = (float)num;
		int mask = LayerMask.GetMask(new string[] { "Plant" });
		RaycastHit2D[] array;
		if (num3 < array.Length)
		{
			int num4 = 0;
			Collider2D collider2D;
			bool flag = collider2D.TryGetComponent<Plant>(num4);
			if (flag)
			{
				from.x = (float)num;
				from.y = (float)num2;
				if (flag || flag || flag)
				{
					goto IL_0075;
				}
			}
			num3++;
		}
		IL_0075:
		throw new NullReferenceException();
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00029668 File Offset: 0x00027868
	[Token(Token = "0x6000809")]
	[Address(RVA = "0x86AB70", Offset = "0x869170", VA = "0x18086AB70")]
	private static void ApplyHitTypeEffects(LaserBullet.HitType hitType, Plant threePlanternPlant, RaycastHit2D[] zombieHits, int row, PlantType fromType, float distance, Board board)
	{
		if (hitType == LaserBullet.HitType.Ice)
		{
			int num = 0;
			if (!(threePlanternPlant == num))
			{
				int thePlantRow = threePlanternPlant.thePlantRow;
				int attackDamage = threePlanternPlant.attackDamage;
				Transform shoot = threePlanternPlant.shoot;
				int thePlantRow2 = threePlanternPlant.thePlantRow;
				Transform shoot2 = threePlanternPlant.shoot2;
				uint num2;
				GameAPP.PlaySound((int)num2, 0.5f, 1f);
			}
		}
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00029718 File Offset: 0x00027918
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x86AE70", Offset = "0x869470", VA = "0x18086AE70")]
	private static void ApplyIceEffect(RaycastHit2D[] hits, int row)
	{
		int num = 0;
		int num2 = 0;
		if (num < hits.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Zombie>(num2) && Lawnf.InLandStatus((ZombieStatus)num2))
			{
				Collider2D collider2D2;
				Zombie component = collider2D2.GetComponent<Zombie>();
				int num3 = 0;
				int num4 = 0;
				component.SetCold(10f, num4, num3 != 0);
			}
			num2++;
		}
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00029774 File Offset: 0x00027974
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x86A810", Offset = "0x868E10", VA = "0x18086A810")]
	private static void ApplyDoomEffect(RaycastHit2D[] hits, int row, PlantType fromType)
	{
		int num = 0;
		int num2 = 0;
		if (num < hits.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Zombie>(num2) && Lawnf.InLandStatus((ZombieStatus)num2))
			{
				Collider2D collider2D2;
				Zombie component = collider2D2.GetComponent<Zombie>();
				int mask = LayerMask.GetMask(new string[] { "Zombie" });
			}
			num2++;
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x000297F0 File Offset: 0x000279F0
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x86B2A0", Offset = "0x8698A0", VA = "0x18086B2A0")]
	private static void ApplyThreePlanternEffect(Plant threePlantern, RaycastHit2D[] hits, int row, PlantType fromType, float distance, Board board)
	{
		int num = 0;
		if (!(threePlantern == num))
		{
			int thePlantRow = threePlantern.thePlantRow;
			Transform shoot = threePlantern.shoot;
			int attackDamage = threePlantern.attackDamage;
			int thePlantRow2 = threePlantern.thePlantRow;
			Transform shoot2 = threePlantern.shoot2;
			GameAPP.PlaySound(80, 0.5f, 1f);
		}
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00029848 File Offset: 0x00027A48
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x86B950", Offset = "0x869F50", VA = "0x18086B950")]
	private static void FireExtraLaserFromTransform(Transform shootTransform, int row, PlantType fromType, float distance, int damage, Board board, int laserRow)
	{
		int num = 0;
		if (!(shootTransform == num))
		{
			Vector2 rightVector = Vector2.rightVector;
			int num2 = 0;
			LaserBullet laserBullet;
			LineRenderer lineRenderer = laserBullet.lineRenderer;
			Vector2 rightVector2 = Vector2.rightVector;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			RaycastHit2D[] array;
			if (num2 < array.Length)
			{
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(num2) && Lawnf.InLandStatus((ZombieStatus)num2))
				{
					Collider2D collider2D2;
					Zombie component = collider2D2.GetComponent<Zombie>();
				}
				num2++;
			}
		}
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x000298D8 File Offset: 0x00027AD8
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x86B030", Offset = "0x869630", VA = "0x18086B030")]
	private static void ApplySpecialLevelDamage(RaycastHit2D[] hits, int row, PlantType fromType)
	{
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
			int num = 0;
			if (num < hits.Length)
			{
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(num) && Lawnf.InLandStatus((ZombieStatus)num))
				{
					Collider2D collider2D2;
					int currentFirstHealth = collider2D2.GetComponent<Zombie>().CurrentFirstHealth;
				}
				num++;
			}
		}
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00029934 File Offset: 0x00027B34
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x86BE80", Offset = "0x86A480", VA = "0x18086BE80")]
	private static void SetLaserColorGradient(LineRenderer line, LaserBullet.HitType hitType, Vector2 from, Vector2 hitPoint, float totalDistance)
	{
		Gradient gradient = new Gradient();
		if (hitType == LaserBullet.HitType.Ice)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			int num = 0;
			int num2 = 0;
			array[0] = num;
			array[2] = num2;
			int num3 = 0;
			int num4 = 0;
			array[2] = num3;
			array[4] = num4;
			int num5 = 0;
			int num6 = 0;
			array[5] = num5;
			array[7] = num6;
			int num7 = 0;
			int num8 = 0;
			array[7] = num7;
			array[9] = num8;
		}
		if (hitType == LaserBullet.HitType.Doom)
		{
			GradientColorKey[] array2 = new GradientColorKey[4];
			int num9 = 0;
			int num10 = 0;
			array2[0] = num9;
			array2[2] = num10;
			int num11 = 0;
			int num12 = 0;
			array2[2] = num11;
			array2[4] = num12;
			int num13 = 0;
			int num14 = 0;
			array2[5] = num13;
			array2[7] = num14;
			int num15 = 0;
			int num16 = 0;
			array2[7] = num15;
			array2[9] = num16;
		}
		GradientColorKey[] array3 = new GradientColorKey[2];
		int num17 = 0;
		int num18 = 0;
		array3[0] = num17;
		array3[2] = num18;
		int num19 = 0;
		int num20 = 0;
		array3[2] = num19;
		array3[4] = num20;
		gradient.colorKeys = array3;
		line.colorGradient = gradient;
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00029A7C File Offset: 0x00027C7C
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x86C550", Offset = "0x86AB50", VA = "0x18086C550")]
	private void UpdateAlpha()
	{
		float num = this.lifeTime;
		if (0 > (int)num || num > 1f)
		{
		}
		Gradient colorGradient = this.lineRenderer.colorGradient;
		GradientAlphaKey[] array = new GradientAlphaKey[2];
		int num2 = 0;
		int num3 = 0;
		array[0] = num2;
		array[1] = num3;
		colorGradient.alphaKeys = array;
		this.lineRenderer.colorGradient = colorGradient;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00029AE0 File Offset: 0x00027CE0
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x86BDD0", Offset = "0x86A3D0", VA = "0x18086BDD0")]
	private static bool IsValidZombieTarget(RaycastHit2D hit, int row)
	{
		Collider2D collider = hit.collider;
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00029B08 File Offset: 0x00027D08
	[Token(Token = "0x6000812")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LaserBullet()
	{
	}

	// Token: 0x040003BB RID: 955
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003BB")]
	private LineRenderer lineRenderer;

	// Token: 0x040003BC RID: 956
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003BC")]
	private float lifeTime;

	// Token: 0x040003BD RID: 957
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003BD")]
	private float maxLifeTime;

	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	private struct HitResult
	{
		// Token: 0x040003BE RID: 958
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003BE")]
		public Vector2 hitPoint;

		// Token: 0x040003BF RID: 959
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003BF")]
		public LaserBullet.HitType hitType;

		// Token: 0x040003C0 RID: 960
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003C0")]
		public Plant threePlanternPlant;
	}

	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	private enum HitType
	{
		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		Normal,
		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		Ice,
		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		Doom,
		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		Three
	}
}
