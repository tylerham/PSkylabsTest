PSkylabsTest
============

ImageLibrary
----

If you're not familiar with a Visual Studio project, please focus on the *.cs files in ImageLibrary\:
 - Image.cs
 - Pixel.cs
 - IntPixel.cs
 - FloatPixel.cs
 and the test ImageLibrary.Specs\:
 - ImageSpecs.cs

I used C# because it is the stack that I am most familar with and have used day to day. I'm most confident with the testing tools which I used to drive out the code - although I already had some idea of an overall design in my head.
I used Machine.Specifications (which was inspired by Ruby's RSpec) and FluentAssertations for testing. Again, because I'm familar with them, but I also (mostly) like the syntax. I find it to be more readable and helps document the code.

Not implemented: 
 - RGB

Room for improvement: 
 - float pixels versus int pixels: the Value property should be in the interface
 - use of enums with switch statements can be a code smell (sometimes): future extension will require more significant refactoring as compared to a better implementation

JavaScript View Camera Images
----

