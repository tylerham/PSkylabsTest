namespace ImageLibrary
{
    public class FloatPixel : Pixel
    {
        public float Value { get; set; }

        public FloatPixel(float value)
        {
            Value = value;
        }
        
    }
}