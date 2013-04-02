namespace ImageLibrary
{
    public class IntPixel : Pixel{
        public int Value { get; set; }

        public IntPixel(int value)
        {
            Value = value;
        }
    }
}