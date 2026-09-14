using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E56 RID: 3670
	[Token(Token = "0x2000E56")]
	public struct PacketHeader
	{
		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x00172558 File Offset: 0x00170758
		[Token(Token = "0x17000975")]
		public int BodyLength
		{
			[Token(Token = "0x6004B5F")]
			[Address(RVA = "0x8CEE90", Offset = "0x8CD490", VA = "0x1808CEE90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00172568 File Offset: 0x00170768
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x8CEA60", Offset = "0x8CD060", VA = "0x1808CEA60")]
		public PacketHeader(ReadOnlySpan<byte> bytes)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num = bytes._length;
			num += -4;
			if (num < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int num2 = bytes._length;
			num2 += -6;
			if (num2 < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int num3 = bytes._length;
			num3 += -8;
			if (num3 < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int num4 = bytes._length;
			num4 += -12;
			if (num4 < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x001725EC File Offset: 0x001707EC
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x8CEEA0", Offset = "0x8CD4A0", VA = "0x1808CEEA0")]
		public static explicit operator ReadOnlySpan<byte>(PacketHeader header)
		{
			return default(ReadOnlySpan<byte>);
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00172604 File Offset: 0x00170804
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x8CE620", Offset = "0x8CCC20", VA = "0x1808CE620")]
		public static byte[] GetBytes(int packetLength, short headerLength, ProtocolVersion protocolVersion, Operation operation, int sequenceId = 1)
		{
			byte[] array = new byte[16];
			if (array != 0)
			{
			}
			if (array < (ulong)4L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			byte b;
			b.m_value = (byte)packetLength;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			byte b2;
			b2.m_value = (byte)headerLength;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			byte b3;
			b3.m_value = (byte)protocolVersion;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			byte b4;
			b4.m_value = (byte)operation;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			byte[] array2;
			return array2;
		}

		// Token: 0x04003595 RID: 13717
		[Token(Token = "0x4003595")]
		public const int KPacketHeaderLength = 16;

		// Token: 0x04003596 RID: 13718
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003596")]
		public int PacketLength;

		// Token: 0x04003597 RID: 13719
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4003597")]
		public short HeaderLength;

		// Token: 0x04003598 RID: 13720
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003598")]
		public ProtocolVersion ProtocolVersion;

		// Token: 0x04003599 RID: 13721
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4003599")]
		public Operation Operation;

		// Token: 0x0400359A RID: 13722
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400359A")]
		public int SequenceId;
	}
}
