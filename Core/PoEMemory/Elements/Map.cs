namespace ExileCore.PoEMemory.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);
        private Element _largeMap;
        private Element _smallMap;
        public Element LargeMap => _largeMap ?? (_largeMap = ReadObjectAt<Element>(0x238));
        public float LargeMapShiftX => M.Read<float>(LargeMap.Address + 0x298);
        public float LargeMapShiftY => M.Read<float>(LargeMap.Address + 0x29C);
        public float LargeMapZoom => M.Read<float>(LargeMap.Address + 0x2D8);
        public Element SmallMiniMap => _smallMap ?? (_smallMap = ReadObjectAt<Element>(0x240));
        public float SmallMinMapX => M.Read<float>(SmallMiniMap.Address + 0x298);
        public float SmallMinMapY => M.Read<float>(SmallMiniMap.Address + 0x29C);
        public float SmallMinMapZoom => M.Read<float>(SmallMiniMap.Address + 0x2D8);
        public Element OrangeWords => ReadObjectAt<Element>(0x250);
        public Element BlueWords => ReadObjectAt<Element>(0x2A8);
    }
}
