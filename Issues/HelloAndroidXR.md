  



 https://www.youtube.com/watch?v=lr-q-4GT1lM  






[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/be1b2ea4-a6d7-468b-9b0c-cf0be19d45c6)](https://youtu.be/LIhLPFpDyqc)

https://youtu.be/LIhLPFpDyqc
  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/9e16cbb3-0503-49da-903f-a6fb4dfafad6)

https://www.linkedin.com/posts/80-lv_xr-ar-augmentedreality-ugcPost-7114881464139206657-3Nvw/?utm_source=share&utm_medium=member_desktop  






[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/d07c1cc4-3729-46c8-b288-ed5c2a7106bc)](https://youtu.be/6w9NY7pzv5Q)
https://youtu.be/6w9NY7pzv5Q  

![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/8f6bea07-5a21-4f0c-8bb0-2a239f5232b8)
  


















https://www.bezel.it/hq  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/f37afafd-e142-409b-b96c-be76727e4812)

https://www.shadertoy.com/view/clsSRN
Source: technobaboo
https://github.com/technobaboo  


















And so what are the tip and tricks that would allows you to do that in your game ?

Video:
- https://www.youtube.com/watch?v=24wY236Kl-4  







Video: https://www.youtube.com/watch?v=24wY236Kl-4  






https://play.google.com/store/apps/details?id=com.visor.visionhacker&hl=en&gl=US  


















Like working:
-  for 2 hours with a coffee at random place.
- Working in the train between 2-3 hours with or without PC
- Working in plane.
- In bed at home or in hospital where you can't move out
- In hospital when you need to wait for 3 hours without moving of a chair
- ...

Those kind of game can exist only in this specific situation.
So if you want to design one. What are those and what is the restriction/limitation ?  






So what are the step to do that ?

// Have the list of install apk
adb shell pm list packages
// Get the path of the apk based on the unique id given by the developer
adb shell pm path com.example.someapp
// Extract the apk at the given path on your computer
adb pull /data/app/com.example.someapp-2.apk path/to/desired/destination


Download ADB toolbox: https://developer.android.com/tools/releases/platform-tools


Car Dealer -package:com.Lynx.CarDealer
Cultural heritage  - package:com.Lynx.CulturalHeritage
Marble game - package:com.Lynx.MarbleGame
Medical Viewer - package:com.lynx.MedicalViewer
On Boarding - package:com.lynx.onboarding
PlanetariumEducation - package:com.Lynx.PlanetariumEducation
Planetarium -package:com.Lynx.Demo_Planetarium
Stereko kit Lynx - package:technobaboo.stereokit_lynx_template
Floor position - package:com.lynx.lynx_sdk
Wolvic - package:com.igalia.wolvic
Ultra Leap aurora - package:com.ultraleap.aurora
Paper toy - package:com.Ultraleap.ToyPaperPlanes


?? package:com.lynx.scenehome
?? package:com.lynx.virtualdisplay







----------------------


(APK are nothing more that a "zip"  
AAPT is a a tool to unzip and you can then check the info your are looking for.  
Info: https://stackoverflow.com/questions/28234671/what-is-aapt-android-asset-packaging-tool-and-how-does-it-work  )



com.Lynx.PlanetariumEducation
adb shell pm path com.Lynx.PlanetariumEducation
adb pull putpathhere
aapt dump badging base.apk



Game on my Lynx (at 2023 -10 -24):
package:com.android.cts.priv.ctsshim
package:com.qualcomm.qti.qcolor
package:com.android.internal.display.cutout.emulation.corner
package:com.android.internal.display.cutout.emulation.double
package:com.android.providers.telephony
package:com.android.dynsystem
package:com.android.providers.calendar
package:com.android.providers.media
package:com.qti.service.colorservice
package:com.android.internal.systemui.navbar.gestural_wide_back
package:com.qualcomm.qti.server.qtiwifi
package:com.qualcomm.qti.simcontacts
package:com.android.wallpapercropper

package:com.android.protips
package:com.qualcomm.qti.gpudrivers.kona.api30
package:com.android.documentsui
package:com.android.externalstorage
package:com.android.htmlviewer
package:com.qualcomm.qti.uceShimService
package:com.android.companiondevicemanager
package:com.android.quicksearchbox

package:com.qualcomm.qti.qms.service.connectionsecurity
package:com.android.providers.downloads
package:com.android.internal.systemui.onehanded.gestural
package:vendor.qti.hardware.cacert.server
package:com.qualcomm.qti.performancemode
package:vendor.qti.iwlan
package:com.android.soundrecorder
package:com.ultraleap.tracking.sample_client
package:android.qvaoverlay.common
package:com.android.providers.downloads.ui
package:com.android.pacprocessor
package:com.android.simappdialog
package:com.android.networkstack

package:android.overlay.common
package:com.android.connectivity.resources
package:com.android.internal.display.cutout.emulation.hole
package:com.android.internal.display.cutout.emulation.tall
package:com.android.modulemetadata
package:com.android.certinstaller
package:com.android.carrierconfig
package:com.android.internal.systemui.navbar.threebutton
package:android
package:com.android.contacts
package:com.android.camera2
package:com.qualcomm.wfd.service
package:com.qualcomm.qtil.aptxacu
package:com.qualcomm.qtil.aptxals
package:com.qti.msdc_ui

package:com.android.egg
package:com.android.mtp
package:com.android.nfc
package:com.android.backupconfirm
package:vendor.qti.qesdk.sysservice
package:com.android.provision
package:com.android.statementservice
package:android.overlay.target
package:com.qti.pasrservice
package:com.android.settings.intelligence
package:com.android.calendar
package:com.qualcomm.qti.openxrruntime
package:com.android.internal.systemui.navbar.gestural_extra_wide_back
package:com.qualcomm.qti.dynamicddsservice
package:com.qualcomm.qti.xrvd.service
package:com.android.providers.settings
package:com.android.sharedstoragebackup
package:com.android.printspooler
package:com.qti.qualcomm.mstatssystemservice
package:com.qualcomm.qti.services.systemhelper
package:com.android.wifi.resources.overlay.common
package:com.android.dreams.basic
package:com.android.webview
package:com.android.se
package:com.android.inputdevices
package:com.qualcomm.qti.biometrics.fingerprint.service
package:com.android.bips
package:com.qti.dpmserviceapp
package:com.qualcomm.location.XT.setup
package:com.android.musicfx
package:com.android.settings.overlay.common
package:com.ultraleap.tracking.service
package:android.ext.shared
package:com.android.onetimeinitializer
package:com.android.server.telecom
package:com.android.keychain
package:com.qti.snapdragon.qdcm_ff
package:com.android.wifi.resources.overlay.target
package:com.android.printservice.recommendation
package:com.android.gallery3d
package:android.ext.services
package:com.android.wifi.resources
package:com.android.phone.overlay.common
package:com.android.carrierconfig.overlay.common
package:com.android.systemui.overlay.common
package:com.android.cameraextensions
package:com.android.server.telecom.overlay.common
package:com.android.localtransport
package:com.android.packageinstaller

package:com.qualcomm.qti.devicestatisticsservice
package:com.android.theme.font.notoserifsource
package:com.android.proxyhandler
package:com.android.internal.display.cutout.emulation.waterfall
package:com.qualcomm.qti.workloadclassifier
package:com.android.inputmethod.latin
package:org.chromium.webview_shell
package:com.android.managedprovisioning
package:com.android.networkstack.tethering
package:com.android.soundpicker
package:com.android.dreams.phototable
package:com.qualcomm.qct.dlt
package:com.android.smspush
package:com.android.wallpaper.livepicker
package:com.android.apps.tag
package:be.eloistree.eloixplabh
package:be.eloistree.eloixplab

package:com.android.storagemanager
package:com.android.bookmarkprovider
package:com.android.settings
package:com.qualcomm.qti.cne
package:com.qualcomm.qti.lpa
package:com.qualcomm.qti.smq
package:com.qualcomm.qti.sva
package:com.qualcomm.qti.uim
package:com.android.networkstack.permissionconfig
package:com.qualcomm.location
package:com.CrimsonXR.HellRift
package:com.android.cts.ctsshim
package:com.qualcomm.qti.uimGbaApp
package:com.caf.fmradio
package:com.qti.diagservices
package:com.qualcomm.qti.services.secureui
package:com.android.vpndialogs
package:com.qualcomm.location.XT
package:com.android.music
package:com.android.shell
package:com.android.wallpaperbackup
package:com.android.providers.blockednumber
package:org.codeaurora.snapcam
package:com.android.providers.userdictionary
package:com.android.providers.media.module
package:com.android.emergency
package:com.qualcomm.qti.seccamservice
package:com.android.hotspot2.osulogin
package:com.qualcomm.qti.xrcb
package:com.android.internal.systemui.navbar.gestural
package:com.android.location.fused

package:com.android.deskclock
package:com.android.systemui
package:com.android.bluetoothmidiservice
package:com.qualcomm.qti.poweroffalarm
package:com.qti.ltebc
package:com.ultraleap.aurora
package:com.android.permissioncontroller
package:com.android.traceur
package:com.qualcomm.qti.ssmeditor
package:com.ultraleap.openxr.api_layer
package:com.qualcomm.qtil.aptxui
package:com.qualcomm.qtil.btdsda
package:com.android.bluetooth
package:com.qualcomm.timeservice
package:com.qualcomm.embms
package:com.android.providers.contacts
package:vendor.qti.imsrcs
package:com.android.captiveportallogin
package:com.android.internal.systemui.navbar.gestural_narrow_back
package:com.android.cellbroadcastreceiver.overlay.common

adb shell am start -n com.example.appname/com.example.appname.MainActivity


  












So in an ADB app you can code something to go faster with this tasks that every body need.  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/32242945-41ce-4ed5-82e0-2fd3c4d6c029)
https://youtu.be/IwfonYuowQQ  







- Ground,
- Four walls room,
- Several walls room,
- Weird rooms
- Object spacing : Table, bed, screen...
- ...

That should be a tool that export in Json to be use by any that don't want to calibrate the room in there space. But that can be use in app of the developer want.

A linked point to an other needed package is to be able to anchor the room on a fixed point that can be associated to a room triangulation.  







Basically a "Tardis bag"

So the question is simple. What are the best way to create portal in Unity3D ?
![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/1eb1982c-57b1-49fd-9b76-30780635d0f0)

https://www.youtube.com/shorts/GaAJ783lvAA  











































So how many time can it last like this ?
![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/0f9385da-71f4-4fce-8ca0-b5a5b91bc751)
  






- Meshy  








[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/1106c008-4155-4a76-a2f4-7fb951210354)](https://youtu.be/VCXe0Dm1tJs?t=1230)


https://youtu.be/VCXe0Dm1tJs
https://youtu.be/VCXe0Dm1tJs?t=1230  












![cooldesign](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/ec18d7d8-d72f-48cf-843b-56dc067dfa8f)
  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/b3888624-72e7-4594-a9e6-2d86ba5e3020)

![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/de820de7-2d8d-4d46-ac8a-2de029489aec)

This repository is your friend: 
https://github.com/hecomi/uWindowCapture  
(Fork if it is delete one day: https://github.com/EloiStree/2023_07_23_Fork_uWindowCapture)  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/15a031b3-7ede-4247-95f5-2857f912d8e2)
  






What I try to do with Eloi Lab.

So let's se how we can use some Steam API feature in our SteamVR version of Eloi Lab.

[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/8065671e-2251-4550-9e6d-7dc5d464c6f1)
](https://youtu.be/s554p28MTxY)
[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/0f623d3f-6632-4494-bdb6-2912d32a9ea1)](https://youtu.be/s554p28MTxY)
https://youtu.be/s554p28MTxY

![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/4c135c87-a9ed-4df8-bf7b-0ce95735d02a)
https://www.youtube.com/watch?v=mr5UpczYQME


Be how do we push our game to steam when the store is ready ?




------------


Manual: https://steamworks.github.io/installation/
Git: https://github.com/rlabrecque/Steamworks.NET/releases


[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/a83baa09-3daf-4a8c-b7f4-d98756d30035)](https://youtu.be/hXZmUCkGZP8?t=227)
https://youtu.be/hXZmUCkGZP8?t=227  






You still can with Quest 3 in 3dof.

So what game it playable in train ?
Feel free to participated to this post and propose what you played in train (or bus).

For my part:
- Game:
  - Virtual Boy (20 games)
  - Quake on Quest
  - Old Doom on Quest
  - Video player to watch movies.
- App:
  - 2D Text editor of Google Play (ask me if you need to learn to extract them)
  - 2D Youtube and [Odysee ](https://odysee.com)

You can participated in this thread or on the comment of the following video:  
https://www.youtube.com/watch?v=M3IA040sbzw&lc=UgxvCEuiBQbLIva017h4AaABAg  

  












![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/e927c7e1-5f50-481f-b080-4ac3dacf65fa)


https://youtu.be/DustblCzdhM?t=983  







![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/4375bd12-95b0-4677-9cf8-e5bc87d68ffe)

![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/b2bf2966-14f7-43e8-9890-b6f13bd1b0aa)

  






  






https://github.com/EloiStree/HelloAndroidXR/blob/main/Note/2023_11_09_70YearForXRGaming.md

Topic with Lynx R1 community :   
https://discord.com/channels/902609415281201253/1172145602222641152  
  


















So I am looking to do it in the new system of OpenXR or Q3.

https://docs.unity3d.com/Manual/SinglePassInstancing.html



The old way: https://youtu.be/E48PWyujNfI



``` GPT

To create a Shader Graph shader to display two left and right textures with the provided code that uses _LeftEyeColor and _RightEyeColor, you can follow these steps:

Create a Shader Graph:

Open Unity's Shader Graph window.
Create a new Shader Graph.
Add the Shader Properties:

In the Shader Graph, add two properties: _LeftEyeColor and _RightEyeColor of type "Color." These properties will be used to control the colors of the left and right eyes.
Design the Visual Effect:

Use Shader Graph nodes to design your shader. In this case, you want to use _LeftEyeColor and _RightEyeColor to determine the colors for the left and right eyes.
Create Materials:

After designing your Shader Graph, you can create materials based on your shader.
Configure Stereo Rendering:

The code you provided in your question handles stereo rendering. When you create materials using this shader and assign them to objects, Unity will automatically render the left and right eyes as required for your VR headset.
Test in VR:

Ensure you have a compatible VR headset connected and that your project is set up for VR development.
Test your scene in VR mode to see the stereo effect in action.
Here's an outline of how to set up the Shader Graph using the provided code. The code you provided already handles stereo rendering by lerping between _LeftEyeColor and _RightEyeColor based on unity_StereoEyeIndex. You don't need to make any additional modifications to the shader code itself. The key is to set up your materials and Unity's XR system to handle stereo rendering for you.
```

![Uploading image.png…]()


Must watch (headache a head) video on unity_StereoEyeIndex XR rendering.  
https://youtu.be/datOOos-944?t=1191


Some hope over there:
-https://gist.github.com/paperli/439a3a5d8828d744a367b349ccc847f4
- https://gist.github.com/paperli/590e2576f6ff1fe6e6790e5f6bc87e8e  







What can we run between XR headset like Quest with Sketchup ?

- https://play.google.com/store/apps/details?id=com.trimble.buildings.sketchup&irclickid=3DTUNI3XkxyPWZTTgU2Ql150UkFVi%3AwzgXzPUc0&irgwc=1&utm_source=impact&utm_medium=affiliate&utm_campaign=Hypeee
- https://help.sketchup.com/en/sketchup-viewer/setting-sketchup-viewer-vr


-https://ecom-prd.trimblepaas.com/account/organization/1699736486039353/plans

Odile house: - app.sketchup.com/app?3dwid=96138e8d-5592-4fd6-be99-86895eb8b977


- Oculus Lab: https://www.meta.com/nl-nl/experiences/9874528232572675/?item_id=9874528232572675&r=1&utm_source=www.google.com&utm_medium=oculusredirect


- xr.sketchup.com
- https://www.meta.com/en-gb/experiences/9874528232572675/?ranking_trace=1001000449923655_9874528232572675_QUESTSEARCH_u2wm4w1EVcT7glfKq4_eyJwbGF0Zm9ybSI6ImFuZHJvaWQtNmRvZiIsInF1ZXJ5X3N0cmluZyI6InNrZXRjaHVwIiwibG9jYWxlIjoiZW5fR0IiLCJudW1fZmV0Y2giOjEwMSwic2VhcmNoX3JvdXRlIjoid2ViIiwidGFnX2lkcyI6W119_eyJzZWN0aW9uX2tleSI6IlNFQVJDSCJ9


- https://vrsketch.eu


  






https://twitter.com/sergeyglkn/status/1724462190952960057?s=


[![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/059979d5-f0be-4999-a189-6c9c39963ff1)](https://twitter.com/letkma/status/1620778620028428292)
https://twitter.com/letkma/status/1620778620028428292  






https://www.gbmb.org/mbps-to-mbs


![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/afc54271-db75-4299-aaac-1233796b90e9)
https://www.techtarget.com/searchnetworking/definition/Mbps#:~:text=People%20can%20find%20out%20roughly,possible%20speed%20of%20a%20network.  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/f80d7b54-4639-4a31-8a52-257644503432)

https://fabien.benetou.fr/pub/home/future_of_text_demo/engine/  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/5f584aa7-ac85-4959-9b1e-43cb49a199d0)

https://varjo.com/product-updates/feature-preview-masking-with-varjo-lab-tools/  






https://varjo.com/product-updates/feature-preview-masking-with-varjo-lab-tools
https://vimeo.com/396292270/

![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/df01eca2-c395-491c-8cde-442b8472b029)
![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/26e31856-27b8-4a8f-842f-a1fc8a30504f)
  






You need to push it by WiFi.

Using UDP means splitting in small package of 65000 max bytes. 

Should we use MQTT, UDP, WebSocker, Socker IO... ?


- https://socket.io
- https://github.com/itisnajim/SocketIOUnity
   - https://github.com/doghappy/socket.io-client-csharp
- https://youtu.be/ZKEqqIO7n-k  












https://www.linkedin.com/posts/natzke_quest3-arkit-vr-activity-7132797180448292864-oDhw?utm_source=share&utm_medium=member_desktop    






- https://github.com/EloiStree/2023_11_22_VibrationOpenXR  







The Oculus version of that:
https://developer.oculus.com/downloads/package/oculus-adb-drivers/

The phone one I was using years ago:
https://developer.android.com/studio/run/win-usb 
  







Git file should be under 25Mo and under 50Mo on GitHub.  (Max 100 Mo)
You can use large file git if you need more but it has a cost.  


![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/20596ea6-6c54-454d-bb59-0fe8770d3241)  

![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/81e2ad66-241e-4f1a-8f46-4a8c6c1f8a58)
  






![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/dc0f2004-4ccc-4a88-b805-7e91fff83b63)
- https://sidequestvr.com/app/13654/meadow-ggj-2023
  - https://youtu.be/cZ5NJ10AKrA  












Could we caliber the hill round and house around to see a space ship in the sky with real size.
![image](https://github.com/EloiStree/HelloAndroidXR/assets/20149493/47cc9f73-0ee7-48a8-9664-f75124fa3833)
  


