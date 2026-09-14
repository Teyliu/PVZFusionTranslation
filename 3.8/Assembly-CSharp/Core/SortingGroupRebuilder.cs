using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Core
{
	// Token: 0x02000A07 RID: 2567
	[Token(Token = "0x2000A07")]
	[DisallowMultipleComponent]
	public class SortingGroupRebuilder : MonoBehaviour
	{
		// Token: 0x060034B4 RID: 13492 RVA: 0x0011A074 File Offset: 0x00118274
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x73FCB0", Offset = "0x73E2B0", VA = "0x18073FCB0")]
		[ProButton]
		public void StartRebuild()
		{
			Transform transform = base.transform;
			Dictionary<SpriteRenderer, int> dictionary = new Dictionary();
			ulong num;
			this.Rebuild(transform, 1, (int)num, dictionary);
			if (this.reName)
			{
				Transform transform2 = base.transform;
				this.RebuildRename(transform2, 1, (int)num);
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x0011A0B4 File Offset: 0x001182B4
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x73F1D0", Offset = "0x73D7D0", VA = "0x18073F1D0")]
		private void Rebuild(Transform transform, int startOrder, [Out] int nextOrder, [Optional] Dictionary<SpriteRenderer, int> srToOrder)
		{
			for (;;)
			{
				int num = 0;
				List<ValueTuple<object, int, bool>> list = new List();
				int childCount = transform.childCount;
				if (num < childCount)
				{
					Transform child = transform.GetChild(num);
					bool flag = child.TryGetComponent<SortingGroup>(num);
					bool flag2 = child.TryGetComponent<SpriteRenderer>(num);
					if (!flag)
					{
						if (!flag2)
						{
						}
					}
					num++;
				}
				Func<ValueTuple<object, int, bool>, bool> func;
				if (SortingGroupRebuilder.<>c.<>9__2_0 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__2_0 = func;
				}
				List<ValueTuple<object, int, bool>> list2 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func));
				Func<ValueTuple<object, int, bool>, bool> func2;
				if (SortingGroupRebuilder.<>c.<>9__2_1 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__2_1 = func2;
				}
				List<ValueTuple<object, int, bool>> list3 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func2));
				Func<ValueTuple<object, int, bool>, int> func3;
				if (SortingGroupRebuilder.<>c.<>9__2_2 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__2_2 = func3;
				}
				List<ValueTuple<object, int, bool>> list4 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.OrderBy<ValueTuple<object, int, bool>, int>(list2, func3));
				bool flag3;
				if (flag3)
				{
					Transform transform2;
					if (transform2.childCount <= 0)
					{
						continue;
					}
					List<ValueTuple<SpriteRenderer, int>> list5 = new List();
					Comparison<ValueTuple<SpriteRenderer, int>> comparison;
					if (SortingGroupRebuilder.<>c.<>9__2_3 == 0)
					{
						SortingGroupRebuilder.<>c.<>9__2_3 = comparison;
					}
					list5.Sort(comparison);
					bool flag4;
					if (flag4)
					{
						num++;
					}
					if (num != 0)
					{
						goto IL_010A;
					}
				}
				if (num == 0)
				{
					int num2 = 0;
					bool flag5;
					if (flag5)
					{
					}
					if (num2 == 0)
					{
						break;
					}
				}
			}
			return;
			IL_010A:
			throw new NullReferenceException();
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x0011A1D4 File Offset: 0x001183D4
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x73E4E0", Offset = "0x73CAE0", VA = "0x18073E4E0")]
		private void CollectAllSpriteRenderers(Transform transform, [TupleElementNames(new string[] { "renderer", "originalOrder" })] List<ValueTuple<SpriteRenderer, int>> result)
		{
			int num = 0;
			if (!(transform == num))
			{
				GameObject gameObject = transform.gameObject;
				int num2 = 0;
				if (!(gameObject == num2))
				{
					SpriteRenderer component = transform.GetComponent<SpriteRenderer>();
					int num3 = 0;
					if (component != num3)
					{
						int sortingOrder = component.sortingOrder;
						int size = result._size;
					}
					int num4 = 0;
					int childCount = transform.childCount;
					if (num4 < childCount)
					{
						Transform transform2 = transform.GetChild(num4);
						this.CollectAllSpriteRenderers(transform2, result);
						num4++;
						result._size = transform2;
						transform2 += transform2;
					}
				}
			}
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x0011A268 File Offset: 0x00118468
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x73E700", Offset = "0x73CD00", VA = "0x18073E700")]
		private void RebuildRename(Transform transform, int startOrder, [Out] int nextOrder)
		{
			for (;;)
			{
				int num = 0;
				List<ValueTuple<object, int, bool>> list = new List();
				int childCount = transform.childCount;
				if (num < childCount)
				{
					Transform child = transform.GetChild(num);
					bool flag = child.TryGetComponent<SortingGroup>(num);
					bool flag2 = child.TryGetComponent<SpriteRenderer>(num);
					if (!flag)
					{
						if (!flag2)
						{
						}
					}
					num++;
				}
				Func<ValueTuple<object, int, bool>, bool> func;
				if (SortingGroupRebuilder.<>c.<>9__4_0 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__4_0 = func;
				}
				List<ValueTuple<object, int, bool>> list2 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func));
				Func<ValueTuple<object, int, bool>, bool> func2;
				if (SortingGroupRebuilder.<>c.<>9__4_1 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__4_1 = func2;
				}
				List<ValueTuple<object, int, bool>> list3 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func2));
				Func<ValueTuple<object, int, bool>, int> func3;
				if (SortingGroupRebuilder.<>c.<>9__4_2 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__4_2 = func3;
				}
				List<ValueTuple<object, int, bool>> list4 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.OrderBy<ValueTuple<object, int, bool>, int>(list2, func3));
				bool flag3;
				if (flag3)
				{
					string text2;
					string text = "order:" + text2;
					Transform transform2;
					if (transform2.childCount <= 0)
					{
						continue;
					}
					while (this == 0)
					{
					}
					while (this == 0)
					{
					}
					List<ValueTuple<SpriteRenderer, int>> list5 = new List();
					Transform transform3 = base.transform;
					this.CollectAllSpriteRenderers(transform3, list5);
					Comparison<ValueTuple<SpriteRenderer, int>> comparison;
					if (SortingGroupRebuilder.<>c.<>9__4_3 == 0)
					{
						SortingGroupRebuilder.<>c.<>9__4_3 = comparison;
					}
					list5.Sort(comparison);
					bool flag4;
					if (flag4)
					{
						string text4;
						string text3 = "order:" + text4;
					}
					if (num != 0)
					{
						goto IL_013C;
					}
				}
				if (num == 0)
				{
					int num2 = 0;
					bool flag5;
					if (flag5)
					{
					}
					if (num2 == 0)
					{
						break;
					}
				}
			}
			return;
			IL_013C:
			throw new NullReferenceException();
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x0011A3B8 File Offset: 0x001185B8
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public SortingGroupRebuilder()
		{
		}

		// Token: 0x040027F9 RID: 10233
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40027F9")]
		public bool reName;
	}
}
