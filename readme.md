For the Force capture
SimpleInput_SingleChannel_Method 
and 
Custom

Were the one I was working on. SimpleInput_SingleChannel_Method was more about finding which 
compilers they used and figuring out how to link it. But it had a ton of pointless UI. 
Custom was made to simplify it even more to only have the necessary code to pull data. 
It should be working, but this repo (might) be out of date. The machine in the lab, should have the latest version. 
It took a while to strip it all down and create a fake NULL UI

For the camera, it's in C++ Cameras directory. 


For Both, 
there's a build.bat for all 3 scripts that should just work. There's also a .sln for the C++ at the root

The C++ code for the camera doesn't pull the force in a variable. The separate thread just prints to stdout. It would be needed to read through the docs
and find the method to pull it


Then, we'd need to either: Recreate all the C++ types (of the tree of data structures) in the Camera, and then import the dll
and run its method in C#. Which would take a while because they really nested their types
Or, write a C++ wrapper script, which limits the number of limited method and simplify the output types.
Then write the C++ -> C# for them, and import the C++ dll, and use it's method in C#.

Then, in one master C# File, we'd need to do:
Loop
    C++ Camera pull
    C# Force capture pull
    Write to a file
