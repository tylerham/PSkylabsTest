using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Machine.Specifications;
using ImageLibrary;

namespace ImageLibrary.Specs
{
    public class ImageSpecs
    {
        protected static Image SUT;
        protected static int _width = 9;
        protected static int _height = 11;
        protected static Image.PixelFormat _pixelFormat = Image.PixelFormat.Int;
        protected static Image.PixelType _pixelType = Image.PixelType.Grey;

        public class when_creating_an_image
        {
            Because of = () => SUT = new Image(_width, _height, _pixelFormat, _pixelType);
            It should_return_an_image = () => SUT.Should().NotBeNull();
            It should_have_the_width = () => SUT.Width.Should().Be(_width);
            It should_have_the_height = () => SUT.Height.Should().Be(_height);
        }
        public class when_copying_an_image
        {
            private static Image copied;
            Establish that =()=> SUT = new Image(_width, _height, _pixelFormat, _pixelType);
            private Because of = () => copied = SUT.Copy();
            private It should_have_the_same_height = () => copied.Height.Should().Be(SUT.Height);
        }
        public class when_setting_and_getting_a_grey_pixel
        {
            static IntPixel pixel = new IntPixel(9);
            Establish that = () => SUT = new Image(_width, _height, _pixelFormat, _pixelType);

            private Because of = () => SUT.Set(4, 3, pixel);
            private It should_return_a_pixel_of_type_int_pixel = () => SUT.Get(4, 3).Should().BeOfType<IntPixel>();
            private It should_return_a_pixel_of_the_proper_value = () => ((IntPixel)SUT.Get(4, 3)).Value.Should().Be(9);
        }
        [Ignore("Stub function")]
        public class when_convolving
        {
            private static Image result;
            private static Image kernel;
            Establish that = () => { 
                SUT = new Image(_width, _height, _pixelFormat, _pixelType);
                kernel = new Image(3, 3, _pixelFormat, _pixelType);
            };

            private Because of = () => result = SUT.Convolve(kernel);
        }
        [Ignore("Stub function")]
        public class when_scaling
        {
            private static Image result;
            private static int scaleFactor;
            Establish that = () => { 
                SUT = new Image(_width, _height, _pixelFormat, _pixelType);
                scaleFactor = 3;
            };

            private Because of = () => result = SUT.Scale(scaleFactor);
        }
    }
}
