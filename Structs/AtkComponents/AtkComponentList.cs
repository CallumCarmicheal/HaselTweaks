using FFXIVClientStructs.FFXIV.Component.GUI;

namespace HaselTweaks.Structs;

// ctor "E8 ?? ?? ?? ?? 33 C9 48 8D 05 ?? ?? ?? ?? 48 89 03 48 8D 05 ?? ?? ?? ?? 48 89 8B ?? ?? ?? ?? 48 89 8B ?? ?? ?? ?? 48 89 8B ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? 33 C0 48 89 8B ?? ?? ?? ?? 48 89 8B ?? ?? ?? ?? C7 83 ?? ?? ?? ?? ?? ?? ?? ??"
[StructLayout(LayoutKind.Explicit, Size = 0x1A8)]
public unsafe partial struct AtkComponentList
{
    [FieldOffset(0)] public AtkComponentBase AtkComponentBase;

    [VirtualFunction(35)]
    public partial uint GetListLength();

    [MemberFunction("E8 ?? ?? ?? ?? 41 FE 85")]
    public partial nint SetListLength(short value);

    [MemberFunction("E8 ?? ?? ?? ?? 45 38 A4 3E")]
    public partial void SetEntryText(uint index, byte* text);
}
