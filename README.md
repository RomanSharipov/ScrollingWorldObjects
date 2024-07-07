# ScrollingWorldObjects

![Video_2024_07_07-2](https://github.com/RomanSharipov/ScrollingWorldObjects/assets/82954950/8259ffb5-8ea7-426d-80d6-96cbd34974e9)


The ScrollingWorldObject.cs script will help you scroll through any objects in the world,
what is not on the canvas.
This can be useful if you need to scroll through 3D objects in the game menu or somewhere else,
but you don't want to use RenderTexture

To use it you need

create an instance of the class using the "new" operator in your MonoBehaviour class.
fill in the parameters in the ScrollingWorldObject.cs constructor

allObjects are the objects that will be scrolled

distanceBetweenObjects - distance between objects

durationSwipe - duration of one movement of objects

camera is the camera in front of which objects will move

currentIndex is which of your objects will be in front of the camera at startup

You can manually set the position of objects in height and distance from the camera directly on the stage (the script does not change these positions in any way)

ATTENTION TO WORK YOU NEED the DOTWEEN plugin from AsetStore.
