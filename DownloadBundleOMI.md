![WIP](https://github.com/EloiStree/EloiStree/blob/master/Images/WIP.png)  

# A bit of concept

## Simply 

I suppose that if you read this you have interest on downloading the Open Macro Input OMI software that I am developing.  
This page give more information on what to download from the project.  

OMI for the moment is just a project of the bundle that I provide:  
https://github.com/EloiStree/EloiStree/blob/master/DownloadBundle.md    

If you prefer to download the project directly alone of the rest you can find it here:  
https://openmacroinput.itch.io/openmacroinput  



###  Not a software but a toolbox

Open Macro Input project is not a software, it is the idea of reading native information to make custom actions.  

Some of the code I add to the project for you are in Unity OMI that is the main part.    

But most of the read and write actions can't and should not be in Unity.  
So I design third party application.    

Example, I could try to make a tool that write Xbox keystroke in the main unity project.  
But then it won't compile on iOs and Android XR and make the project heavier.  
So I did a Udp console application to do that specificaly outside of the main app.  



- OMI : Is the Unity applications 
- XOMI : Is a the toolboxes that target XInput of Window Xbox
- JOMI : Is a Java toolboxes that allows you to write keystroke and mouse action on any platform with java.
- AOMI: (not dev yet) Is the toolboxes using ADB to remote control Android devices.
- HOMI: (not dev yet) Is an alternative to Hamachi to communicate between devices on the LAN and internet
