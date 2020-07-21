namespace ConsoleApp
{
    readonly struct Entry
    {
        public float Temperature { get; }
        public byte Day { get; }

        public Entry(float temperature, byte day)
        {
            Temperature = temperature;
            Day = day;
        }
    }
}
