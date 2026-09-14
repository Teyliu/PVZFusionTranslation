using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Core
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public static class Lawnf
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA79FC0", Offset = "0xA785C0", VA = "0x180A79FC0")]
		public static Dictionary<T1, T2> ReflectGetDic<T1, T2>(string name, Action<T2> onLoad)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x941D30", Offset = "0x940330", VA = "0x180941D30")]
		public static void FromTo(Vector2 from, Vector2 to, int row, Transform parent, CancellationToken cancellationToken, Color color1, Color color2)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x941F10", Offset = "0x940510", VA = "0x180941F10")]
		public static Collider2D[] GetBoxCollidersFromOrigin(Vector2 origin, Vector2 direction, float length, float width, int layerMask = -1)
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x9421F0", Offset = "0x9407F0", VA = "0x1809421F0")]
		public static Vector2[] GetCirclePoints(Vector2 center, float radius, int pointCount, float startAngle = 0f)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x942E90", Offset = "0x941490", VA = "0x180942E90")]
		public static bool InRange(float a, float range1, float range2)
		{
			return default(bool);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA78DE0", Offset = "0xA773E0", VA = "0x180A78DE0")]
		public static List<T> GetRandom<T>(List<T> list, int count)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x942ED0", Offset = "0x9414D0", VA = "0x180942ED0")]
		public static void LessThan(int min, int value)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x942EB0", Offset = "0x9414B0", VA = "0x180942EB0")]
		public static void LessThan(float min, float value)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x942370", Offset = "0x940970", VA = "0x180942370")]
		public static List<Collider2D> GetColInCone(Vector2 origin, Vector2 direction, float maxDistance, float coneAngle, LayerMask layerMask, int rayCount = 10)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xA78470", Offset = "0xA76A70", VA = "0x180A78470")]
		public static Dictionary<TKey, Tvalue> GetDict<TKey, Tvalue>(string path, bool warning = true) where TKey : Enum where Tvalue : global::UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x942AC0", Offset = "0x9410C0", VA = "0x180942AC0")]
		public static Quaternion GetRotateFromSpeed(Vector2 direction)
		{
			return default(Quaternion);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x942DE0", Offset = "0x9413E0", VA = "0x180942DE0")]
		public static Vector2 GetVectorFromQuaternion(Quaternion quaternion)
		{
			return default(Vector2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x942D60", Offset = "0x941360", VA = "0x180942D60")]
		public static List<SpriteRenderer> GetSprites(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x942010", Offset = "0x940610", VA = "0x180942010")]
		public static List<GameObject> GetChilds(Transform transform)
		{
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0xA77EC0", Offset = "0xA764C0", VA = "0x180A77EC0")]
		public static List<T> GetChilds<T>(Transform transform) where T : Component
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0xA787D0", Offset = "0xA76DD0", VA = "0x180A787D0")]
		public static T[] GetEnumValues<T>() where T : Enum
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x9428C0", Offset = "0x940EC0", VA = "0x1809428C0")]
		public static float GetRandomWithMean(float min, float max, float targetMean)
		{
			return 0f;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x942850", Offset = "0x940E50", VA = "0x180942850")]
		public static float GetRandomLogSymmetric(float minRatio, float maxRatio)
		{
			return 0f;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x9419D0", Offset = "0x93FFD0", VA = "0x1809419D0")]
		public static float[] CalculateProjectileWithSpeed(Vector2 projetilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x943A50", Offset = "0x942050", VA = "0x180943A50")]
		public static bool ValueBetween(float min, float value, float max)
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x941960", Offset = "0x93FF60", VA = "0x180941960")]
		public static Vector2 CalculateProjectileWithGravity(Vector2 projectilePosition, Vector2 targetVelocity, Vector2 targetCurrentPosition, float flightTime, float gravity)
		{
			return default(Vector2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x942C00", Offset = "0x941200", VA = "0x180942C00")]
		public static List<SpriteRenderer> GetSortedSpriteRenderers(GameObject root)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x9427A0", Offset = "0x940DA0", VA = "0x1809427A0")]
		private static int GetFinalSortingOrder(SpriteRenderer sr)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x9431E0", Offset = "0x9417E0", VA = "0x1809431E0")]
		public static bool LineIntersectsBounds(Vector3 start, Vector3 end, Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x942EE0", Offset = "0x9414E0", VA = "0x180942EE0")]
		private static bool LineIntersectsAABBSlab(Vector3 start, Vector3 end, Bounds bounds)
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x942980", Offset = "0x940F80", VA = "0x180942980")]
		public static Bounds GetRectWorldBounds(RectTransform rect)
		{
			return default(Bounds);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x943480", Offset = "0x941A80", VA = "0x180943480")]
		public static Task<AudioClip> LoadAudioClipFromFile(string filePath, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x9437E0", Offset = "0x941DE0", VA = "0x1809437E0")]
		private static Task<AudioClip> TryLoadAudioClip(string fullPath, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA77CD0", Offset = "0xA762D0", VA = "0x180A77CD0")]
		public static void Foreach<T>(this IEnumerable<T> list, Action<T> action)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x9418E0", Offset = "0x93FEE0", VA = "0x1809418E0")]
		public static string Before(this string str, string separator)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x941850", Offset = "0x93FE50", VA = "0x180941850")]
		public static string After(this string str, string separator)
		{
			return null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x941920", Offset = "0x93FF20", VA = "0x180941920")]
		public static string Before(this string str, char separator)
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x941800", Offset = "0x93FE00", VA = "0x180941800")]
		public static string After(this string str, char separator)
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x943900", Offset = "0x941F00", VA = "0x180943900")]
		public static bool TrySplitOut(this string str, char separator, [Out] string left, [Out] string right)
		{
			return default(bool);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x942B30", Offset = "0x941130", VA = "0x180942B30")]
		public static string GetSecondNumber(this string fileName)
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x943610", Offset = "0x941C10", VA = "0x180943610")]
		public static string ToDateTimeString(this long timestamp)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x9436F0", Offset = "0x941CF0", VA = "0x1809436F0")]
		public static string ToHourDateTimeString(this long timestamp)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA76FA0", Offset = "0xA755A0", VA = "0x180A76FA0")]
		public static void Bounce<T>(this List<T> list, int count, Action<T> action, Func<T, bool> needRemove)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x941E60", Offset = "0x940460", VA = "0x180941E60")]
		public static string GetAfterNthUnderscore(this string str, int n)
		{
			return null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x943A60", Offset = "0x942060", VA = "0x180943A60")]
		public static Color With(this Color color, [Optional] float? r, [Optional] float? g, [Optional] float? b, [Optional] float? a)
		{
			return default(Color);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x943600", Offset = "0x941C00", VA = "0x180943600")]
		public static int Multiply(this int value, float multiplier)
		{
			return 0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x9435E0", Offset = "0x941BE0", VA = "0x1809435E0")]
		public static long Multiply(this long value, float multiplier)
		{
			return 0L;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x9435A0", Offset = "0x941BA0", VA = "0x1809435A0")]
		public static int MultiplyPercent(this int value, float multiplier)
		{
			return 0;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x9435C0", Offset = "0x941BC0", VA = "0x1809435C0")]
		public static long MultiplyPercent(this long value, float multiplier)
		{
			return 0L;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x941B80", Offset = "0x940180", VA = "0x180941B80")]
		public static string FormatToChineseUnit(this long num)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x941C60", Offset = "0x940260", VA = "0x180941C60")]
		public static string FormatToChineseUnit(this int num)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3E83D0", Offset = "0x3E69D0", VA = "0x1803E83D0")]
		public static int AtMost(this int num, int target)
		{
			return 0;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x9418B0", Offset = "0x93FEB0", VA = "0x1809418B0")]
		public static int AtLeast(this int num, int target)
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x9418D0", Offset = "0x93FED0", VA = "0x1809418D0")]
		public static float AtMost(this float num, float target)
		{
			return 0f;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x9418C0", Offset = "0x93FEC0", VA = "0x1809418C0")]
		public static float AtLeast(this float num, float target)
		{
			return 0f;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x941B40", Offset = "0x940140", VA = "0x180941B40")]
		public static void Do(this Action action, int count)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x9437D0", Offset = "0x941DD0", VA = "0x1809437D0")]
		public static int ToInt(this long num)
		{
			return 0;
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		private static readonly Vector3[] cornersCache;
	}
}
