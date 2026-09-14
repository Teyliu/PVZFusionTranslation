using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001DF RID: 479
[Token(Token = "0x20001DF")]
public class LaserBullet : MonoBehaviour
{
	// Token: 0x0600081A RID: 2074 RVA: 0x00029028 File Offset: 0x00027228
	[Token(Token = "0x600081A")]
	[Address(RVA = "0x8FA140", Offset = "0x8F8740", VA = "0x1808FA140")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00029044 File Offset: 0x00027244
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x8FB420", Offset = "0x8F9A20", VA = "0x1808FB420")]
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

	// Token: 0x0600081C RID: 2076 RVA: 0x000290E0 File Offset: 0x000272E0
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x8FB040", Offset = "0x8F9640", VA = "0x1808FB040")]
	public static LaserBullet SetLaser(Board board, int row, Vector2 from, Vector2 direction, float distance, PlantType fromType, float lifeTime = 0.3f, [Optional] Action action)
	{
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		LaserBullet laserBullet;
		LineRenderer lineRenderer = laserBullet.lineRenderer;
		return laserBullet;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00029120 File Offset: 0x00027320
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x8FA190", Offset = "0x8F8790", VA = "0x1808FA190")]
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

	// Token: 0x0600081E RID: 2078 RVA: 0x00029194 File Offset: 0x00027394
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x8FA3D0", Offset = "0x8F89D0", VA = "0x1808FA3D0")]
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

	// Token: 0x0600081F RID: 2079 RVA: 0x00029228 File Offset: 0x00027428
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x8F98C0", Offset = "0x8F7EC0", VA = "0x1808F98C0")]
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

	// Token: 0x06000820 RID: 2080 RVA: 0x000292D8 File Offset: 0x000274D8
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x8F9BC0", Offset = "0x8F81C0", VA = "0x1808F9BC0")]
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

	// Token: 0x06000821 RID: 2081 RVA: 0x00029334 File Offset: 0x00027534
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x8F9560", Offset = "0x8F7B60", VA = "0x1808F9560")]
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

	// Token: 0x06000822 RID: 2082 RVA: 0x000293B0 File Offset: 0x000275B0
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x8F9FF0", Offset = "0x8F85F0", VA = "0x1808F9FF0")]
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

	// Token: 0x06000823 RID: 2083 RVA: 0x00029408 File Offset: 0x00027608
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x8FA6A0", Offset = "0x8F8CA0", VA = "0x1808FA6A0")]
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

	// Token: 0x06000824 RID: 2084 RVA: 0x00029498 File Offset: 0x00027698
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x8F9D80", Offset = "0x8F8380", VA = "0x1808F9D80")]
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
					long currentFirstHealth = collider2D2.GetComponent<Zombie>().CurrentFirstHealth;
				}
				num++;
			}
		}
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x000294F4 File Offset: 0x000276F4
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x8FABD0", Offset = "0x8F91D0", VA = "0x1808FABD0")]
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

	// Token: 0x06000826 RID: 2086 RVA: 0x0002963C File Offset: 0x0002783C
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x8FB2A0", Offset = "0x8F98A0", VA = "0x1808FB2A0")]
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

	// Token: 0x06000827 RID: 2087 RVA: 0x000296A0 File Offset: 0x000278A0
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x8FAB20", Offset = "0x8F9120", VA = "0x1808FAB20")]
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

	// Token: 0x06000828 RID: 2088 RVA: 0x000296C8 File Offset: 0x000278C8
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LaserBullet()
	{
	}

	// Token: 0x040003C5 RID: 965
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C5")]
	private LineRenderer lineRenderer;

	// Token: 0x040003C6 RID: 966
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003C6")]
	private float lifeTime;

	// Token: 0x040003C7 RID: 967
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003C7")]
	private float maxLifeTime;

	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	private struct HitResult
	{
		// Token: 0x040003C8 RID: 968
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C8")]
		public Vector2 hitPoint;

		// Token: 0x040003C9 RID: 969
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003C9")]
		public LaserBullet.HitType hitType;

		// Token: 0x040003CA RID: 970
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003CA")]
		public Plant threePlanternPlant;
	}

	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	private enum HitType
	{
		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		Normal,
		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		Ice,
		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		Doom,
		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		Three
	}
}
