namespace ImageLibrary
{
    public class Image
    {
        public enum PixelFormat{Float, Int}
        public enum PixelType{Grey, RGB}
        public PixelFormat _pixelFormat;
        public PixelType _pixelType;
        private Pixel[] _imageBuffer;
        public int Height { get; private set; }
        public int Width { get; private set; }

        public Image(int width, int height, PixelFormat pixelFormat, PixelType pixelType)
        {
            Width = width;
            Height = height;
            switch (pixelFormat)
            {
                case PixelFormat.Float:
                    _imageBuffer = new FloatPixel[width*height];
                    break;
                case PixelFormat.Int:
                    _imageBuffer = new IntPixel[width*height];
                    break;
            }
            _pixelFormat = pixelFormat;
            _pixelType = pixelType;
        }

        public Image Copy()
        {
            return this;
        }
        public void Set(int row, int column, IntPixel pixel)
        {
            _imageBuffer[row*column] = pixel;
        }
        public Pixel Get(int row, int column)
        {
            return _imageBuffer[row*column];
        }

        public Image Convolve(Image kernel)
        {
            return this;
        }

        public Image Scale(int scaleFactor)
        {
            return this;
        }
    }
}