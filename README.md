PSkylabsTest
============

ImageLibrary
----

If you're not familiar with a Visual Studio project, please focus on the *.cs files in ImageLibrary\
 - Image.cs
 - Pixel.cs
 - IntPixel.cs
 - FloatPixel.cs
 and the test ImageLibrary.Specs\
 - ImageSpecs.cs

I used C# because it is the stack that I am most familar with and have used day to day. I'm most confident with the testing tools which I used to drive out the code - although I already had some idea of an overall design in my head.
I used Machine.Specifications (which was inspired by Ruby's RSpec) and FluentAssertations for testing. Again, because I'm familar with them, but I also (mostly) like the syntax. I find it to be more readable and helps document the code.

Not implemented: 
 - RGB

Room for improvement: 
 - float pixels versus int pixels: the Value property should be in the interface
 - use of enums with switch statements can be a code smell (sometimes): future extension will require more significant refactoring as compared to a better implementation
 - overall style and cleanup of code
 - inline documentation and comments, but I always try to have self documenting code

JavaScript View Camera Images
----

I thought this would be the more difficult of the two, for me, so I started on it first.
Unfortunatly, I got mired in Backbone, which I thought I knew beter than it seems I do.

How I intended the code to work:

image model:
 - id
 - src of image
 - previous-image-id
 - previous-image-src
 - next-image-id
 - next-image-src

An image is a model that has a reference to the id (and source of a thumbnail) of the next and previous images. The server would typically provide these in chronological order. Clicking on the thumbnail of the next/previous image changes that model to the currently active one.
Optionally, the entire list of images wouldn't have to be in the collection that backbone gets from the server, but it should be fine - it's only 1008 entries as described by the problem.

Changing cameras would be a dropdown, or just a list of links.