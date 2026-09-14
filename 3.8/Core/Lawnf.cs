using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Core
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class Lawnf
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x9CB430", Offset = "0x9C9A30", VA = "0x1809CB430")]
		public static Dictionary<T1, T2> ReflectGetDic<T1, T2>(string name, Action<T2> onLoad)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x8B1E40", Offset = "0x8B0440", VA = "0x1808B1E40")]
		public static void FromTo(Vector2 from, Vector2 to, int row, Transform parent, CancellationToken cancellationToken, Color color1, Color color2)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x8B2020", Offset = "0x8B0620", VA = "0x1808B2020")]
		public static Collider2D[] GetBoxCollidersFromOrigin(Vector2 origin, Vector2 direction, float length, float width, int layerMask = -1)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x8B2300", Offset = "0x8B0900", VA = "0x1808B2300")]
		public static Vector2[] GetCirclePoints(Vector2 center, float radius, int pointCount, float startAngle = 0f)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x8B2FA0", Offset = "0x8B15A0", VA = "0x1808B2FA0")]
		public static bool InRange(float a, float range1, float range2)
		{
			return default(bool);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x9CAB90", Offset = "0x9C9190", VA = "0x1809CAB90")]
		public static List<T> GetRandom<T>(List<T> list, int count)
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x8B2FE0", Offset = "0x8B15E0", VA = "0x1808B2FE0")]
		public static void LessThan(int min, int value)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x8B2FC0", Offset = "0x8B15C0", VA = "0x1808B2FC0")]
		public static void LessThan(float min, float value)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x8B2480", Offset = "0x8B0A80", VA = "0x1808B2480")]
		public static List<Collider2D> GetColInCone(Vector2 origin, Vector2 direction, float maxDistance, float coneAngle, LayerMask layerMask, int rayCount = 10)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9CA220", Offset = "0x9C8820", VA = "0x1809CA220")]
		public static Dictionary<TKey, Tvalue> GetDict<TKey, Tvalue>(string path, bool warning = true) where TKey : Enum where Tvalue : global::UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x8B2BD0", Offset = "0x8B11D0", VA = "0x1808B2BD0")]
		public static Quaternion GetRotateFromSpeed(Vector2 direction)
		{
			return default(Quaternion);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x8B2EF0", Offset = "0x8B14F0", VA = "0x1808B2EF0")]
		public static Vector2 GetVectorFromQuaternion(Quaternion quaternion)
		{
			return default(Vector2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x8B2E70", Offset = "0x8B1470", VA = "0x1808B2E70")]
		public static List<SpriteRenderer> GetSprites(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x8B2120", Offset = "0x8B0720", VA = "0x1808B2120")]
		public static List<GameObject> GetChilds(Transform transform)
		{
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x9C9C70", Offset = "0x9C8270", VA = "0x1809C9C70")]
		public static List<T> GetChilds<T>(Transform transform) where T : Component
		{
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x9CA580", Offset = "0x9C8B80", VA = "0x1809CA580")]
		public static T[] GetEnumValues<T>() where T : Enum
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x8B29D0", Offset = "0x8B0FD0", VA = "0x1808B29D0")]
		public static float GetRandomWithMean(float min, float max, float targetMean)
		{
			return 0f;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x8B2960", Offset = "0x8B0F60", VA = "0x1808B2960")]
		public static float GetRandomLogSymmetric(float minRatio, float maxRatio)
		{
			return 0f;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x8B1AE0", Offset = "0x8B00E0", VA = "0x1808B1AE0")]
		public static float[] CalculateProjectileWithSpeed(Vector2 projetilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x8B39C0", Offset = "0x8B1FC0", VA = "0x1808B39C0")]
		public static bool ValueBetween(float min, float value, float max)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x8B1A70", Offset = "0x8B0070", VA = "0x1808B1A70")]
		public static Vector2 CalculateProjectileWithGravity(Vector2 projectilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime, float gravity)
		{
			return default(Vector2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x8B2D10", Offset = "0x8B1310", VA = "0x1808B2D10")]
		public static List<SpriteRenderer> GetSortedSpriteRenderers(GameObject root)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x8B28B0", Offset = "0x8B0EB0", VA = "0x1808B28B0")]
		private static int GetFinalSortingOrder(SpriteRenderer sr)
		{
			return 0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x8B32F0", Offset = "0x8B18F0", VA = "0x1808B32F0")]
		public static bool LineIntersectsBounds(Vector3 start, Vector3 end, Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x8B2FF0", Offset = "0x8B15F0", VA = "0x1808B2FF0")]
		private static bool LineIntersectsAABBSlab(Vector3 start, Vector3 end, Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x8B2A90", Offset = "0x8B1090", VA = "0x1808B2A90")]
		public static Bounds GetRectWorldBounds(RectTransform rect)
		{
			return default(Bounds);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x8B3590", Offset = "0x8B1B90", VA = "0x1808B3590")]
		public static Task<AudioClip> LoadAudioClipFromFile(string filePath, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x8B38A0", Offset = "0x8B1EA0", VA = "0x1808B38A0")]
		private static Task<AudioClip> TryLoadAudioClip(string fullPath, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x9C9A80", Offset = "0x9C8080", VA = "0x1809C9A80")]
		public static void Foreach<T>(this IEnumerable<T> list, Action<T> action)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x8B1A30", Offset = "0x8B0030", VA = "0x1808B1A30")]
		public static string Before(this string str, string separator)
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x8B2C40", Offset = "0x8B1240", VA = "0x1808B2C40")]
		public static string GetSecondNumber(this string fileName)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x8B36E0", Offset = "0x8B1CE0", VA = "0x1808B36E0")]
		public static string ToDateTimeString(this long timestamp)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x8B37C0", Offset = "0x8B1DC0", VA = "0x1808B37C0")]
		public static string ToHourDateTimeString(this long timestamp)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x9C8D50", Offset = "0x9C7350", VA = "0x1809C8D50")]
		public static void Bounce<T>(this List<T> list, int count, Action<T> action, Func<T, bool> needRemove)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x8B1F70", Offset = "0x8B0570", VA = "0x1808B1F70")]
		public static string GetAfterNthUnderscore(this string str, int n)
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x8B39D0", Offset = "0x8B1FD0", VA = "0x1808B39D0")]
		public static Color With(this Color color, [Optional] float? r, [Optional] float? g, [Optional] float? b, [Optional] float? a)
		{
			return default(Color);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x8B36D0", Offset = "0x8B1CD0", VA = "0x1808B36D0")]
		public static int Multiply(this int value, float multiplier)
		{
			return 0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x8B36B0", Offset = "0x8B1CB0", VA = "0x1808B36B0")]
		public static int MultiplyPercent(this int value, float multiplier)
		{
			return 0;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x8B1C90", Offset = "0x8B0290", VA = "0x1808B1C90")]
		public static string FormatToChineseUnit(this long num)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x8B1D70", Offset = "0x8B0370", VA = "0x1808B1D70")]
		public static string FormatToChineseUnit(this int num)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x39C3C0", Offset = "0x39A9C0", VA = "0x18039C3C0")]
		public static int AtMost(this int num, int target)
		{
			return 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x8B1A20", Offset = "0x8B0020", VA = "0x1808B1A20")]
		public static int AtLeast(this int num, int target)
		{
			return 0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x8B1C50", Offset = "0x8B0250", VA = "0x1808B1C50")]
		public static void Do(this Action action, int count)
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		private static readonly Vector3[] cornersCache;
	}
}
